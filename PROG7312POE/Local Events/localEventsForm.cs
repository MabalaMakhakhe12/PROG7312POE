using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using FuzzySharp;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Reflection.Emit;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using PROG7312POE.Report_Issues;

namespace PROG7312POE
{
    public partial class LocalEventsForm : Form
    {
        private SortedDictionary<DateTime, string> events;
        private HashSet<string> categories;
        private Stack<string> searchHistory;
        private Dictionary<string, List<string>> recommendations;
        private Dictionary<string, List<string>> categoryEventMapping;
        private Dictionary<string, int> searchFrequency;
        private PriorityQueue<string, int> priorityQueue;
        private eventsAndCategories eventsAndCategories;
        private PictureBox wallpaper;

        public LocalEventsForm()
        {
            InitializeComponent();
            wallpaper = new PictureBox();
            UIElements.InitializeBackground(this, wallpaper);
            eventsAndCategories = new eventsAndCategories();
            events = eventsAndCategories.events;
            categories = eventsAndCategories.Categories;
            categoryEventMapping = eventsAndCategories.categoryEventMapping;
            searchHistory = new Stack<string>();
            recommendations = new Dictionary<string, List<string>>();
            searchFrequency = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
            priorityQueue = new PriorityQueue<string, int>();

            UIElements.ResizeEvents(lblEvents, lblCategories, lstEvents, lstCategories, txtSearch, lblRecommendations, btn_Search, lstRecommended);
            DisplayEvents();
        }

        //<----------------------------------------------------------------------------------------------------------------------------------------------->//

        /// <summary>
        /// Handles the form closing event to show the dashboard.
        /// </summary>
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (!(e.CloseReason == CloseReason.UserClosing && Application.OpenForms.OfType<ReportIssues>().Any()))
            {
                Dashboard dashboard = Application.OpenForms.OfType<Dashboard>().FirstOrDefault();
                if (dashboard != null)
                {
                    dashboard.Show();
                    dashboard.Focus();
                }
            }
        }

            //<----------------------------------------------------------------------------------------------------------------------------------------------->//

            /// <summary>
            /// Displays the events and categories in the respective list boxes.
            /// </summary>
            private void DisplayEvents()
        {
            foreach (var eventInfo in events)
            {
                lstEvents.Items.Add($"{eventInfo.Value} - {eventInfo.Key:yyyy-MM-dd}");
            }

            foreach (var category in categories)
            {
                lstCategories.Items.Add(category);
            }
        }

        //<----------------------------------------------------------------------------------------------------------------------------------------------->//

        /// <summary>
        /// searches for events when clicked.
        /// </summary>
        private void btn_Search_Click(object sender, EventArgs e)
        {
            searchEvents(txtSearch.Text.Trim());
        }

        //<----------------------------------------------------------------------------------------------------------------------------------------------->//

        /// <summary>
        /// Searches for events based on the query.
        /// </summary>
        private async void searchEvents(string query)
        {
            try
            {
                progressSearch.Visible = true;
                progressSearch.Value = 0;

                if (DateTime.TryParse(query, out DateTime searchDate))
                {
                    SearchByDate(searchDate);
                }
                else
                {
                    await SearchByCategory(query);
                }

                if (!string.IsNullOrWhiteSpace(query))
                {
                    updatePriorityQueue(query);
                }

                recommendEvents(lstRecommended);
                progressSearch.Value = 100;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while searching for events: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                progressSearch.Visible = false;
            }
        }

        //<----------------------------------------------------------------------------------------------------------------------------------------------->//

        /// <summary>
        /// Searches for events by date.
        /// </summary>
        private void SearchByDate(DateTime searchDate)
        {
            if (events.TryGetValue(searchDate, out string eventName))
            {
                MessageBox.Show($"Event on {searchDate:yyyy-MM-dd}: {eventName}");
            }
            else
            {
                MessageBox.Show("No events found on this date.");
            }
        }

        //<----------------------------------------------------------------------------------------------------------------------------------------------->//

        /// <summary>
        /// Searches for events by category.
        /// </summary>
        private async Task SearchByCategory(string query)
        {
            progressSearch.Value = 20;

            var matchingCategory = await Task.Run(() =>
            {
                return categories
                    .Select(cat => new { Category = cat, Score = Fuzz.PartialRatio(query, cat) })
                    .OrderByDescending(result => result.Score)
                    .FirstOrDefault(result => result.Score > 70)?.Category;
            });

            progressSearch.Value = 50;

            if (!string.IsNullOrEmpty(matchingCategory))
            {
                await DisplayFilteredEvents(matchingCategory);
                UpdateSearchFrequency(matchingCategory);
            }
            else
            {
                MessageBox.Show("No matching categories found.");
            }
        }

        //<----------------------------------------------------------------------------------------------------------------------------------------------->//

        /// <summary>
        /// Displays the filtered events based on the matching category.
        /// </summary>
        private async Task DisplayFilteredEvents(string matchingCategory)
        {
            var filteredEvents = await Task.Run(() =>
            {
                return events
                    .Where(e => categoryEventMapping[matchingCategory].Contains(e.Value));
            });

            progressSearch.Value = 80;

            if (filteredEvents.Any())
            {
                MessageBox.Show($"Events in {matchingCategory} category: " + string.Join(", ", filteredEvents.Select(e => e.Value)));
            }
            else
            {
                MessageBox.Show($"No events found in {matchingCategory} category.");
            }
        }

        //<----------------------------------------------------------------------------------------------------------------------------------------------->//

        /// <summary>
        /// Updates the search frequency for the given category.
        /// </summary>
        private void UpdateSearchFrequency(string category)
        {
            if (!searchFrequency.ContainsKey(category))
            {
                searchFrequency[category] = 1;
            }
            else
            {
                searchFrequency[category]++;
            }
        }

        //<----------------------------------------------------------------------------------------------------------------------------------------------->//

        /// <summary>
        /// Updates the priority queue with the search query.
        /// </summary>
        private void updatePriorityQueue(string query)
        {
            if (searchFrequency.ContainsKey(query))
            {
                priorityQueue.Enqueue(query, searchFrequency[query]);
            }
        }

        //<----------------------------------------------------------------------------------------------------------------------------------------------->//

        /// <summary>
        /// Recommends events based on the search history.
        /// </summary>
        private void recommendEvents(ListBox lstRecommended)
        {
            lstRecommended.Items.Clear();

            var recommendedCategories = priorityQueue.UnorderedItems
                .OrderByDescending(item => item.Priority)
                .Select(item => item.Element)
                .Take(3)
                .ToList();

            List<string> recommendedEvents = new List<string>();
            foreach (var category in recommendedCategories)
            {
                if (categoryEventMapping.ContainsKey(category))
                {
                    recommendedEvents.AddRange(categoryEventMapping[category]);
                }
            }

            if (recommendedEvents.Any())
            {
                var recommendationsWithDates = recommendedEvents
                    .Distinct()
                    .Select(eventName =>
                    {
                        var eventDate = events.FirstOrDefault(e => e.Value.Equals(eventName)).Key;
                        return $"{eventName} - {eventDate:yyyy-MM-dd}";
                    })
                    .ToList();

                foreach (var recommendation in recommendationsWithDates)
                {
                    lstRecommended.Items.Add(recommendation);
                }
            }
            else
            {
                lstRecommended.Items.Add("No related events found.");
                lstRecommended.Items.Add("Make sure you do not have any spelling errors.");
            }
        }

        //<----------------------------------------------------------------------------------------------------------------------------------------------->//

        /// <summary>
        /// Handles the search text box enter event.
        /// </summary>
        private void TxtSearch_Enter(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            if (txtSearch.Text == "Search by category or date (YYYY-MM-DD)")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = System.Drawing.Color.Black;
            }
        }

        //<----------------------------------------------------------------------------------------------------------------------------------------------->//

        /// <summary>
        /// Handles the search text box leave event.
        /// </summary>
        private void TxtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "Search by category or date (YYYY-MM-DD)";
                txtSearch.ForeColor = System.Drawing.Color.Gray;
            }
        }

        //<----------------------------------------------------------------------------------------------------------------------------------------------->//

        /// <summary>
        /// Redirects user to the Report Issues page.
        /// </summary>
        private void btnReportIssues_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnReportIssues.Height;
            pnlNav.Top = btnReportIssues.Top;
            btnReportIssues.BackColor = Color.FromArgb(46, 51, 73);
            ReportIssues reportIssuesForm = new ReportIssues();
            reportIssuesForm.Show();
            this.Hide(); 
        }


        //<----------------------------------------------------------------------------------------------------------------------------------------------->//

        /// <summary>
        /// Redirects the user the dashboard.
        /// </summary>
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard form1 = Application.OpenForms.OfType<Dashboard>().FirstOrDefault();
            if (form1 != null)
            {
                form1.Show();
                form1.Focus();
            }
            this.Close();
        }

        //<----------------------------------------------------------------------------------------------------------------------------------------------->//

        /// <summary>
        /// Directs the user back to the dashboard
        /// </summary>
        private void backArrow_Click(object sender, EventArgs e)
        {
            Dashboard form1 = Application.OpenForms.OfType<Dashboard>().FirstOrDefault();
            if (form1 != null)
            {
                form1.Show();
                form1.Focus();
            }
            this.Close();
        }

        /// <summary>
        /// Closes the events form.
        /// </summary>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
//------------------------------------------------------------------END OF FILE----------------------------------------------------------------------------------------->//

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
            wallpaper = new PictureBox
            {
                Dock = DockStyle.Fill,
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            this.Controls.Add(wallpaper);

            Thread backgroundThread = new Thread(() => BackgroundLoader.LoadBackground(this, wallpaper));
            backgroundThread.IsBackground = true;
            backgroundThread.Start();
            eventsAndCategories = new eventsAndCategories();
            events = eventsAndCategories.events;
            categories = eventsAndCategories.Categories;
            categoryEventMapping = eventsAndCategories.categoryEventMapping;
            searchHistory = new Stack<string>();
            recommendations = new Dictionary<string, List<string>>();
            searchFrequency = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
            priorityQueue = new PriorityQueue<string, int>();


            resize();
            DisplayEvents();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Form1 form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            if (form1 != null)
            {
                form1.Show();
                form1.Focus();
            }
        }
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

        private void btn_Search_Click(object sender, EventArgs e)
        {
            searchEvents(txtSearch.Text.Trim());
        }

        private async void searchEvents(string query)
        {
            try
            {
                progressSearch.Visible = true;
                progressSearch.Value = 0;

                DateTime searchDate;

                if (DateTime.TryParse(query, out searchDate))
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
                else
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

                        if (!searchFrequency.ContainsKey(matchingCategory))
                        {
                            searchFrequency[matchingCategory] = 1;
                        }
                        else
                        {
                            searchFrequency[matchingCategory]++;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No matching categories found.");
                    }
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




        private void updatePriorityQueue(string query)
        {
            if (searchFrequency.ContainsKey(query))
            {

                priorityQueue.Enqueue(query, searchFrequency[query]);
            }
        }

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



        private void TxtSearch_Enter(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            if (txtSearch.Text == "Search by category or date (YYYY-MM-DD)")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = System.Drawing.Color.Black;
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
        }
        private void TxtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "Search by category or date (YYYY-MM-DD)";
                txtSearch.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void btnReportIssues_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnReportIssues.Height;
            pnlNav.Top = btnReportIssues.Top;
            btnReportIssues.BackColor = Color.FromArgb(46, 51, 73);
            ReportIssues reportIssuesForm = new ReportIssues();
            reportIssuesForm.Show();
            this.Close();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Form1 form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            if (form1 != null)
            {
                form1.Show();
                form1.Focus();
            }
            this.Close();
        }

        private void backArrow_Click(object sender, EventArgs e)
        {
            Form1 form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            if (form1 != null)
            {
                form1.Show();
                form1.Focus();
            }
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void resize()
        {
            lblEvents.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            lblCategories.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lstEvents.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lstCategories.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Right;
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblRecommendations.Anchor = AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Right;
            btn_Search.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lstRecommended.Anchor = AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Right;

        }

        private void progressSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
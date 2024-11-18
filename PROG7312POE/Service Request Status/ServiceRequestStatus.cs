using PROG7312POE.Report_Issues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PROG7312POE
{
    public partial class ServiceRequestStatus : Form
    {
        private BinarySearchTree<string, string> issueDataTree;
        private Graph<string> issueDataGraph;
        private PictureBox wallpaper;


        public ServiceRequestStatus(BinarySearchTree<string, string> issueDataTree, Graph<string> issueDataGraph)
        {
            InitializeComponent();
            wallpaper = new PictureBox();
            UIElements.InitializeBackground(this, wallpaper);
            this.issueDataTree = issueDataTree;
            this.issueDataGraph = issueDataGraph;
            LoadServiceRequests();
            UIElements.ResizeServiceRequestStatusControls(listViewRequests, txtSearchValue,lblReportID, btnRefresh, btnDFS, btnBFS, btnSortByPriority, btnDashboard, btnReportIssues, btnAnnouncements, backArrow);

        }
        //<----------------------------------------------------------------------------------------------------------------------------------------------->//

        /// <summary>
        /// Handles the form closing event to show the Dashboard form.
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
        /// Loads service requests from the binary search tree and populates the ListView.
        /// </summary>
        private void LoadServiceRequests()
        {
            listViewRequests.Items.Clear();
            if (issueDataGraph == null)
            {
                issueDataGraph = new Graph<string>();
            }
            var categoryToReportIDs = new Dictionary<string, List<string>>();
           issueDataTree.InOrderTraversal((key, value) =>
            {
                if (key.EndsWith("_ReportID"))
                {
                    string reportID = value;
                    reportID = reportID.Trim();
                    string location = issueDataTree.TryGetValue(reportID + "_Location", out var loc) ? loc : "N/A";
                    string category = issueDataTree.TryGetValue(reportID + "_Category", out var cat) ? cat : "N/A";
                    string issueDescription = issueDataTree.TryGetValue(reportID + "_IssueDescription", out var desc) ? desc : "N/A";
                    string status = issueDataTree.TryGetValue(reportID + "_Status", out var stat) ? stat : "Pending";
                    string priority = issueDataTree.TryGetValue(reportID + "_Priority", out var prio) ? prio : "Normal";
                    ListViewItem item = new ListViewItem(reportID);
                    item.SubItems.Add(location);
                    item.SubItems.Add(category);
                    item.SubItems.Add(issueDescription);
                    item.SubItems.Add(status);
                    item.SubItems.Add(priority);
                    listViewRequests.Items.Add(item);

                    if (!issueDataGraph.ContainsVertex(reportID))
                    {
                        issueDataGraph.AddVertex(reportID);
                    }
                    if (issueDataTree.TryGetValue(reportID + "_Category", out var categoryValue))
                    {
                        if (!categoryToReportIDs.ContainsKey(categoryValue))
                        {
                            categoryToReportIDs[categoryValue] = new List<string>();
                        }
                        categoryToReportIDs[categoryValue].Add(reportID);
                    }
                }

            });
            foreach (var category in categoryToReportIDs.Keys)
            {
                var reportIDs = categoryToReportIDs[category];
                for (int i = 0; i < reportIDs.Count; i++)
                {
                    for (int j = i + 1; j < reportIDs.Count; j++)
                    {
                        issueDataGraph.AddEdge(reportIDs[i], reportIDs[j]);
                    }
                }
            }
        }


        //<----------------------------------------------------------------------------------------------------------------------------------------------->//

        /// <summary>
        /// Refreshes the service requests by reloading them.
        /// </summary>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadServiceRequests();
        }


        //<----------------------------------------------------------------------------------------------------------------------------------------------->//

        /// <summary>
        /// Clears the ListView and performs a Depth-First Search (DFS) based on the search value.
        /// </summary>
        private void btnDFS_Click(object sender, EventArgs e)
        {
            listViewRequests.Items.Clear();
            string searchValue = txtSearchValue.Text.Trim();
            if (string.IsNullOrEmpty(searchValue))
            {
                MessageBox.Show("Please enter a value to search for.");
                return;
            }

            PerformDFS(searchValue);
        }

        /// <summary>
        /// Clears the ListView and performs a Breadth-First Search (BFS) based on the search value.
        /// </summary>
        private void btnBFS_Click(object sender, EventArgs e)
        {
            listViewRequests.Items.Clear();

            string searchValue = txtSearchValue.Text.Trim();
            if (string.IsNullOrEmpty(searchValue))
            {
                MessageBox.Show("Please enter a value to search for.");
                return;
            }

            PerformBFS(searchValue);
        }

        //<----------------------------------------------------------------------------------------------------------------------------------------------->//

        /// <summary>
        /// Searches what the user input.
        /// </summary>
        private void btnSearchReport_Click(object sender, EventArgs e)
        {
            string searchValue = txtSearchValue.Text.Trim();

            if (string.IsNullOrEmpty(searchValue))
            {
                MessageBox.Show("Please enter a value to search for.");
                return;
            }
        }

        //<----------------------------------------------------------------------------------------------------------------------------------------------->//

        /// <summary>
        /// Method to perform DFS on the tree, based on the search term.
        /// </summary>
        private void PerformDFS(string reportID)
        {
            listViewRequests.Items.Clear();
            issueDataGraph.DFS(reportID, relatedReportID =>
            {
                string location = issueDataTree.TryGetValue(relatedReportID + "_Location", out var loc) ? loc : "N/A";
                string category = issueDataTree.TryGetValue(relatedReportID + "_Category", out var cat) ? cat : "N/A";
                string issueDescription = issueDataTree.TryGetValue(relatedReportID + "_IssueDescription", out var desc) ? desc : "N/A";
                string status = issueDataTree.TryGetValue(relatedReportID + "_Status", out var stat) ? stat : "Pending";
                string priority = issueDataTree.TryGetValue(relatedReportID + "_Priority", out var prio) ? prio : "Normal";

                ListViewItem item = new ListViewItem(relatedReportID);
                item.SubItems.Add(location);
                item.SubItems.Add(category);
                item.SubItems.Add(issueDescription);
                item.SubItems.Add(status);
                item.SubItems.Add(priority);
                listViewRequests.Items.Add(item);
            });
        }


        //<----------------------------------------------------------------------------------------------------------------------------------------------->//

        /// <summary>
        /// Method to perform BFS on the tree, based on the search term.
        /// </summary>
        private void PerformBFS(string reportID)
        {
            listViewRequests.Items.Clear();
            issueDataGraph.BFS(reportID, relatedReportID =>
            {
                string location = issueDataTree.TryGetValue(relatedReportID + "_Location", out var loc) ? loc : "N/A";
                string category = issueDataTree.TryGetValue(relatedReportID + "_Category", out var cat) ? cat : "N/A";
                string issueDescription = issueDataTree.TryGetValue(relatedReportID + "_IssueDescription", out var desc) ? desc : "N/A";
                string status = issueDataTree.TryGetValue(relatedReportID + "_Status", out var stat) ? stat : "Pending";
                string priority = issueDataTree.TryGetValue(relatedReportID + "_Priority", out var prio) ? prio : "Normal";

                ListViewItem item = new ListViewItem(relatedReportID);
                item.SubItems.Add(location);
                item.SubItems.Add(category);
                item.SubItems.Add(issueDescription);
                item.SubItems.Add(status);
                item.SubItems.Add(priority);
                listViewRequests.Items.Add(item);
            });
        }
        /// <summary>
        /// Sorts the service requests by priority using a heap.
        /// </summary>
        private void btnSortByPriority_Click(object sender, EventArgs e)
        {
            var heap = new Heap<ListViewItem>((item1, item2) =>
            {
                string priority1 = item1.SubItems[5].Text;
                string priority2 = item2.SubItems[5].Text;
                return GetPriorityValue(priority1).CompareTo(GetPriorityValue(priority2));
            });

            foreach (ListViewItem item in listViewRequests.Items)
            {
                heap.Insert(item);
            }

            listViewRequests.Items.Clear();

            while (heap.Count > 0)
            {
                listViewRequests.Items.Add(heap.RemoveMax());
            }
        }
       

        //<----------------------------------------------------------------------------------------------------------------------------------------------->//

        /// <summary>
        /// Converts the priority text to a numerical value for sorting.
        /// </summary>
        private int GetPriorityValue(string priority)
        {
            switch (priority)
            {
                case "High":
                    return 3;
                case "Normal":
                    return 2;
                case "Low":
                    return 1;
                default:
                    return 0;
            }
        }



        //<----------------------------------------------------------------------------------------------------------------------------------------------->//

        /// <summary>
        /// Displays related service requests based on the given report ID.
        /// </summary>
        private void DisplayRelatedRequests(string reportID)
        {
            listViewRequests.Items.Clear();
            issueDataGraph.DFS(reportID, relatedReportID =>
            {
                string location = issueDataTree.TryGetValue(relatedReportID + "_Location", out var loc) ? loc : "N/A";
                string category = issueDataTree.TryGetValue(relatedReportID + "_Category", out var cat) ? cat : "N/A";
                string issueDescription = issueDataTree.TryGetValue(relatedReportID + "_IssueDescription", out var desc) ? desc : "N/A";
                string status = issueDataTree.TryGetValue(relatedReportID + "_Status", out var stat) ? stat : "Pending";
                string priority = issueDataTree.TryGetValue(relatedReportID + "_Priority", out var prio) ? prio : "Normal";

                ListViewItem item = new ListViewItem(relatedReportID);
                item.SubItems.Add(location);
                item.SubItems.Add(category);
                item.SubItems.Add(issueDescription);
                item.SubItems.Add(status);
                item.SubItems.Add(priority);
                listViewRequests.Items.Add(item);
            });
        }

      

        private void ServiceRequestStatus_Load(object sender, EventArgs e)
        {

        }
        //<----------------------------------------------------------------------------------------------------------------------------------------------->//

        /// <summary>
        /// Navigates the user to the dashboard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        //<----------------------------------------------------------------------------------------------------------------------------------------------->//

        /// <summary>
        /// Navigates the user to the Report issues page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReportIssues_Click(object sender, EventArgs e)
        {
            ReportIssues reportIssuesForm = new ReportIssues();
            reportIssuesForm.Show();
            this.Close();
        }
        //<----------------------------------------------------------------------------------------------------------------------------------------------->//

        /// <summary>
        /// Navigates the user the events announcement page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnouncements_Click(object sender, EventArgs e)
        {
            LocalEventsForm localEventsForm = new LocalEventsForm();
            localEventsForm.Show();
            this.Close();
        }
        //<----------------------------------------------------------------------------------------------------------------------------------------------->//

        /// <summary>
        /// Redirects the user back to the dashboard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backArrow_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = Application.OpenForms.OfType<Dashboard>().FirstOrDefault();
            if (dashboard != null)
            {
                dashboard.Show();
                dashboard.Focus();
            }
            this.Close();
        }


    }
}
//------------------------------------------------------------------END OF FILE----------------------------------------------------------------------------------------->//


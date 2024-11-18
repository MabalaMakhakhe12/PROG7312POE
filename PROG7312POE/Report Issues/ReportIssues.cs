using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;
using System.Threading;
using PROG7312POE.Report_Issues;

namespace PROG7312POE
{
    public partial class ReportIssues : Form
    {
        private BinarySearchTree<string, string> issueDataTree;
        private Graph<string> issueDataGraph;
        public int progressValue;
        private string[] motivationalStatements = { "Keep up the good work!", "You're making progress!", "Optionally Add an Image" };
        private PictureBox wallpaper;
        private static int reportCounter = 0;

        public ReportIssues()
        {
            InitializeComponent();
            wallpaper = new PictureBox();
            UIElements.InitializeBackground(this, wallpaper);           
            issueDataTree = new BinarySearchTree<string, string>();
            issueDataGraph = new Graph<string>();

            cmbboxCategory.Items.AddRange(new string[] { "Crime", "Sanitation", "Roads", "Utilities", "Other" });
            txtLocation.TextChanged += UpdateProgressBar;
            cmbboxCategory.SelectedIndexChanged += UpdateProgressBar;
            rtxtIssueDesc.TextChanged += UpdateProgressBar;

            UIElements.ResizeControls(txtLocation, cmbboxCategory, rtxtIssueDesc, progressBar, lblMotivation, lblLocation, lblCategory, lblIssueDesc, lblOtherCat, lblDoc, btnAttachMedia, btnSubmit2, btnViewReports, lblFeedback, txtFeedback, AttachedImage);

            progressBar.Style = ProgressBarStyle.Continuous;
            progressBar.Value = 0;
            txtOtherCategory.Visible = false;
            lblOtherCat.Visible = false;
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
            /// Handles the category selection change event to show or hide the "Other" category text box.
            /// </summary>
            private void cmbboxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbboxCategory.SelectedItem.ToString() == "Other")
            {
                txtOtherCategory.Visible = true;
                lblOtherCat.Visible = true;
            }
            else
            {
                txtOtherCategory.Visible = false;
                lblOtherCat.Visible = false;
            }
        }

        //<----------------------------------------------------------------------------------------------------------------------------------------------->//

        /// <summary>
        /// Handles the attach media button click event to open a file dialog and attach an image or document.
        /// </summary>
        private void btnAttachMedia_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp|Document Files (*.doc; *.docx; *.pdf)|*.doc; *.docx; *.pdf";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFile = openFileDialog.FileName;
                string fileExtension = Path.GetExtension(selectedFile);

                if (IsImageFile(fileExtension))
                {
                    AttachedImage.Image = Image.FromFile(selectedFile);
                }
                else
                {
                    lblDoc.Text = Path.GetFileName(selectedFile);
                }
            }
        }

        //<----------------------------------------------------------------------------------------------------------------------------------------------->//

        /// <summary>
        /// Checks if the given file extension is an image file.
        /// </summary>
        private bool IsImageFile(string fileExtension)
        {
            string[] imageExtensions = { ".jpg", ".jpeg", ".png", ".gif", ".bmp" };
            return imageExtensions.Contains(fileExtension.ToLower());
        }


        //<----------------------------------------------------------------------------------------------------------------------------------------------->//

        /// <summary>
        /// Saves the issue report data when clicked.
        /// </summary>
        private void btnSubmit2_Click(object sender, EventArgs e)
        {
            string location = txtLocation.Text;
            string issueDescription = rtxtIssueDesc.Text;
            string category = cmbboxCategory.SelectedItem != null && cmbboxCategory.SelectedItem.ToString() == "Other" ? txtOtherCategory.Text : cmbboxCategory.SelectedItem?.ToString();
            string reportID = GenerateReportID();

            string[] priorities = { "High", "Normal", "Low" };
            string status = "Pending";
            string priority = GetPriorityByCategory(category);

            if (!ValidateLocation(location))
            {
                MessageBox.Show("Invalid location format. Please enter a valid location. Ensure there is comma followed by a space in between each entry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (string.IsNullOrEmpty(location) || cmbboxCategory.SelectedItem == null || string.IsNullOrEmpty(issueDescription))
                {
                    throw new Exception("Please provide input for all fields.");
                }

                issueDataTree.Insert(reportID + "_ReportID", reportID);
                issueDataTree.Insert(reportID + "_Location", location);
                issueDataTree.Insert(reportID + "_Category", category);
                issueDataTree.Insert(reportID + "_IssueDescription", issueDescription);
                issueDataTree.Insert(reportID + "_Status", status);
                issueDataTree.Insert(reportID + "_Priority", priority);

                issueDataGraph.AddVertex(reportID + "_ReportID");
                issueDataGraph.AddVertex(reportID + "_Location");
                issueDataGraph.AddVertex(reportID + "_Category");
                issueDataGraph.AddVertex(reportID + "_IssueDescription");
                issueDataGraph.AddEdge(reportID + "_ReportID", reportID + "_Location");
                issueDataGraph.AddEdge(reportID + "_Location", reportID + "_Category");
                issueDataGraph.AddEdge(reportID + "_Category", reportID + "_IssueDescription");

                string message = $"Report ID: {reportID}\nLocation: {location}\nCategory: {category}\nIssue Description: {issueDescription}\nStatus: {status}\nPriority: {priority}";
                MessageBox.Show(message, "Saved Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                progressValue = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //<----------------------------------------------------------------------------------------------------------------------------------------------->//

        /// <summary>
        /// Gets the priority based on the category.
        /// </summary>
        private string GetPriorityByCategory(string category)
        {
            switch (category)
            {
                case "Crime":
                case "Roads":
                    return "High";
                case "Sanitation":
                case "Other":
                    return "Normal";
                case "Utilities":
                    return "Low";
                default:
                    return "Normal";
            }
        }

        //<----------------------------------------------------------------------------------------------------------------------------------------------->//

        /// <summary>
        /// Generates a unique report ID.
        /// </summary>
        private string GenerateReportID()
        {
            return $"RPT-{++reportCounter:0000}";
        }

        //<----------------------------------------------------------------------------------------------------------------------------------------------->//

        /// <summary>
        /// Updates the progress bar based on the input fields.
        /// </summary>
        private void UpdateProgressBar(object sender, EventArgs e)
        {
            progressValue = 0;
            if (!string.IsNullOrEmpty(txtLocation.Text))
                progressValue += 20;
            if (cmbboxCategory.SelectedItem != null)
                progressValue += 35;
            if (!string.IsNullOrEmpty(rtxtIssueDesc.Text))
                progressValue += 45;
            progressBar.Value = progressValue;

            lblMotivation.Text = GetMotivationalStatement();
        }

        //<----------------------------------------------------------------------------------------------------------------------------------------------->//

        /// <summary>
        /// Gets a motivational statement to display.
        /// </summary>
        private int motivationalIndex = 0;
        private string GetMotivationalStatement()
        {
            string statement = motivationalStatements[motivationalIndex];
            motivationalIndex = (motivationalIndex + 1) % motivationalStatements.Length;
            return statement;
        }

        //<----------------------------------------------------------------------------------------------------------------------------------------------->//

        /// <summary>
        /// Handles the view reports button click event to show the ViewReportsForm.
        /// </summary>
        private void btnViewReports_Click(object sender, EventArgs e)
        {
            ViewReportsForm viewReportsForm = new ViewReportsForm(issueDataTree);

            viewReportsForm.Show();
        }

        //<----------------------------------------------------------------------------------------------------------------------------------------------->//

        /// <summary>
        /// Validates the location format.
        /// </summary>
        private bool ValidateLocation(string location)
        {
            try
            {
                string pattern = @"^[A-Za-z\s]+,\s[A-Za-z\s]+,\s[A-Za-z\s]+,\s\d{4}$";

                Regex regex = new Regex(pattern);

                return regex.IsMatch(location);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Please provide a location", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        //<----------------------------------------------------------------------------------------------------------------------------------------------->//

        /// <summary>
        /// Handles the back arrow click event to show the Dashboard form.
        /// </summary>
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

        //<----------------------------------------------------------------------------------------------------------------------------------------------->//

        /// <summary>
        /// Handles the announcements button click event to show the LocalEventsForm.
        /// </summary>
        private void btnAnnouncements_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnAnnouncements.Height;
            pnlNav.Top = btnAnnouncements.Top;
            btnAnnouncements.BackColor = Color.FromArgb(46, 51, 73);
            LocalEventsForm localEventsForm = new LocalEventsForm();
            localEventsForm.Show();
            this.Close();
        }

        //<----------------------------------------------------------------------------------------------------------------------------------------------->//

        /// <summary>
        /// Handles the dashboard button click event to close the current form.
        /// </summary>
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //<----------------------------------------------------------------------------------------------------------------------------------------------->//

        /// <summary>
        /// Handles the exit button click event to close the current form.
        /// </summary>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Handles the service request button click event to show the ServiceRequestStatus form.
        /// </summary>
        private void btnServiceRequest_Click(object sender, EventArgs e)
        {
            ServiceRequestStatus statusForm = new ServiceRequestStatus(issueDataTree, issueDataGraph);
            statusForm.Show();
            this.Close();
        }

        private void ReportIssues_Load(object sender, EventArgs e)
        {

        }
    }
}
//------------------------------------------------------------------END OF FILE----------------------------------------------------------------------------------------->//

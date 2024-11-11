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

namespace PROG7312POE
{
    public partial class ReportIssues : Form
    {
        private SortedDictionary<string, string> issueData;
        public int progressValue;
        private string[] motivationalStatements = { "Keep up the good work!", "You're making progress!", "Optionally Add an Image" };
        private PictureBox wallpaper;

        public ReportIssues()
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
            issueData = new SortedDictionary<string, string>();

            cmbboxCategory.Items.AddRange(new string[] { "Crime", "Sanitation", "Roads", "Utilities", "Other" });
            txtLocation.TextChanged += UpdateProgressBar;
            cmbboxCategory.SelectedIndexChanged += UpdateProgressBar;
            rtxtIssueDesc.TextChanged += UpdateProgressBar;

            resize();

            progressBar.Style = ProgressBarStyle.Continuous;
            progressBar.Value = 0;
            txtOtherCategory.Visible = false;
            lblOtherCat.Visible = false;
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
        private void txtLocation_TextChanged(object sender, EventArgs e)
        {
        }

        private void cmbboxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if the selected category is "Other"
            if (cmbboxCategory.SelectedItem.ToString() == "Other")
            {
                txtOtherCategory.Visible = true;
                lblOtherCat.Visible = true;
            }
            else
            {
                txtOtherCategory.Visible = false;
                lblOtherCat.Visible = false;
                issueData["Category"] = cmbboxCategory.SelectedItem.ToString();
            }
        }

        private void txtOtherCategory_TextChanged(object sender, EventArgs e)
        {
            // Update the Category field in the data structure when the text changes
            if (cmbboxCategory.SelectedItem != null && cmbboxCategory.SelectedItem.ToString() == "Other")
            {
                issueData["Category"] = txtOtherCategory.Text;
            }
        }

        private void rtxtIssueDesc_TextChanged(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Updates the Feedback field when the text in txtFeedback changes.
        /// </summary>
        private void txtFeedback_TextChanged(object sender, EventArgs e)
        {
            issueData["userFeedback"] = txtFeedback.Text;
        }

        /// <summary>
        /// Opens a file dialog to attach media (image or document) and updates the respective fields.
        /// </summary>
        private void btnAttachMedia2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp|Document Files (*.doc; *.docx; *.pdf)|*.doc; *.docx; *.pdf";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFile = openFileDialog.FileName;
                string fileExtension = Path.GetExtension(selectedFile);

                if (IsImageFile(fileExtension))
                {
                    issueData["Media"] = selectedFile;
                    AttachedImage.Image = Image.FromFile(selectedFile);
                }
                else
                {
                    issueData["Document"] = selectedFile;
                    lblDoc.Text = Path.GetFileName(selectedFile);
                }
            }
        }

        /// <summary>
        /// Checks if the given file extension belongs to an image.
        /// </summary>
        private bool IsImageFile(string fileExtension)
        {
            string[] imageExtensions = { ".jpg", ".jpeg", ".png", ".gif", ".bmp" };
            return imageExtensions.Contains(fileExtension.ToLower());
        }

        /// <summary>
        /// Validates the input and displays a message with the submitted data or shows an error.
        /// </summary>
        private void btnSubmit2_Click(object sender, EventArgs e)
        {
            issueData["Location"] = txtLocation.Text;
            issueData["IssueDescription"] = rtxtIssueDesc.Text;

            // Ensure the category is set correctly
            if (cmbboxCategory.SelectedItem != null && cmbboxCategory.SelectedItem.ToString() == "Other")
            {
                issueData["Category"] = txtOtherCategory.Text;
            }
            else
            {
                issueData["Category"] = cmbboxCategory.SelectedItem?.ToString();
            }

            if (!ValidateLocation(issueData["Location"]))
            {
                MessageBox.Show("Invalid location format. Please enter a valid location. Ensure there is comma followed by a space inbetween each entry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                if (string.IsNullOrEmpty(txtLocation.Text) || cmbboxCategory.SelectedItem == null || string.IsNullOrEmpty(rtxtIssueDesc.Text))
                {
                    throw new Exception("Please provide input for all fields.");
                }

                string message = $"Location: {issueData["Location"]}\n" +
                                 $"Category: {issueData["Category"]}\n" +
                                 $"Issue Description: {issueData["IssueDescription"]}";

                MessageBox.Show(message, "Saved Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                progressValue = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AttachedImage_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Updates the progress bar based on the form's inputs.
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

        /// <summary>
        /// Cycles through motivational statements.
        /// </summary>
        private int motivationalIndex = 0;
        private string GetMotivationalStatement()
        {
            string statement = motivationalStatements[motivationalIndex];
            motivationalIndex = (motivationalIndex + 1) % motivationalStatements.Length;
            return statement;
        }

        /// <summary>
        /// Displays the report that was just entered
        /// </summary>
        private void btnViewReports_Click(object sender, EventArgs e)
        {
            ViewReportsForm viewReportsForm = new ViewReportsForm(issueData);

            viewReportsForm.Show();
        }

        /// <summary>
        /// Validates the location format using a regular expression.
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

        private void lblMotivation_Click(object sender, EventArgs e)
        {
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


        /// <summary>
        /// Resizes and anchors UI controls to support form resizing.
        /// </summary>
        private void resize()
        {
            txtLocation.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbboxCategory.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            rtxtIssueDesc.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            progressBar.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Right;
            lblMotivation.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Right;
            lblLocation.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            lblCategory.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            lblIssueDesc.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            lblOtherCat.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            lblDoc.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAttachMedia2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSubmit2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnViewReports.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblFeedback.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtFeedback.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AttachedImage.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        }

        private void lblFeedback_Click(object sender, EventArgs e)
        {
        }

        private void lblDoc_Click(object sender, EventArgs e)
        {

        }

        private void btnAnnouncements_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnAnnouncements.Height;
            pnlNav.Top = btnAnnouncements.Top;
            btnAnnouncements.BackColor = Color.FromArgb(46, 51, 73);
            LocalEventsForm localEventsForm = new LocalEventsForm();
            localEventsForm.Show();
            this.Close();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

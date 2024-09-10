using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG7312POE
{
    public partial class ReportIssues : Form
    {
        // Define a data structure to save the user input
        private struct IssueData
        {
            public string Location;
            public string Category;
            public string IssueDescription;
            public Image Media;
        }

        private IssueData issueData;

        public ReportIssues()
        {
            InitializeComponent();
            cmbboxCategory.Items.AddRange(new string[] { "Crime", "Sanitation", "Roads", "Utilities", "Other" });
        }

        private void txtLocation_TextChanged(object sender, EventArgs e)
        {
            // Update the Location field in the data structure
            issueData.Location = txtLocation.Text;
        }

        private void cmbboxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Update the Category field in the data structure
            issueData.Category = cmbboxCategory.SelectedItem.ToString();
        }

        private void rtxtIssueDesc_TextChanged(object sender, EventArgs e)
        {
            // Update the IssueDescription field in the data structure
            issueData.IssueDescription = rtxtIssueDesc.Text;
        }

        private void btnAttachMedia_Click(object sender, EventArgs e)
        {
            // Open a file dialog to select and attach media (image)
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Update the Media field in the data structure with the selected image
                issueData.Media = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Save the data to the data structure

            // Show a dialog box with the saved data
            string message = $"Location: {issueData.Location}\n" +
                             $"Category: {issueData.Category}\n" +
                             $"Issue Description: {issueData.IssueDescription}";

            MessageBox.Show(message, "Saved Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

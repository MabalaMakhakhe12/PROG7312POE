﻿using System;
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
    public partial class ViewReportsForm : Form
    {
        private BinarySearchTree<string, string> issueData;

        public ViewReportsForm(BinarySearchTree<string, string> issueData)
        {
            InitializeComponent();
            this.issueData = issueData;
        }

        private void ViewReportsForm_Load(object sender, EventArgs e)
        {
            if (issueData.TryGetValue("ReportID", out string ReportID))
            {
                lblReportID.Text = ReportID;
            }
            if (issueData.TryGetValue("Location", out string location))
            {
                lblLocation.Text = location;
            }

            if (issueData.TryGetValue("Category", out string category))
            {
                lblCategory.Text = category;
            }

            if (issueData.TryGetValue("IssueDescription", out string issueDescription))
            {
                lblIssueDescription.Text = issueDescription;
            }

            if (issueData.TryGetValue("Media", out string mediaPath))
            {
                pictureBoxMedia.Image = Image.FromFile(mediaPath);
            }

            if (issueData.TryGetValue("Document", out string documentPath))
            {
                //lblDoc.Text = System.IO.Path.GetFileName(documentPath);
            }
        }
    }
}

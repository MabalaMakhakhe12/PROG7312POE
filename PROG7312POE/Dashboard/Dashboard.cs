using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Threading;
using PROG7312POE.Report_Issues;

namespace PROG7312POE
{
    public partial class Dashboard : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private Thread backgroundThread;
        private PictureBox wallpaper;

        public Dashboard()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            wallpaper = new PictureBox();
            UIElements.InitializeBackground(this, wallpaper);

        }


        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnReportIssues_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnReportIssues.Height;
            pnlNav.Top = btnReportIssues.Top;
            btnReportIssues.BackColor = Color.FromArgb(46, 51, 73);

            ReportIssues reportIssuesForm = new ReportIssues();
            reportIssuesForm.Show();
            this.Hide();
        }

        private void btnAnnouncements_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnAnnouncements.Height;
            pnlNav.Top = btnAnnouncements.Top;
            btnAnnouncements.BackColor = Color.FromArgb(46, 51, 73);

            LocalEventsForm localEventsForm = new LocalEventsForm();
            localEventsForm.Show();
            this.Hide();
        }


        private void btnSettings_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnSettings.Height;
            pnlNav.Top = btnSettings.Top;
            btnSettings.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnReportIssues_Leave(object sender, EventArgs e)
        {
            btnReportIssues.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnAnnouncements_Leave(object sender, EventArgs e)
        {
            btnAnnouncements.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnServiceRequest_Leave(object sender, EventArgs e)
        {
            btnServiceRequest.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnSettings_Leave(object sender, EventArgs e)
        {
            btnSettings.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

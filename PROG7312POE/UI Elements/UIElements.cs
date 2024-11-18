using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace PROG7312POE.Report_Issues
{
    public class UIElements
    {
        //<----------------------------------------------------------------------------------------------------------------------------------------------->//

        /// <summary>
        /// Initializes the background of the form with a PictureBox and starts a background thread to load the background image.
        /// </summary>
        public static void InitializeBackground(Form form, PictureBox wallpaper)
        {
            wallpaper.Dock = DockStyle.Fill;
            wallpaper.SizeMode = PictureBoxSizeMode.StretchImage;
            form.Controls.Add(wallpaper);

            Thread backgroundThread = new Thread(() => BackgroundLoader.LoadBackground(form, wallpaper));
            backgroundThread.IsBackground = true;
            backgroundThread.Start();
        }

        //<----------------------------------------------------------------------------------------------------------------------------------------------->//

        /// <summary>
        /// Resizes and anchors the controls on the form to ensure they adjust properly when the form is resized.
        /// </summary>
        public static void ResizeControls(Control txtLocation, Control cmbboxCategory, Control rtxtIssueDesc, Control progressBar, Control lblMotivation, Control lblLocation, Control lblCategory, Control lblIssueDesc, Control lblOtherCat, Control lblDoc, Control btnAttachMedia, Control btnSubmit2, Control btnViewReports, Control lblFeedback, Control txtFeedback, Control AttachedImage)
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
            btnAttachMedia.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSubmit2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnViewReports.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblFeedback.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtFeedback.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AttachedImage.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        }

        //<----------------------------------------------------------------------------------------------------------------------------------------------->//

        /// <summary>
        /// Resizes and anchors the event-related controls on the form to ensure they adjust properly when the form is resized.
        /// </summary>
        public static void ResizeEvents(Control lblEvents, Control lblCategories, Control lstEvents, Control lstCategories, Control txtSearch, Control lblRecommendations, Control btn_Search, Control lstRecommended)
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
        /// <summary>
        /// Resizes and anchors the controls on the ServiceRequestStatus form to ensure they adjust properly when the form is resized.
        /// </summary>
        public static void ResizeServiceRequestStatusControls(Control listViewRequests, Control lblSearchFor ,Control txtSearchValue, Control btnRefresh, Control btnDFS, Control btnBFS, Control btnSortByPriority, Control btnDashboard, Control btnReportIssues, Control btnAnnouncements, Control backArrow)
        {
            listViewRequests.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right ;
            lblSearchFor.Anchor = AnchorStyles.Bottom | AnchorStyles.Left; 
            txtSearchValue.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnRefresh.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnDFS.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnBFS.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSortByPriority.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            backArrow.Anchor = AnchorStyles.Top | AnchorStyles.Left;
        }
    }
}
//------------------------------------------------------------------END OF FILE----------------------------------------------------------------------------------------->//

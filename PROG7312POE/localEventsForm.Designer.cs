namespace PROG7312POE
{
    partial class LocalEventsForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocalEventsForm));
            this.lblEvents = new System.Windows.Forms.Label();
            this.lstEvents = new System.Windows.Forms.ListBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblRecommendations = new System.Windows.Forms.Label();
            this.lstCategories = new System.Windows.Forms.ListBox();
            this.lblCategories = new System.Windows.Forms.Label();
            this.backArrow = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnServiceRequest = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnAnnouncements = new System.Windows.Forms.Button();
            this.btnReportIssues = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Search = new MaterialSkin.Controls.MaterialButton();
            this.lstRecommended = new System.Windows.Forms.ListBox();
            this.progressSearch = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.backArrow)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEvents
            // 
            this.lblEvents.AutoSize = true;
            this.lblEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(9)))), ((int)(((byte)(30)))));
            this.lblEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(103)))), ((int)(((byte)(238)))));
            this.lblEvents.Location = new System.Drawing.Point(261, 60);
            this.lblEvents.Name = "lblEvents";
            this.lblEvents.Size = new System.Drawing.Size(180, 25);
            this.lblEvents.TabIndex = 0;
            this.lblEvents.Text = "Upcoming Events";
            // 
            // lstEvents
            // 
            this.lstEvents.FormattingEnabled = true;
            this.lstEvents.ItemHeight = 16;
            this.lstEvents.Location = new System.Drawing.Point(261, 100);
            this.lstEvents.Name = "lstEvents";
            this.lstEvents.Size = new System.Drawing.Size(300, 180);
            this.lstEvents.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Location = new System.Drawing.Point(261, 290);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(300, 22);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.Text = "Search category or date (YYYY-MM-DD)";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.TxtSearch_Enter);
            // 
            // lblRecommendations
            // 
            this.lblRecommendations.AutoSize = true;
            this.lblRecommendations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(9)))), ((int)(((byte)(30)))));
            this.lblRecommendations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecommendations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(103)))), ((int)(((byte)(238)))));
            this.lblRecommendations.Location = new System.Drawing.Point(586, 286);
            this.lblRecommendations.Name = "lblRecommendations";
            this.lblRecommendations.Size = new System.Drawing.Size(227, 25);
            this.lblRecommendations.TabIndex = 4;
            this.lblRecommendations.Text = "Recommended Events";
            // 
            // lstCategories
            // 
            this.lstCategories.FormattingEnabled = true;
            this.lstCategories.ItemHeight = 16;
            this.lstCategories.Location = new System.Drawing.Point(591, 100);
            this.lstCategories.Name = "lstCategories";
            this.lstCategories.Size = new System.Drawing.Size(237, 180);
            this.lstCategories.TabIndex = 5;
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(9)))), ((int)(((byte)(30)))));
            this.lblCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategories.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(103)))), ((int)(((byte)(238)))));
            this.lblCategories.Location = new System.Drawing.Point(591, 60);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(117, 25);
            this.lblCategories.TabIndex = 6;
            this.lblCategories.Text = "Categories";
            // 
            // backArrow
            // 
            this.backArrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.backArrow.Image = global::PROG7312POE.Properties.Resources.back;
            this.backArrow.Location = new System.Drawing.Point(199, 22);
            this.backArrow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backArrow.Name = "backArrow";
            this.backArrow.Size = new System.Drawing.Size(35, 26);
            this.backArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backArrow.TabIndex = 21;
            this.backArrow.TabStop = false;
            this.backArrow.Click += new System.EventHandler(this.backArrow_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.pnlNav);
            this.panel1.Controls.Add(this.btnServiceRequest);
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Controls.Add(this.btnAnnouncements);
            this.panel1.Controls.Add(this.btnReportIssues);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 621);
            this.panel1.TabIndex = 20;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnlNav.Location = new System.Drawing.Point(3, 202);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(3, 100);
            this.pnlNav.TabIndex = 6;
            // 
            // btnServiceRequest
            // 
            this.btnServiceRequest.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnServiceRequest.FlatAppearance.BorderSize = 0;
            this.btnServiceRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServiceRequest.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServiceRequest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnServiceRequest.Image = ((System.Drawing.Image)(resources.GetObject("btnServiceRequest.Image")));
            this.btnServiceRequest.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnServiceRequest.Location = new System.Drawing.Point(0, 288);
            this.btnServiceRequest.Name = "btnServiceRequest";
            this.btnServiceRequest.Size = new System.Drawing.Size(193, 46);
            this.btnServiceRequest.TabIndex = 5;
            this.btnServiceRequest.Text = "Service Request";
            this.btnServiceRequest.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnServiceRequest.UseVisualStyleBackColor = true;
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSettings.Location = new System.Drawing.Point(0, 575);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(193, 46);
            this.btnSettings.TabIndex = 4;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // btnAnnouncements
            // 
            this.btnAnnouncements.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAnnouncements.FlatAppearance.BorderSize = 0;
            this.btnAnnouncements.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnouncements.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnouncements.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnAnnouncements.Image = ((System.Drawing.Image)(resources.GetObject("btnAnnouncements.Image")));
            this.btnAnnouncements.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAnnouncements.Location = new System.Drawing.Point(0, 242);
            this.btnAnnouncements.Name = "btnAnnouncements";
            this.btnAnnouncements.Size = new System.Drawing.Size(193, 46);
            this.btnAnnouncements.TabIndex = 3;
            this.btnAnnouncements.Text = "Announcements";
            this.btnAnnouncements.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAnnouncements.UseVisualStyleBackColor = true;
            // 
            // btnReportIssues
            // 
            this.btnReportIssues.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportIssues.FlatAppearance.BorderSize = 0;
            this.btnReportIssues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportIssues.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportIssues.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnReportIssues.Image = ((System.Drawing.Image)(resources.GetObject("btnReportIssues.Image")));
            this.btnReportIssues.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReportIssues.Location = new System.Drawing.Point(0, 196);
            this.btnReportIssues.Name = "btnReportIssues";
            this.btnReportIssues.Size = new System.Drawing.Size(193, 46);
            this.btnReportIssues.TabIndex = 2;
            this.btnReportIssues.Text = "Report Issues";
            this.btnReportIssues.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnReportIssues.UseVisualStyleBackColor = true;
            this.btnReportIssues.Click += new System.EventHandler(this.btnReportIssues_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDashboard.Location = new System.Drawing.Point(0, 150);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(193, 46);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.Username);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(193, 150);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label3.Location = new System.Drawing.Point(23, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Some User Text Here";
            this.label3.UseMnemonic = false;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Username.Location = new System.Drawing.Point(57, 98);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(94, 20);
            this.Username.TabIndex = 2;
            this.Username.Text = "User Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(60, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Search
            // 
            this.btn_Search.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Search.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Search.Depth = 0;
            this.btn_Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(103)))), ((int)(((byte)(238)))));
            this.btn_Search.HighEmphasis = true;
            this.btn_Search.Icon = null;
            this.btn_Search.Location = new System.Drawing.Point(261, 335);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Search.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Search.Size = new System.Drawing.Size(78, 36);
            this.btn_Search.TabIndex = 22;
            this.btn_Search.Text = "Search";
            this.btn_Search.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Search.UseAccentColor = false;
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // lstRecommended
            // 
            this.lstRecommended.FormattingEnabled = true;
            this.lstRecommended.ItemHeight = 16;
            this.lstRecommended.Location = new System.Drawing.Point(591, 324);
            this.lstRecommended.Name = "lstRecommended";
            this.lstRecommended.Size = new System.Drawing.Size(245, 244);
            this.lstRecommended.TabIndex = 23;
            // 
            // progressSearch
            // 
            this.progressSearch.Location = new System.Drawing.Point(266, 24);
            this.progressSearch.Name = "progressSearch";
            this.progressSearch.Size = new System.Drawing.Size(547, 23);
            this.progressSearch.TabIndex = 24;
            this.progressSearch.Click += new System.EventHandler(this.progressSearch_Click);
            // 
            // LocalEventsForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(907, 621);
            this.Controls.Add(this.progressSearch);
            this.Controls.Add(this.lstRecommended);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.backArrow);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblCategories);
            this.Controls.Add(this.lstCategories);
            this.Controls.Add(this.lblRecommendations);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lstEvents);
            this.Controls.Add(this.lblEvents);
            this.Name = "LocalEventsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Local Events and Announcements";
            ((System.ComponentModel.ISupportInitialize)(this.backArrow)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEvents;
        private System.Windows.Forms.ListBox lstEvents;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblRecommendations;
        private System.Windows.Forms.ListBox lstCategories;
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.PictureBox backArrow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button btnServiceRequest;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnAnnouncements;
        private System.Windows.Forms.Button btnReportIssues;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialButton btn_Search;
        private System.Windows.Forms.ListBox lstRecommended;
        private System.Windows.Forms.ProgressBar progressSearch;
    }
}

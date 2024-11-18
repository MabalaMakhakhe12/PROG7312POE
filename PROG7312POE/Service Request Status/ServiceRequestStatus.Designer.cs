namespace PROG7312POE
{
    partial class ServiceRequestStatus
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListView listViewRequests;
        private System.Windows.Forms.ColumnHeader columnHeaderID;
        private System.Windows.Forms.ColumnHeader columnHeaderLocation;
        private System.Windows.Forms.ColumnHeader columnHeaderCategory;
        private System.Windows.Forms.ColumnHeader columnHeaderDescription;
        private System.Windows.Forms.ColumnHeader columnHeaderStatus;
        private System.Windows.Forms.ColumnHeader columnHeaderPriority; 


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceRequestStatus));
            this.listViewRequests = new System.Windows.Forms.ListView();
            this.columnHeaderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLocation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPriority = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtSearchValue = new System.Windows.Forms.TextBox();
            this.lblReportID = new System.Windows.Forms.Label();
            this.btnRefresh = new MaterialSkin.Controls.MaterialButton();
            this.btnSortByPriority = new MaterialSkin.Controls.MaterialButton();
            this.btnDFS = new MaterialSkin.Controls.MaterialButton();
            this.btnBFS = new MaterialSkin.Controls.MaterialButton();
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
            ((System.ComponentModel.ISupportInitialize)(this.backArrow)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewRequests
            // 
            this.listViewRequests.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderID,
            this.columnHeaderLocation,
            this.columnHeaderCategory,
            this.columnHeaderDescription,
            this.columnHeaderStatus,
            this.columnHeaderPriority});
            this.listViewRequests.FullRowSelect = true;
            this.listViewRequests.GridLines = true;
            this.listViewRequests.HideSelection = false;
            this.listViewRequests.Location = new System.Drawing.Point(235, 25);
            this.listViewRequests.Name = "listViewRequests";
            this.listViewRequests.Size = new System.Drawing.Size(660, 294);
            this.listViewRequests.TabIndex = 0;
            this.listViewRequests.UseCompatibleStateImageBehavior = false;
            this.listViewRequests.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderID
            // 
            this.columnHeaderID.Text = "Request ID";
            this.columnHeaderID.Width = 100;
            // 
            // columnHeaderLocation
            // 
            this.columnHeaderLocation.Text = "Location";
            this.columnHeaderLocation.Width = 120;
            // 
            // columnHeaderCategory
            // 
            this.columnHeaderCategory.Text = "Category";
            this.columnHeaderCategory.Width = 120;
            // 
            // columnHeaderDescription
            // 
            this.columnHeaderDescription.Text = "Description";
            this.columnHeaderDescription.Width = 120;
            // 
            // columnHeaderStatus
            // 
            this.columnHeaderStatus.Text = "Status";
            this.columnHeaderStatus.Width = 100;
            // 
            // columnHeaderPriority
            // 
            this.columnHeaderPriority.Text = "Priority";
            this.columnHeaderPriority.Width = 100;
            // 
            // txtSearchValue
            // 
            this.txtSearchValue.Location = new System.Drawing.Point(372, 381);
            this.txtSearchValue.Name = "txtSearchValue";
            this.txtSearchValue.Size = new System.Drawing.Size(170, 22);
            this.txtSearchValue.TabIndex = 4;
            // 
            // lblReportID
            // 
            this.lblReportID.AutoSize = true;
            this.lblReportID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(9)))), ((int)(((byte)(30)))));
            this.lblReportID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(103)))), ((int)(((byte)(238)))));
            this.lblReportID.Location = new System.Drawing.Point(254, 381);
            this.lblReportID.Name = "lblReportID";
            this.lblReportID.Size = new System.Drawing.Size(91, 20);
            this.lblReportID.TabIndex = 10;
            this.lblReportID.Text = "Report ID :";
            // 
            // btnRefresh
            // 
            this.btnRefresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRefresh.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRefresh.Depth = 0;
            this.btnRefresh.HighEmphasis = true;
            this.btnRefresh.Icon = null;
            this.btnRefresh.Location = new System.Drawing.Point(261, 328);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRefresh.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRefresh.Size = new System.Drawing.Size(84, 36);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRefresh.UseAccentColor = false;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSortByPriority
            // 
            this.btnSortByPriority.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSortByPriority.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSortByPriority.Depth = 0;
            this.btnSortByPriority.HighEmphasis = true;
            this.btnSortByPriority.Icon = null;
            this.btnSortByPriority.Location = new System.Drawing.Point(372, 328);
            this.btnSortByPriority.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSortByPriority.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSortByPriority.Name = "btnSortByPriority";
            this.btnSortByPriority.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSortByPriority.Size = new System.Drawing.Size(148, 36);
            this.btnSortByPriority.TabIndex = 13;
            this.btnSortByPriority.Text = "Sort by Priority";
            this.btnSortByPriority.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSortByPriority.UseAccentColor = false;
            this.btnSortByPriority.UseVisualStyleBackColor = true;
            this.btnSortByPriority.Click += new System.EventHandler(this.btnSortByPriority_Click);
            // 
            // btnDFS
            // 
            this.btnDFS.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDFS.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDFS.Depth = 0;
            this.btnDFS.HighEmphasis = true;
            this.btnDFS.Icon = null;
            this.btnDFS.Location = new System.Drawing.Point(235, 434);
            this.btnDFS.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDFS.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDFS.Name = "btnDFS";
            this.btnDFS.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDFS.Size = new System.Drawing.Size(226, 36);
            this.btnDFS.TabIndex = 14;
            this.btnDFS.Text = "Find All Related Requests";
            this.btnDFS.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDFS.UseAccentColor = false;
            this.btnDFS.UseVisualStyleBackColor = true;
            this.btnDFS.Click += new System.EventHandler(this.btnDFS_Click);
            // 
            // btnBFS
            // 
            this.btnBFS.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBFS.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBFS.Depth = 0;
            this.btnBFS.HighEmphasis = true;
            this.btnBFS.Icon = null;
            this.btnBFS.Location = new System.Drawing.Point(469, 434);
            this.btnBFS.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBFS.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBFS.Name = "btnBFS";
            this.btnBFS.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBFS.Size = new System.Drawing.Size(263, 36);
            this.btnBFS.TabIndex = 15;
            this.btnBFS.Text = "Find Closest Related Requests";
            this.btnBFS.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBFS.UseAccentColor = false;
            this.btnBFS.UseVisualStyleBackColor = true;
            this.btnBFS.Click += new System.EventHandler(this.btnBFS_Click);
            // 
            // backArrow
            // 
            this.backArrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(98)))), ((int)(((byte)(243)))));
            this.backArrow.Image = global::PROG7312POE.Properties.Resources.back;
            this.backArrow.Location = new System.Drawing.Point(194, 2);
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
            this.panel1.Size = new System.Drawing.Size(193, 586);
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
            this.btnSettings.Location = new System.Drawing.Point(0, 540);
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
            this.btnAnnouncements.Click += new System.EventHandler(this.btnAnnouncements_Click);
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
            // ServiceRequestStatus
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1103, 586);
            this.Controls.Add(this.backArrow);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBFS);
            this.Controls.Add(this.btnDFS);
            this.Controls.Add(this.btnSortByPriority);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblReportID);
            this.Controls.Add(this.txtSearchValue);
            this.Controls.Add(this.listViewRequests);
            this.Name = "ServiceRequestStatus";
            this.Text = "Service Request Status";
            this.Load += new System.EventHandler(this.ServiceRequestStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.backArrow)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.TextBox txtSearchValue;
        private System.Windows.Forms.Label lblReportID;
        private MaterialSkin.Controls.MaterialButton btnRefresh;
        private MaterialSkin.Controls.MaterialButton btnSortByPriority;
        private MaterialSkin.Controls.MaterialButton btnDFS;
        private MaterialSkin.Controls.MaterialButton btnBFS;
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
    }
}

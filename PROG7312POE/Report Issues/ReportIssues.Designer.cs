namespace PROG7312POE
{
    partial class ReportIssues
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportIssues));
            this.label1 = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbboxCategory = new System.Windows.Forms.ComboBox();
            this.lblIssueDesc = new System.Windows.Forms.Label();
            this.rtxtIssueDesc = new System.Windows.Forms.RichTextBox();
            this.btnAttachMedia = new MaterialSkin.Controls.MaterialButton();
            this.btnSubmit2 = new MaterialSkin.Controls.MaterialButton();
            this.progressBar = new MaterialSkin.Controls.MaterialProgressBar();
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
            this.btnViewReports = new MaterialSkin.Controls.MaterialButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMotivation = new System.Windows.Forms.Label();
            this.txtOtherCategory = new System.Windows.Forms.TextBox();
            this.lblOtherCat = new System.Windows.Forms.Label();
            this.backArrow = new System.Windows.Forms.PictureBox();
            this.AttachedImage = new System.Windows.Forms.PictureBox();
            this.lblDoc = new System.Windows.Forms.Label();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.txtFeedback = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttachedImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(9)))), ((int)(((byte)(30)))));
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(103)))), ((int)(((byte)(238)))));
            this.label1.Location = new System.Drawing.Point(220, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Report Issues";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(9)))), ((int)(((byte)(30)))));
            this.lblLocation.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(103)))), ((int)(((byte)(238)))));
            this.lblLocation.Location = new System.Drawing.Point(224, 77);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(93, 28);
            this.lblLocation.TabIndex = 1;
            this.lblLocation.Text = "Location";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(229, 120);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(301, 22);
            this.txtLocation.TabIndex = 2;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(9)))), ((int)(((byte)(30)))));
            this.lblCategory.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(103)))), ((int)(((byte)(238)))));
            this.lblCategory.Location = new System.Drawing.Point(224, 167);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(98, 28);
            this.lblCategory.TabIndex = 3;
            this.lblCategory.Text = "Category";
            // 
            // cmbboxCategory
            // 
            this.cmbboxCategory.FormattingEnabled = true;
            this.cmbboxCategory.Location = new System.Drawing.Point(229, 199);
            this.cmbboxCategory.Name = "cmbboxCategory";
            this.cmbboxCategory.Size = new System.Drawing.Size(301, 24);
            this.cmbboxCategory.TabIndex = 4;
            this.cmbboxCategory.SelectedIndexChanged += new System.EventHandler(this.cmbboxCategory_SelectedIndexChanged);
            // 
            // lblIssueDesc
            // 
            this.lblIssueDesc.AutoSize = true;
            this.lblIssueDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(9)))), ((int)(((byte)(30)))));
            this.lblIssueDesc.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(103)))), ((int)(((byte)(238)))));
            this.lblIssueDesc.Location = new System.Drawing.Point(228, 314);
            this.lblIssueDesc.Name = "lblIssueDesc";
            this.lblIssueDesc.Size = new System.Drawing.Size(174, 28);
            this.lblIssueDesc.TabIndex = 5;
            this.lblIssueDesc.Text = "Issue Description";
            // 
            // rtxtIssueDesc
            // 
            this.rtxtIssueDesc.Location = new System.Drawing.Point(233, 366);
            this.rtxtIssueDesc.Name = "rtxtIssueDesc";
            this.rtxtIssueDesc.Size = new System.Drawing.Size(312, 96);
            this.rtxtIssueDesc.TabIndex = 6;
            this.rtxtIssueDesc.Text = "";
            // 
            // btnAttachMedia
            // 
            this.btnAttachMedia.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAttachMedia.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAttachMedia.Depth = 0;
            this.btnAttachMedia.HighEmphasis = true;
            this.btnAttachMedia.Icon = null;
            this.btnAttachMedia.Location = new System.Drawing.Point(233, 484);
            this.btnAttachMedia.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAttachMedia.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAttachMedia.Name = "btnAttachMedia";
            this.btnAttachMedia.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAttachMedia.Size = new System.Drawing.Size(127, 36);
            this.btnAttachMedia.TabIndex = 9;
            this.btnAttachMedia.Text = "Attach Media";
            this.btnAttachMedia.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAttachMedia.UseAccentColor = false;
            this.btnAttachMedia.UseVisualStyleBackColor = true;
            this.btnAttachMedia.Click += new System.EventHandler(this.btnAttachMedia_Click);
            // 
            // btnSubmit2
            // 
            this.btnSubmit2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSubmit2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSubmit2.Depth = 0;
            this.btnSubmit2.HighEmphasis = true;
            this.btnSubmit2.Icon = null;
            this.btnSubmit2.Location = new System.Drawing.Point(233, 531);
            this.btnSubmit2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSubmit2.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSubmit2.Name = "btnSubmit2";
            this.btnSubmit2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSubmit2.Size = new System.Drawing.Size(75, 36);
            this.btnSubmit2.TabIndex = 10;
            this.btnSubmit2.Text = "Submit";
            this.btnSubmit2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSubmit2.UseAccentColor = false;
            this.btnSubmit2.UseVisualStyleBackColor = true;
            this.btnSubmit2.Click += new System.EventHandler(this.btnSubmit2_Click);
            // 
            // progressBar
            // 
            this.progressBar.Depth = 0;
            this.progressBar.ForeColor = System.Drawing.Color.Red;
            this.progressBar.Location = new System.Drawing.Point(534, 81);
            this.progressBar.MinimumSize = new System.Drawing.Size(551, 8);
            this.progressBar.MouseState = MaterialSkin.MouseState.HOVER;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(551, 5);
            this.progressBar.TabIndex = 12;
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
            this.panel1.TabIndex = 13;
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
            this.btnServiceRequest.Click += new System.EventHandler(this.btnServiceRequest_Click);
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
            // btnViewReports
            // 
            this.btnViewReports.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnViewReports.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnViewReports.Depth = 0;
            this.btnViewReports.HighEmphasis = true;
            this.btnViewReports.Icon = null;
            this.btnViewReports.Location = new System.Drawing.Point(356, 531);
            this.btnViewReports.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnViewReports.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnViewReports.Name = "btnViewReports";
            this.btnViewReports.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnViewReports.Size = new System.Drawing.Size(124, 36);
            this.btnViewReports.TabIndex = 14;
            this.btnViewReports.Text = "View Reports";
            this.btnViewReports.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnViewReports.UseAccentColor = false;
            this.btnViewReports.UseVisualStyleBackColor = true;
            this.btnViewReports.Click += new System.EventHandler(this.btnViewReports_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(9)))), ((int)(((byte)(30)))));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(229, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Streets name, Neighbourhood, City, Area Code";
            // 
            // lblMotivation
            // 
            this.lblMotivation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMotivation.AutoSize = true;
            this.lblMotivation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(9)))), ((int)(((byte)(30)))));
            this.lblMotivation.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotivation.ForeColor = System.Drawing.Color.Red;
            this.lblMotivation.Location = new System.Drawing.Point(680, 39);
            this.lblMotivation.Name = "lblMotivation";
            this.lblMotivation.Size = new System.Drawing.Size(325, 31);
            this.lblMotivation.TabIndex = 16;
            this.lblMotivation.Text = "Go ahead and report an issue";
            // 
            // txtOtherCategory
            // 
            this.txtOtherCategory.Location = new System.Drawing.Point(229, 254);
            this.txtOtherCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOtherCategory.Name = "txtOtherCategory";
            this.txtOtherCategory.Size = new System.Drawing.Size(301, 22);
            this.txtOtherCategory.TabIndex = 17;
            // 
            // lblOtherCat
            // 
            this.lblOtherCat.AutoSize = true;
            this.lblOtherCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(9)))), ((int)(((byte)(30)))));
            this.lblOtherCat.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOtherCat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(103)))), ((int)(((byte)(238)))));
            this.lblOtherCat.Location = new System.Drawing.Point(228, 230);
            this.lblOtherCat.Name = "lblOtherCat";
            this.lblOtherCat.Size = new System.Drawing.Size(158, 28);
            this.lblOtherCat.TabIndex = 18;
            this.lblOtherCat.Text = "Other Category";
            // 
            // backArrow
            // 
            this.backArrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(98)))), ((int)(((byte)(243)))));
            this.backArrow.Image = global::PROG7312POE.Properties.Resources.back;
            this.backArrow.Location = new System.Drawing.Point(198, 10);
            this.backArrow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backArrow.Name = "backArrow";
            this.backArrow.Size = new System.Drawing.Size(35, 26);
            this.backArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backArrow.TabIndex = 19;
            this.backArrow.TabStop = false;
            this.backArrow.Click += new System.EventHandler(this.backArrow_Click);
            // 
            // AttachedImage
            // 
            this.AttachedImage.Location = new System.Drawing.Point(624, 120);
            this.AttachedImage.Name = "AttachedImage";
            this.AttachedImage.Size = new System.Drawing.Size(399, 312);
            this.AttachedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AttachedImage.TabIndex = 11;
            this.AttachedImage.TabStop = false;
            // 
            // lblDoc
            // 
            this.lblDoc.AutoSize = true;
            this.lblDoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(9)))), ((int)(((byte)(30)))));
            this.lblDoc.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(103)))), ((int)(((byte)(238)))));
            this.lblDoc.Location = new System.Drawing.Point(619, 469);
            this.lblDoc.Name = "lblDoc";
            this.lblDoc.Size = new System.Drawing.Size(264, 28);
            this.lblDoc.TabIndex = 20;
            this.lblDoc.Text = "Attached Document Name";
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(9)))), ((int)(((byte)(30)))));
            this.lblFeedback.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedback.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(103)))), ((int)(((byte)(238)))));
            this.lblFeedback.Location = new System.Drawing.Point(619, 512);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(432, 28);
            this.lblFeedback.TabIndex = 21;
            this.lblFeedback.Text = "Optionally add feedback on your experience";
            // 
            // txtFeedback
            // 
            this.txtFeedback.Location = new System.Drawing.Point(624, 545);
            this.txtFeedback.Name = "txtFeedback";
            this.txtFeedback.Size = new System.Drawing.Size(301, 22);
            this.txtFeedback.TabIndex = 22;
            // 
            // ReportIssues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1103, 586);
            this.Controls.Add(this.txtFeedback);
            this.Controls.Add(this.lblFeedback);
            this.Controls.Add(this.lblDoc);
            this.Controls.Add(this.backArrow);
            this.Controls.Add(this.lblOtherCat);
            this.Controls.Add(this.txtOtherCategory);
            this.Controls.Add(this.lblMotivation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnViewReports);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.AttachedImage);
            this.Controls.Add(this.btnSubmit2);
            this.Controls.Add(this.btnAttachMedia);
            this.Controls.Add(this.rtxtIssueDesc);
            this.Controls.Add(this.lblIssueDesc);
            this.Controls.Add(this.cmbboxCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ReportIssues";
            this.Text = "ReportIssues";
            this.Load += new System.EventHandler(this.ReportIssues_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttachedImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbboxCategory;
        private System.Windows.Forms.Label lblIssueDesc;
        private System.Windows.Forms.RichTextBox rtxtIssueDesc;
        private MaterialSkin.Controls.MaterialButton btnAttachMedia;
        private MaterialSkin.Controls.MaterialButton btnSubmit2;
        private System.Windows.Forms.PictureBox AttachedImage;
        private MaterialSkin.Controls.MaterialProgressBar progressBar;
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
        private MaterialSkin.Controls.MaterialButton btnViewReports;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMotivation;
        private System.Windows.Forms.TextBox txtOtherCategory;
        private System.Windows.Forms.Label lblOtherCat;
        private System.Windows.Forms.PictureBox backArrow;
        private System.Windows.Forms.Label lblDoc;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.TextBox txtFeedback;
    }
}
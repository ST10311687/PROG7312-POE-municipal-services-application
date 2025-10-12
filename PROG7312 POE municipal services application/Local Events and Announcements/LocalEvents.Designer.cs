namespace PROG7312_POE_municipal_services_application.Local_Events_and_Announcements
{
    partial class LocalEvents
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocalEvents));
            this.addEventPanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.eventsUserControl = new Local_Events_and_Announcements.EventUserControl();
            this.informationPanel = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.recommendationBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.searchHistoryBtn = new System.Windows.Forms.Button();
            this.searchTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.resetBtn = new System.Windows.Forms.Button();
            this.dateFilter = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.categorySearchComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.filePathTxt = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.addEventPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.informationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // addEventPanel
            // 
            this.addEventPanel.Controls.Add(this.flowLayoutPanel1);
            this.addEventPanel.Controls.Add(this.informationPanel);
            this.addEventPanel.Controls.Add(this.filePathTxt);
            this.addEventPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addEventPanel.Location = new System.Drawing.Point(0, 0);
            this.addEventPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addEventPanel.Name = "addEventPanel";
            this.addEventPanel.Size = new System.Drawing.Size(991, 609);
            this.addEventPanel.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(180)))), ((int)(((byte)(125)))));
            this.flowLayoutPanel1.Controls.Add(this.eventsUserControl);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 232);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(991, 377);
            this.flowLayoutPanel1.TabIndex = 40;
            
            // 
            // eventsUserControl
            // 
            this.eventsUserControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eventsUserControl.BackColor = System.Drawing.Color.White;
            this.eventsUserControl.EventCategory = null;
            this.eventsUserControl.EventDescription = null;
            this.eventsUserControl.EventImage = null;
            this.eventsUserControl.EventLocation = null;
            this.eventsUserControl.EventName = null;
            this.eventsUserControl.EventTime = new System.DateTime(((long)(0)));
            this.eventsUserControl.Location = new System.Drawing.Point(2, 2);
            this.eventsUserControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.eventsUserControl.Name = "eventsUserControl";
            this.eventsUserControl.Size = new System.Drawing.Size(988, 287);
            this.eventsUserControl.TabIndex = 0;
            this.toolTip1.SetToolTip(this.eventsUserControl, "Recent events and announcements");
            this.eventsUserControl.Load += new System.EventHandler(this.eventsUserControl_Load);
            // 
            // informationPanel
            // 
            this.informationPanel.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.informationPanel.Controls.Add(this.pictureBox3);
            this.informationPanel.Controls.Add(this.pictureBox2);
            this.informationPanel.Controls.Add(this.recommendationBtn);
            this.informationPanel.Controls.Add(this.pictureBox1);
            this.informationPanel.Controls.Add(this.searchBtn);
            this.informationPanel.Controls.Add(this.panel2);
            this.informationPanel.Controls.Add(this.label2);
            this.informationPanel.Controls.Add(this.button1);
            this.informationPanel.Controls.Add(this.label8);
            this.informationPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.informationPanel.Location = new System.Drawing.Point(0, 0);
            this.informationPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.informationPanel.Name = "informationPanel";
            this.informationPanel.Size = new System.Drawing.Size(991, 237);
            this.informationPanel.TabIndex = 39;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(423, 193);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(22, 23);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 59;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.ForestGreen;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(140, 194);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 58;
            this.pictureBox2.TabStop = false;
            // 
            // recommendationBtn
            // 
            this.recommendationBtn.AutoSize = true;
            this.recommendationBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.recommendationBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recommendationBtn.ForeColor = System.Drawing.Color.White;
            this.recommendationBtn.Location = new System.Drawing.Point(233, 181);
            this.recommendationBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.recommendationBtn.Name = "recommendationBtn";
            this.recommendationBtn.Size = new System.Drawing.Size(221, 46);
            this.recommendationBtn.TabIndex = 57;
            this.recommendationBtn.Text = "Recommended event";
            this.recommendationBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.recommendationBtn, "Get your recommendation based on what you search");
            this.recommendationBtn.UseVisualStyleBackColor = false;
            this.recommendationBtn.Click += new System.EventHandler(this.recommendationBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(110)))), ((int)(((byte)(51)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(590, 184);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // searchBtn
            // 
            this.searchBtn.AutoSize = true;
            this.searchBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.searchBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.Location = new System.Drawing.Point(46, 181);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(124, 46);
            this.searchBtn.TabIndex = 37;
            this.searchBtn.Text = "Search";
            this.searchBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.searchBtn, "Search based on selected filtering");
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Bisque;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.searchHistoryBtn);
            this.panel2.Controls.Add(this.searchTxtBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.resetBtn);
            this.panel2.Controls.Add(this.dateFilter);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.categorySearchComboBox);
            this.panel2.Location = new System.Drawing.Point(2, 83);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(987, 80);
            this.panel2.TabIndex = 55;
            // 
            // searchHistoryBtn
            // 
            this.searchHistoryBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.searchHistoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchHistoryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchHistoryBtn.ForeColor = System.Drawing.Color.White;
            this.searchHistoryBtn.Location = new System.Drawing.Point(587, 48);
            this.searchHistoryBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchHistoryBtn.Name = "searchHistoryBtn";
            this.searchHistoryBtn.Size = new System.Drawing.Size(178, 25);
            this.searchHistoryBtn.TabIndex = 57;
            this.searchHistoryBtn.Text = "Search history";
            this.toolTip1.SetToolTip(this.searchHistoryBtn, "View search history");
            this.searchHistoryBtn.UseVisualStyleBackColor = false;
            this.searchHistoryBtn.Click += new System.EventHandler(this.searchHistoryBtn_Click);
            // 
            // searchTxtBox
            // 
            this.searchTxtBox.Location = new System.Drawing.Point(718, 19);
            this.searchTxtBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchTxtBox.Name = "searchTxtBox";
            this.searchTxtBox.Size = new System.Drawing.Size(192, 20);
            this.searchTxtBox.TabIndex = 56;
            this.toolTip1.SetToolTip(this.searchTxtBox, "Enter keyword for your search ");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(566, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Search by keyword : ";
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.ForeColor = System.Drawing.Color.White;
            this.resetBtn.Location = new System.Drawing.Point(800, 47);
            this.resetBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(178, 25);
            this.resetBtn.TabIndex = 55;
            this.resetBtn.Text = "Reset";
            this.toolTip1.SetToolTip(this.resetBtn, "Clear the filter");
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // dateFilter
            // 
            this.dateFilter.Location = new System.Drawing.Point(302, 17);
            this.dateFilter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateFilter.Name = "dateFilter";
            this.dateFilter.Size = new System.Drawing.Size(260, 20);
            this.dateFilter.TabIndex = 54;
            this.toolTip1.SetToolTip(this.dateFilter, "Select date and time");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(0, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Order by : ";
            // 
            // categorySearchComboBox
            // 
            this.categorySearchComboBox.FormattingEnabled = true;
            this.categorySearchComboBox.Items.AddRange(new object[] {
            "Community meetings",
            "Festival",
            "Workshop",
            "Health and wellness",
            "Arts and culture",
            "Volunteer opportunities",
            "Holiday celebration",
            "Government Service",
            "Alerts"});
            this.categorySearchComboBox.Location = new System.Drawing.Point(92, 15);
            this.categorySearchComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.categorySearchComboBox.Name = "categorySearchComboBox";
            this.categorySearchComboBox.Size = new System.Drawing.Size(201, 21);
            this.categorySearchComboBox.TabIndex = 4;
            this.toolTip1.SetToolTip(this.categorySearchComboBox, "Select category to be displayed");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(152, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(692, 25);
            this.label2.TabIndex = 53;
            this.label2.Text = "Get to know more about our latest events and announcements";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(110)))), ((int)(((byte)(51)))));
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(524, 179);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 48);
            this.button1.TabIndex = 2;
            this.button1.Text = "Back";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.button1, "Go back to main window");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.backBtn1_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(110)))), ((int)(((byte)(51)))));
            this.label8.Location = new System.Drawing.Point(315, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(314, 38);
            this.label8.TabIndex = 52;
            this.label8.Text = "Municipality Events";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // filePathTxt
            // 
            this.filePathTxt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.filePathTxt.BackColor = System.Drawing.Color.White;
            this.filePathTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.filePathTxt.ForeColor = System.Drawing.Color.Black;
            this.filePathTxt.Location = new System.Drawing.Point(752, 400);
            this.filePathTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.filePathTxt.Multiline = true;
            this.filePathTxt.Name = "filePathTxt";
            this.filePathTxt.Size = new System.Drawing.Size(248, 27);
            this.filePathTxt.TabIndex = 38;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AddEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(991, 609);
            this.Controls.Add(this.addEventPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddEventForm";
            this.Text = "AddEventForm";
            this.addEventPanel.ResumeLayout(false);
            this.addEventPanel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.informationPanel.ResumeLayout(false);
            this.informationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel addEventPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox filePathTxt;
        private System.Windows.Forms.Panel informationPanel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DateTimePicker dateFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox categorySearchComboBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button recommendationBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private EventUserControl eventsUserControl;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox searchTxtBox;
        private System.Windows.Forms.Button searchHistoryBtn;
    }
}

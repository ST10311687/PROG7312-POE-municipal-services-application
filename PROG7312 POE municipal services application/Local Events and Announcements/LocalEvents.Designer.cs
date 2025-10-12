namespace PROG7312_POE_municipal_services_application.Local_Events_and_Announcements
{
    partial class AddEventForm
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
            this.addEventPanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.informationPanel = new System.Windows.Forms.Panel();
            this.recommendationBtn = new System.Windows.Forms.Button();
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
            this.eventsUserControl = new PROG7312_POE_municipal_services_application.Local_Events_and_Announcements.EventUserControl();
            this.addEventPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.informationPanel.SuspendLayout();
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
            this.addEventPanel.Margin = new System.Windows.Forms.Padding(2);
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
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.flowLayoutPanel1.Controls.Add(this.eventsUserControl);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 232);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(991, 377);
            this.flowLayoutPanel1.TabIndex = 40;
            // 
            // informationPanel
            // 
            this.informationPanel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.informationPanel.Controls.Add(this.recommendationBtn);
            this.informationPanel.Controls.Add(this.searchBtn);
            this.informationPanel.Controls.Add(this.panel2);
            this.informationPanel.Controls.Add(this.label2);
            this.informationPanel.Controls.Add(this.button1);
            this.informationPanel.Controls.Add(this.label8);
            this.informationPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.informationPanel.Location = new System.Drawing.Point(0, 0);
            this.informationPanel.Margin = new System.Windows.Forms.Padding(2);
            this.informationPanel.Name = "informationPanel";
            this.informationPanel.Size = new System.Drawing.Size(991, 237);
            this.informationPanel.TabIndex = 39;
            // 
            // recommendationBtn
            // 
            this.recommendationBtn.AutoSize = true;
            this.recommendationBtn.BackColor = System.Drawing.Color.Navy;
            this.recommendationBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recommendationBtn.ForeColor = System.Drawing.Color.White;
            this.recommendationBtn.Location = new System.Drawing.Point(107, 178);
            this.recommendationBtn.Margin = new System.Windows.Forms.Padding(2);
            this.recommendationBtn.Name = "recommendationBtn";
            this.recommendationBtn.Size = new System.Drawing.Size(189, 46);
            this.recommendationBtn.TabIndex = 57;
            this.recommendationBtn.Text = "Recommended event";
            this.recommendationBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.recommendationBtn, "Get your recommendation based on what you search");
            this.recommendationBtn.UseVisualStyleBackColor = false;
            this.recommendationBtn.Click += new System.EventHandler(this.recommendationBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.AutoSize = true;
            this.searchBtn.BackColor = System.Drawing.Color.Navy;
            this.searchBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.Location = new System.Drawing.Point(11, 179);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(2);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(73, 46);
            this.searchBtn.TabIndex = 37;
            this.searchBtn.Text = "Search";
            this.searchBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.searchBtn, "Search based on selected filtering");
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.searchHistoryBtn);
            this.panel2.Controls.Add(this.searchTxtBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.resetBtn);
            this.panel2.Controls.Add(this.dateFilter);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.categorySearchComboBox);
            this.panel2.Location = new System.Drawing.Point(2, 83);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
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
            this.searchHistoryBtn.Location = new System.Drawing.Point(302, 51);
            this.searchHistoryBtn.Margin = new System.Windows.Forms.Padding(2);
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
            this.searchTxtBox.Location = new System.Drawing.Point(469, 15);
            this.searchTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchTxtBox.Name = "searchTxtBox";
            this.searchTxtBox.Size = new System.Drawing.Size(192, 20);
            this.searchTxtBox.TabIndex = 56;
            this.toolTip1.SetToolTip(this.searchTxtBox, "Enter keyword for your search ");
            this.searchTxtBox.TextChanged += new System.EventHandler(this.searchTxtBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(299, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Search by keyword : ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.ForeColor = System.Drawing.Color.White;
            this.resetBtn.Location = new System.Drawing.Point(483, 51);
            this.resetBtn.Margin = new System.Windows.Forms.Padding(2);
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
            this.dateFilter.Location = new System.Drawing.Point(33, 47);
            this.dateFilter.Margin = new System.Windows.Forms.Padding(2);
            this.dateFilter.Name = "dateFilter";
            this.dateFilter.Size = new System.Drawing.Size(260, 20);
            this.dateFilter.TabIndex = 54;
            this.toolTip1.SetToolTip(this.dateFilter, "Select date and time");
            this.dateFilter.ValueChanged += new System.EventHandler(this.dateFilter_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
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
            this.categorySearchComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.categorySearchComboBox.Name = "categorySearchComboBox";
            this.categorySearchComboBox.Size = new System.Drawing.Size(201, 21);
            this.categorySearchComboBox.TabIndex = 4;
            this.toolTip1.SetToolTip(this.categorySearchComboBox, "Select category to be displayed");
            this.categorySearchComboBox.SelectedIndexChanged += new System.EventHandler(this.categorySearchComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
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
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(322, 179);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 45);
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
            this.label8.ForeColor = System.Drawing.Color.Black;
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
            this.filePathTxt.Margin = new System.Windows.Forms.Padding(2);
            this.filePathTxt.Multiline = true;
            this.filePathTxt.Name = "filePathTxt";
            this.filePathTxt.Size = new System.Drawing.Size(248, 27);
            this.filePathTxt.TabIndex = 38;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
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
            this.eventsUserControl.Margin = new System.Windows.Forms.Padding(2);
            this.eventsUserControl.Name = "eventsUserControl";
            this.eventsUserControl.Size = new System.Drawing.Size(988, 287);
            this.eventsUserControl.TabIndex = 0;
            this.toolTip1.SetToolTip(this.eventsUserControl, "Recent events and announcements");
            this.eventsUserControl.Load += new System.EventHandler(this.eventsUserControl_Load);
            // 
            // AddEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(991, 609);
            this.Controls.Add(this.addEventPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddEventForm";
            this.Text = "AddEventForm";
            this.addEventPanel.ResumeLayout(false);
            this.addEventPanel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.informationPanel.ResumeLayout(false);
            this.informationPanel.PerformLayout();
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
        private System.Windows.Forms.Button recommendationBtn;
        private EventUserControl eventsUserControl;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox searchTxtBox;
        private System.Windows.Forms.Button searchHistoryBtn;
    }
}

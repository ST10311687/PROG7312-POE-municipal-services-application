namespace PROG7312_POE_municipal_services_application.Service_Request_Status
{
    partial class ServiceForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.serviceRequestPanel = new System.Windows.Forms.Panel();
            this.resetBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.serviceTreeView = new System.Windows.Forms.TreeView();
            this.statusPanel = new System.Windows.Forms.Panel();
            this.serviceRequestsGridView = new System.Windows.Forms.DataGridView();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.categoryLbl = new System.Windows.Forms.Label();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.dateLbl = new System.Windows.Forms.Label();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.filterLbl = new System.Windows.Forms.Label();
            this.searchId = new System.Windows.Forms.TextBox();
            this.searchLbl = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.serviceRequestPanel.SuspendLayout();
            this.statusPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceRequestsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // serviceRequestPanel
            // 
            this.serviceRequestPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.serviceRequestPanel.Controls.Add(this.resetBtn);
            this.serviceRequestPanel.Controls.Add(this.label1);
            this.serviceRequestPanel.Controls.Add(this.searchBtn);
            this.serviceRequestPanel.Controls.Add(this.endDatePicker);
            this.serviceRequestPanel.Controls.Add(this.serviceTreeView);
            this.serviceRequestPanel.Controls.Add(this.statusPanel);
            this.serviceRequestPanel.Controls.Add(this.buttonPanel);
            this.serviceRequestPanel.Controls.Add(this.categoryComboBox);
            this.serviceRequestPanel.Controls.Add(this.categoryLbl);
            this.serviceRequestPanel.Controls.Add(this.startDatePicker);
            this.serviceRequestPanel.Controls.Add(this.dateLbl);
            this.serviceRequestPanel.Controls.Add(this.statusComboBox);
            this.serviceRequestPanel.Controls.Add(this.filterLbl);
            this.serviceRequestPanel.Controls.Add(this.searchId);
            this.serviceRequestPanel.Controls.Add(this.searchLbl);
            this.serviceRequestPanel.Controls.Add(this.description);
            this.serviceRequestPanel.Controls.Add(this.Title);
            this.serviceRequestPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serviceRequestPanel.Location = new System.Drawing.Point(0, 0);
            this.serviceRequestPanel.Margin = new System.Windows.Forms.Padding(2);
            this.serviceRequestPanel.Name = "serviceRequestPanel";
            this.serviceRequestPanel.Size = new System.Drawing.Size(975, 602);
            this.serviceRequestPanel.TabIndex = 0;
            // 
            // resetBtn
            // 
            this.resetBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.resetBtn.BackColor = System.Drawing.Color.Navy;
            this.resetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.ForeColor = System.Drawing.Color.White;
            this.resetBtn.Location = new System.Drawing.Point(698, 141);
            this.resetBtn.Margin = new System.Windows.Forms.Padding(2);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(184, 40);
            this.resetBtn.TabIndex = 60;
            this.resetBtn.Text = "Reset";
            this.toolTip1.SetToolTip(this.resetBtn, "Clear the filter and search criteria");
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchBtn.AutoSize = true;
            this.searchBtn.BackColor = System.Drawing.Color.Navy;
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.Location = new System.Drawing.Point(698, 92);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(2);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(184, 40);
            this.searchBtn.TabIndex = 28;
            this.searchBtn.Text = "Search";
            this.toolTip1.SetToolTip(this.searchBtn, "Search and filter");
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // endDatePicker
            // 
            this.endDatePicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.endDatePicker.Location = new System.Drawing.Point(478, 129);
            this.endDatePicker.Margin = new System.Windows.Forms.Padding(2);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(150, 20);
            this.endDatePicker.TabIndex = 67;
            this.toolTip1.SetToolTip(this.endDatePicker, "Select date that request was issued");
            this.endDatePicker.ValueChanged += new System.EventHandler(this.endDatePicker_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(385, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 66;
            this.label1.Text = "End date :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // serviceTreeView
            // 
            this.serviceTreeView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.serviceTreeView.Location = new System.Drawing.Point(555, 208);
            this.serviceTreeView.Margin = new System.Windows.Forms.Padding(2);
            this.serviceTreeView.Name = "serviceTreeView";
            this.serviceTreeView.Size = new System.Drawing.Size(395, 319);
            this.serviceTreeView.TabIndex = 65;
            this.toolTip1.SetToolTip(this.serviceTreeView, "Displays a tree with the issues");
            this.serviceTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.serviceTreeView_AfterSelect_1);
            // 
            // statusPanel
            // 
            this.statusPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.statusPanel.Controls.Add(this.serviceRequestsGridView);
            this.statusPanel.Location = new System.Drawing.Point(15, 208);
            this.statusPanel.Margin = new System.Windows.Forms.Padding(2);
            this.statusPanel.Name = "statusPanel";
            this.statusPanel.Size = new System.Drawing.Size(500, 319);
            this.statusPanel.TabIndex = 64;
            // 
            // serviceRequestsGridView
            // 
            this.serviceRequestsGridView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.serviceRequestsGridView.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.serviceRequestsGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.serviceRequestsGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.serviceRequestsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.serviceRequestsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.serviceRequestsGridView.DefaultCellStyle = dataGridViewCellStyle18;
            this.serviceRequestsGridView.GridColor = System.Drawing.Color.SaddleBrown;
            this.serviceRequestsGridView.Location = new System.Drawing.Point(4, -2);
            this.serviceRequestsGridView.Margin = new System.Windows.Forms.Padding(2);
            this.serviceRequestsGridView.Name = "serviceRequestsGridView";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.serviceRequestsGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.serviceRequestsGridView.RowHeadersWidth = 100;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black;
            this.serviceRequestsGridView.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.serviceRequestsGridView.RowTemplate.Height = 24;
            this.serviceRequestsGridView.Size = new System.Drawing.Size(496, 319);
            this.serviceRequestsGridView.TabIndex = 0;
            this.toolTip1.SetToolTip(this.serviceRequestsGridView, "Data grid view with the service requests and their status in abinary search tree");
            this.serviceRequestsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.serviceRequestsGridView_CellContentClick);
            // 
            // buttonPanel
            // 
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonPanel.Location = new System.Drawing.Point(0, 544);
            this.buttonPanel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(975, 58);
            this.buttonPanel.TabIndex = 63;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Items.AddRange(new object[] {
            "Utilities",
            "Sanitation",
            "Public Safety",
            "Others"});
            this.categoryComboBox.Location = new System.Drawing.Point(201, 160);
            this.categoryComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(164, 21);
            this.categoryComboBox.TabIndex = 62;
            this.toolTip1.SetToolTip(this.categoryComboBox, "Select category of issue");
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // categoryLbl
            // 
            this.categoryLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.categoryLbl.AutoSize = true;
            this.categoryLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLbl.Location = new System.Drawing.Point(104, 160);
            this.categoryLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.categoryLbl.Name = "categoryLbl";
            this.categoryLbl.Size = new System.Drawing.Size(93, 19);
            this.categoryLbl.TabIndex = 61;
            this.categoryLbl.Text = "Category : ";
            this.categoryLbl.Click += new System.EventHandler(this.categoryLbl_Click);
            // 
            // startDatePicker
            // 
            this.startDatePicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.startDatePicker.Location = new System.Drawing.Point(478, 92);
            this.startDatePicker.Margin = new System.Windows.Forms.Padding(2);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(150, 20);
            this.startDatePicker.TabIndex = 60;
            this.toolTip1.SetToolTip(this.startDatePicker, "Select date that request was issued");
            this.startDatePicker.ValueChanged += new System.EventHandler(this.startDatePicker_ValueChanged);
            // 
            // dateLbl
            // 
            this.dateLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateLbl.AutoSize = true;
            this.dateLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLbl.Location = new System.Drawing.Point(385, 93);
            this.dateLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(89, 19);
            this.dateLbl.TabIndex = 59;
            this.dateLbl.Text = "Start date :";
            this.dateLbl.Click += new System.EventHandler(this.dateLbl_Click);
            // 
            // statusComboBox
            // 
            this.statusComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "Complete",
            "Pending",
            "In progress"});
            this.statusComboBox.Location = new System.Drawing.Point(168, 127);
            this.statusComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(197, 21);
            this.statusComboBox.TabIndex = 58;
            this.toolTip1.SetToolTip(this.statusComboBox, "Select a status for your search");
            this.statusComboBox.SelectedIndexChanged += new System.EventHandler(this.statusComboBox_SelectedIndexChanged);
            // 
            // filterLbl
            // 
            this.filterLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.filterLbl.AutoSize = true;
            this.filterLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterLbl.Location = new System.Drawing.Point(104, 129);
            this.filterLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.filterLbl.Name = "filterLbl";
            this.filterLbl.Size = new System.Drawing.Size(60, 19);
            this.filterLbl.TabIndex = 57;
            this.filterLbl.Text = "Status :";
            // 
            // searchId
            // 
            this.searchId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchId.Location = new System.Drawing.Point(198, 95);
            this.searchId.Margin = new System.Windows.Forms.Padding(2);
            this.searchId.Name = "searchId";
            this.searchId.Size = new System.Drawing.Size(167, 20);
            this.searchId.TabIndex = 56;
            this.toolTip1.SetToolTip(this.searchId, "Search using a specific ID");
            this.searchId.TextChanged += new System.EventHandler(this.searchId_TextChanged);
            // 
            // searchLbl
            // 
            this.searchLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchLbl.AutoSize = true;
            this.searchLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLbl.Location = new System.Drawing.Point(104, 93);
            this.searchLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.searchLbl.Name = "searchLbl";
            this.searchLbl.Size = new System.Drawing.Size(90, 19);
            this.searchLbl.TabIndex = 55;
            this.searchLbl.Text = "Search ID :";
            // 
            // description
            // 
            this.description.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.ForeColor = System.Drawing.Color.Black;
            this.description.Location = new System.Drawing.Point(240, 45);
            this.description.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(486, 20);
            this.description.TabIndex = 54;
            this.description.Text = "View the status of your request by seraching with the provided filters";
            this.description.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.description.Click += new System.EventHandler(this.description_Click);
            // 
            // Title
            // 
            this.Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.Black;
            this.Title.Location = new System.Drawing.Point(310, 7);
            this.Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(362, 38);
            this.Title.TabIndex = 53;
            this.Title.Text = "Service Request Status";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(975, 602);
            this.Controls.Add(this.serviceRequestPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ServiceForm";
            this.Text = "ServiceRequestForm";
            this.serviceRequestPanel.ResumeLayout(false);
            this.serviceRequestPanel.PerformLayout();
            this.statusPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.serviceRequestsGridView)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel serviceRequestPanel;
    private System.Windows.Forms.Label Title;
    private System.Windows.Forms.Label description;
    private System.Windows.Forms.Label searchLbl;
    private System.Windows.Forms.TextBox searchId;
    private System.Windows.Forms.Label filterLbl;
    private System.Windows.Forms.DateTimePicker startDatePicker;
    private System.Windows.Forms.Label dateLbl;
    private System.Windows.Forms.ComboBox statusComboBox;
    private System.Windows.Forms.ComboBox categoryComboBox;
    private System.Windows.Forms.Label categoryLbl;
    private System.Windows.Forms.Panel buttonPanel;
    private System.Windows.Forms.Button searchBtn;
    private System.Windows.Forms.Panel statusPanel;
    private System.Windows.Forms.DataGridView serviceRequestsGridView;
    private System.Windows.Forms.TreeView serviceTreeView;
    private System.Windows.Forms.ToolTip toolTip1;
    private System.Windows.Forms.DateTimePicker endDatePicker;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button resetBtn;

    }
}
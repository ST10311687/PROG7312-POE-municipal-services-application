using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Lee James
//ST10311687

namespace PROG7312_POE_municipal_services_application.Service_Request_Status
{
    /// <summary>
    /// The main form for managing and displaying municipal service requests.
    /// </summary>
    public partial class ServiceForm : Form
    {
        // Stores all reports by their RequestID for quick lookup.
        private Dictionary<string, ReportData> requestDictionary;
        // Binary search tree for storing and searching reports.
        private BinarySearchTree bst;
        // Min-heap for prioritizing reports (e.g., by urgency).
        private MinHeap<ReportData> minHeap = new MinHeap<ReportData>();

        // Predefined progress statuses for each category.
        private Dictionary<string, string> predefinedProgress = new Dictionary<string, string>()
        {
            { "Sanitation", "In Progress" },
            { "Utilities", "Pending" },
            { "Road Maintenance", "Pending" },
            { "Public Safety", "Immediate Attention" }
        };

        /// <summary>
        /// Default constructor. Initializes the form, loads dummy data, and sets up the UI.
        /// </summary>
        public ServiceForm()
        {
            try
            {
                InitializeComponent();

                // Initialize the binary search tree.
                bst = new BinarySearchTree();
                // Generate a queue of dummy reports for demonstration.
                Queue<ReportData> dummyReports = GenerateDummyReports();

                // Insert each dummy report into the BST.
                foreach (var report in dummyReports)
                {
                    bst.Insert(report);
                }

                // Create a dictionary for quick lookup by RequestID.
                requestDictionary = dummyReports.ToDictionary(r => r.RequestID, r => r);
                // Update the status of each request based on its category.
                UpdateRequestStatus();

                // Bind the dummy reports to the DataGridView for display.
                serviceRequestsGridView.DataSource = new BindingList<ReportData>(dummyReports.ToList());
                // Build the tree view for service categories and requests.
                BuildServiceTree();

                Console.WriteLine($"Loaded {dummyReports.Count} dummy reports.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while initializing the form: {ex.Message}", "Initialization Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Constructor that accepts a list of reports. Used for custom data loading.
        /// </summary>
        /// <param name="reports">A list of ReportData objects to display and manage.</param>
        public ServiceForm(List<ReportData> reports)
        {
            try
            {
                InitializeComponent();

                if (reports == null || reports.Count == 0)
                {
                    MessageBox.Show("No reports found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Add only "Immediate Attention" reports to the min-heap for prioritization.
                foreach (var report in reports.Where(r => r.Status == "Immediate Attention"))
                {
                    minHeap.Add(report);
                }

                // Create a dictionary for quick lookup by RequestID.
                requestDictionary = reports.ToDictionary(x => x.RequestID, x => x);
                // Update the status of each request based on its category.
                UpdateRequestStatus();

                // Bind the reports to the DataGridView for display.
                serviceRequestsGridView.DataSource = new BindingList<ReportData>(reports);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while initializing the form with provided reports: {ex.Message}", "Initialization Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Updates the status of each request based on its category using predefined progress.
        /// </summary>
        private void UpdateRequestStatus()
        {
            try
            {
                // Iterate through all reports and update their status if a predefined status exists for their category.
                foreach (var key in requestDictionary.Keys.ToList())
                {
                    var report = requestDictionary[key];
                    if (predefinedProgress.ContainsKey(report.Category))
                    {
                        report.Status = predefinedProgress[report.Category];
                    }
                }

                // Refresh the DataGridView to reflect updated statuses.
                serviceRequestsGridView.DataSource = new BindingList<ReportData>(requestDictionary.Values.ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the request statuses: {ex.Message}", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Generates a set of dummy reports for demonstration and testing purposes.
        /// </summary>
        private Queue<ReportData> GenerateDummyReports()
        {
            try
            {
                // Create a list of sample reports with various categories and statuses.
                return new Queue<ReportData>(new List<ReportData>
                {
                    new ReportData { RequestID = "R001", Location = "Vilakazi Street, Soweto", Category = "Sanitation", Description = "Blocked drain on Vilakazi Street, Soweto", Status = "Pending" },
                    new ReportData { RequestID = "R002", Location = "Greenmarket Square, Cape Town", Category = "Sanitation", Description = "Overflowing bin in Greenmarket Square, Cape Town", Status = "Pending" },
                    new ReportData { RequestID = "R003", Location = "Umlazi Township, Durban", Category = "Utilities", Description = "No water supply in Umlazi Township, Durban", Status = "Pending" },
                    new ReportData { RequestID = "R004", Location = "Khayelitsha, Cape Town", Category = "Utilities", Description = "Frequent power cuts in Khayelitsha, Cape Town", Status = "Pending" },
                    new ReportData { RequestID = "R005", Location = "N1 Highway near Johannesburg", Category = "Road Maintenance", Description = "Large potholes on the N1 Highway near Johannesburg", Status = "Pending" },
                    new ReportData { RequestID = "R006", Location = "Rondebosch Main Road intersection, Cape Town", Category = "Road Maintenance", Description = "Broken traffic light at the Rondebosch Main Road intersection, Cape Town", Status = "Pending" },
                    new ReportData { RequestID = "R007", Location = "Alexandra Township, Johannesburg", Category = "Public Safety", Description = "Broken streetlights in Alexandra Township, Johannesburg", Status = "Immediate Attention" },
                    new ReportData { RequestID = "R008", Location = "Bryanston, Johannesburg", Category = "Public Safety", Description = "Tree blocking road in Bryanston, Johannesburg", Status = "Immediate Attention" },
                    new ReportData { RequestID = "R009", Location = "Durban beachfront", Category = "Sanitation", Description = "Uncollected trash near the Durban beachfront", Status = "Pending" },
                    new ReportData { RequestID = "R010", Location = "Centurion, Pretoria", Category = "Utilities", Description = "Low water pressure in Centurion, Pretoria", Status = "Pending" }
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while generating dummy reports: {ex.Message}", "Report Generation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new Queue<ReportData>();
            }
        }

        /// <summary>
        /// Builds the tree view structure for displaying service requests grouped by category.
        /// </summary>
        private void BuildServiceTree()
        {
            try
            {
                serviceTreeView.Nodes.Clear();

                // Create the root node for the tree.
                var rootNode = new TreeNode("Municipality Services");
                // Group reports by category, handling null categories as "Uncategorized".
                var groups = requestDictionary.Values
                    .GroupBy(r => r.Category ?? "Uncategorized")
                    .OrderBy(g => g.Key);

                // For each category, create a node and add child nodes for each report.
                foreach (var group in groups)
                {
                    var categoryNode = new TreeNode(group.Key);
                    foreach (var r in group.OrderBy(x => x.RequestID))
                    {
                        // Each child node displays the request ID and description.
                        categoryNode.Nodes.Add($"{r.RequestID}: {r.Description}");
                    }
                    rootNode.Nodes.Add(categoryNode);
                }

                // Add the root node to the tree view and expand it.
                serviceTreeView.Nodes.Add(rootNode);
                rootNode.Expand();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while building the service tree: {ex.Message}", "Tree Construction Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles selection events in the service tree view, displaying details for selected reports.
        /// </summary>
        private void serviceTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                // Only handle leaf nodes (level 2: category -> report).
                if (e.Node.Level == 2)
                {
                    string nodeText = e.Node.Text;
                    // Split the node text to extract the RequestID.
                    var parts = nodeText.Split(new[] { ':' }, 2);
                    if (parts.Length < 1) return;

                    string selectedRequestId = parts[0].Trim();

                    // Lookup the report and display its details.
                    if (requestDictionary != null && requestDictionary.TryGetValue(selectedRequestId, out var report))
                    {
                        MessageBox.Show($"Report ID: {report.RequestID}\nLocation: {report.Location}\nCategory: {report.Category}\nDescription: {report.Description}\nStatus: {report.Status}", "Report Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Report {selectedRequestId} not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    // No action for non-leaf nodes.
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while displaying the report details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles the form load event to ensure data is loaded.
        /// </summary>
        private void ServiceRequestStatusForm_Load(object sender, EventArgs e)
        {
            EnsureDataLoaded();
        }

        /// <summary>
        /// Ensures that the BST and data grid are populated with data.
        /// </summary>
        private void EnsureDataLoaded()
        {
            // If the BST is not initialized or empty, reload dummy data.
            if (bst == null || bst.InOrderTraversal().Count == 0)
            {
                bst = new BinarySearchTree();

                Queue<ReportData> dummyReports = GenerateDummyReports();
                foreach (var report in dummyReports)
                {
                    bst.Insert(report);
                }

                serviceRequestsGridView.DataSource = null;
                serviceRequestsGridView.DataSource = new BindingList<ReportData>(dummyReports.ToList());
            }
        }

        /// <summary>
        /// Handles the search button click event to filter and display reports based on user criteria.
        /// </summary>
        private void searchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                EnsureDataLoaded();

                // Get search criteria from UI controls.
                string requestId = searchId.Text.Trim();
                string category = categoryComboBox.SelectedItem?.ToString();
                string status = statusComboBox.SelectedItem?.ToString();

                Console.WriteLine($"Search Criteria: RequestId={requestId}, Category={category}, Status={status}");

                // Get all reports in sorted order.
                List<ReportData> allReports = bst.InOrderTraversal();

                // Filter reports based on search criteria.
                List<ReportData> filteredReports = allReports
                    .Where(r =>
                        (string.IsNullOrEmpty(requestId) || r.RequestID.Equals(requestId, StringComparison.OrdinalIgnoreCase)) &&
                        (string.IsNullOrEmpty(category) || r.Category.Equals(category, StringComparison.OrdinalIgnoreCase)) &&
                        (string.IsNullOrEmpty(status) || r.Status.Equals(status, StringComparison.OrdinalIgnoreCase))
                    )
                    .ToList();

                // Show a message if no reports match the criteria.
                if (filteredReports.Count == 0)
                {
                    MessageBox.Show("No reports match the search criteria.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Update the data grid with the filtered results.
                serviceRequestsGridView.DataSource = new BindingList<ReportData>(filteredReports);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while searching: {ex.Message}", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles the reset button click event to clear search filters and reload all data.
        /// </summary>
        private void resetBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Clear search fields and combo boxes.
                searchId.Text = "";
                categoryComboBox.SelectedIndex = -1;
                statusComboBox.SelectedIndex = -1;

                // Re-initialize the BST and reload dummy data.
                bst = new BinarySearchTree();

                Queue<ReportData> dummyReports = GenerateDummyReports();
                foreach (var report in dummyReports)
                {
                    bst.Insert(report);
                }

                // Reset the data grid to show all reports.
                serviceRequestsGridView.DataSource = null;
                serviceRequestsGridView.DataSource = new BindingList<ReportData>(dummyReports.ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while resetting the search: {ex.Message}", "Reset Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // The following event handlers are placeholders for UI events and do not contain logic.

        private void serviceRequestsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchId_TextChanged(object sender, EventArgs e)
        {

        }

        private void statusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void startDatePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void endDatePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void serviceTreeView_AfterSelect_1(object sender, TreeViewEventArgs e)
        {

        }

        private void description_Click(object sender, EventArgs e)
        {

        }

        private void dateLbl_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void categoryLbl_Click(object sender, EventArgs e)
        {

        }

        private void serviceRequestPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

//________________________________________________________End of File___________________________________________________________________________________

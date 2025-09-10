using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Windows.Forms;

//Lee James
//ST10311687
//The form that allows users to report municipal issues.

namespace PROG7312_POE_municipal_services_application.Report_Issues
{

    /// <summary>
    /// ReportIssues class represents the form where users can report municipal issues.
    /// </summary>

    public partial class ReportIssues : Form
    {
        private LinkedList<ReportedIssues> issueReports = new LinkedList<ReportedIssues>();
        public ReportIssues()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        /// <summary>
        /// Handles the Paint event of the tableLayoutPanel1 control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the comboBox1 control to update the progress bar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateProgressBar(20);
        }

        /// <summary>
        /// Handles the Load event of the ReportIssues form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void ReportIssues_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the Click event of the button3 control to navigate back to the main menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button3_Click(object sender, EventArgs e)
        {
            var mainMenuForm = new PROG7312_POE_municipal_services_application.Main_Menu.Form2();
            mainMenuForm.Show();
            this.Close();
        }

        /// <summary>
        /// Updates the progress bar by a specified increment.
        /// </summary>
        /// <param name="increment"></param>

        private void UpdateProgressBar(int increment)
        {
            int newValue = progressBar1.Value + increment;
            if (newValue <= progressBar1.Maximum && newValue >= progressBar1.Minimum)
            {
                progressBar1.Value = newValue;
            }
            else if (newValue > progressBar1.Maximum)
            {
                progressBar1.Value = progressBar1.Maximum;
            }
        }

        /// <summary>
        /// Resets the progress bar to its initial state.
        /// </summary>

        private void ResetProgressBar()
        {
            progressBar1.Value = 0;
        }

        /// <summary>
        /// Handles the Click event of the progressBar1 control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the TextChanged event of the richTextBox1 control to update the progress bar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            UpdateProgressBar(30);
        }

        /// <summary>
        /// Handles the TextChanged event of the textBox1 control to update the progress bar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png|Document Files|*.pdf;*.docx|All Files|*.*",
                Title = "Select a file to attach"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                if (string.IsNullOrWhiteSpace(filePath) || filePath.Length > 255)
                {
                    MessageBox.Show("Invalid file path or file too large.", "Invalid File", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
           
                MessageBox.Show("File attached: " + filePath);
                UpdateProgressBar(20); 
            }
        }

        /// <summary>
        /// Handles the Click event of the button4 control to submit the issue report.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button4_Click(object sender, EventArgs e)
        {
            if (ValidateForm()) 
            {
                try
                {
                    ReportedIssues newReport = new ReportedIssues
                    {
                        Location = textBox1.Text,
                        Category = comboBox1.SelectedItem.ToString(),
                        Description = richTextBox1.Text,
                    };

                    issueReports.AddLast(newReport);


                    MessageBox.Show("Thank you for submitting your issue report! We'll review it and get back to you soon.", "Submission Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);                 

                    ResetFormFields();

                    ResetProgressBar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while submitting the report: " + ex.Message, "Submission Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please complete all required fields.", "Incomplete Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Validates the form inputs to ensure all required fields are filled out correctly.
        /// </summary>
        /// <returns></returns>

        private bool ValidateForm()
        {
            bool isValid = true;            

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please enter a valid location.", "Invalid Location", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isValid = false;
            }

            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a category.", "No Category Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(richTextBox1.Text))
            {
                MessageBox.Show("Please enter a description.", "No Description", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isValid = false;
            }

            return isValid;
        }

        /// <summary>
        /// Resets the form fields to their default state.
        /// </summary>

        private void ResetFormFields()
        {
            textBox1.Clear();
            comboBox1.SelectedIndex = -1;
            richTextBox1.Clear();

        }

        /// <summary>
        /// Handles the Click event of the button2 control to view submitted reports.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button2_Click(object sender, EventArgs e)
        {
 
            ReportList reportListForm = new ReportList(issueReports.ToList());
            reportListForm.ShowDialog();
        }

        /// <summary>
        /// Handles the Click event of the label3 control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void label3_Click(object sender, EventArgs e)
        {
         
        }
    }
}

//________________________________________________________End of File___________________________________________________________________________________
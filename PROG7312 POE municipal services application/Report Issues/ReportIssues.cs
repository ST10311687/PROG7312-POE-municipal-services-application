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

namespace PROG7312_POE_municipal_services_application.Report_Issues
{
    public partial class ReportIssues : Form
    {
        private List<ReportedIssues> issueReports = new List<ReportedIssues>();
        public ReportIssues()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateProgressBar(20);
        }

        private void ReportIssues_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 mainForm = new Form1();
            mainForm.Show();
            this.Close();
        }

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

        private void ResetProgressBar()
        {
            progressBar1.Value = 0;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            UpdateProgressBar(30);
        }

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

                    issueReports.Add(newReport);


                    MessageBox.Show("Thank you for submitting your issue report! We'll review it and get back to you soon.", "Submission Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //DialogResult response = MessageBox.Show("Would you like to provide feedback about the reporting process?", "Submission Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    //if (response == DialogResult.Yes)
                    //{
                    //    FeedbackForm feedbackForm = new FeedbackForm();
                    //    feedbackForm.ShowDialog();
                    //}

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

        private void ResetFormFields()
        {
            textBox1.Clear();
            comboBox1.SelectedIndex = -1;
            richTextBox1.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReportList reportListForm = new ReportList(issueReports);
            reportListForm.ShowDialog();
        }
    }
}

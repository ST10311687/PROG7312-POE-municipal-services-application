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
    }
}

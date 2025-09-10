
using PROG7312_POE_municipal_services_application.Report_Issues;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PROG7312_POE_municipal_services_application.Main_Menu
{
    public partial class Form2 : Form
    {
        private PROG7312_POE_municipal_services_application.Dashboard.DashboardForm dashboardForm;
        private object dashboard;
        private ReportIssues reportForm;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string imagePath = @"Pictures\CapeTownLogo-286150665.PNG";
            pictureBox1.Image = Image.FromFile(imagePath);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; // Optional: scales image to fit
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void reportIssuesBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (reportForm == null)
                {
                    reportForm = new ReportIssues
                    {
                        MdiParent = this,  // Set this form as the parent
                        Dock = DockStyle.Fill // Fill the parent container
                    };
                //    reportForm.FormClosed += ReportIssues_FormClosed; // Reset reference on closure
                    reportForm.Show();
                }
                else
                {
                    reportForm.Activate(); // Bring the form to focus if already open
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while opening the Report Issues form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for using this application!", "Exit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (dashboardForm == null)
                {
                    dashboardForm = new PROG7312_POE_municipal_services_application.Dashboard.DashboardForm();
                    dashboardForm.MdiParent = this;  // Set this form as the parent
                    dashboardForm.Dock = DockStyle.Fill; // Fill the parent container
                    dashboardForm.FormClosed += DashboardForm_FormClosed; // Reset reference on closure
                    dashboardForm.Show();
                }
                else
                {
                    dashboardForm.Activate(); // Bring the form to focus if already open
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while opening the Dashboard: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void localEventsBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming soon!", "Future feature", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void requestsBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming soon!", "Future feature", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    
        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            dashboard = null;
        }
        private void DashboardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            dashboardForm = null;
        }
    }
}

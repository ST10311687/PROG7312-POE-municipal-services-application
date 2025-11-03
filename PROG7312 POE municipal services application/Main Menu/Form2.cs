
using PROG7312_POE_municipal_services_application.Local_Events_and_Announcements;
using PROG7312_POE_municipal_services_application.Report_Issues;
using PROG7312_POE_municipal_services_application.Service_Request_Status;
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
//The primary window that acts as the application’s entry point.


namespace PROG7312_POE_municipal_services_application.Main_Menu
{
    public partial class Form2 : Form
    {
        private PROG7312_POE_municipal_services_application.Dashboard.DashboardForm dashboardForm;
        private object dashboard;
        private ReportIssues reportForm;
        private AddEventForm localEventsForm;
        private ServiceForm requestForm;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string imagePath = @"Pictures\CapeTownLogo-286150665.PNG";
            pictureBox1.Image = Image.FromFile(imagePath);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; 
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        /// <summary>
        /// Opens the Report Issues form as an MDI child, ensuring only one instance is open at a time.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void reportIssuesBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (reportForm == null)
                {
                    reportForm = new ReportIssues
                    {
                        MdiParent = this,  
                        Dock = DockStyle.Fill 
                    };
            
                    reportForm.Show();
                }
                else
                {
                    reportForm.Activate(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while opening the Report Issues form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles the exit button click event to close the application with a thank you message.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void exitBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for using this application!", "Exit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        /// <summary>
        /// Opens the Dashboard form as an MDI child, ensuring only one instance is open at a time.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (dashboardForm == null)
                {
                    dashboardForm = new PROG7312_POE_municipal_services_application.Dashboard.DashboardForm();
                    dashboardForm.MdiParent = this;
                    dashboardForm.Dock = DockStyle.Fill;
                    dashboardForm.FormClosed += DashboardForm_FormClosed;
                    dashboardForm.Show();
                }
                else
                {
                    dashboardForm.Activate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while opening the Dashboard: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Placeholder for future feature: Local Events button click event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void localEventsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (localEventsForm == null)
                {
                    localEventsForm = new AddEventForm
                    {
                        MdiParent = this,
                        Dock = DockStyle.Fill
                    };
                    localEventsForm.FormClosed += (s, args) => localEventsForm = null;
                    localEventsForm.Show();
                }
                else
                {
                    localEventsForm.Activate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while opening Local Events: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Placeholder for future feature: Requests button click event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void requestsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (requestForm == null)
                {
                    requestForm = new ServiceForm
                    {
                        MdiParent = this,  
                        Dock = DockStyle.Fill 
                    };
                    requestForm.FormClosed += ServiceRequest_FormClosed; 
                    requestForm.Show();
                }
                else
                {
                    requestForm.Activate(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while opening the Service Request form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ServiceRequest_FormClosed(object sender, FormClosedEventArgs e)
        {
            requestForm = null;
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

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }
    }
}

//________________________________________________________End of File___________________________________________________________________________________
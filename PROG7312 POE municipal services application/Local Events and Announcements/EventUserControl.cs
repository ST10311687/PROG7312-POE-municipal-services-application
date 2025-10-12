using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG7312_POE_municipal_services_application.Local_Events_and_Announcements
{
    public partial class EventUserControl : UserControl
    {
        public EventUserControl()
        {
            InitializeComponent();
        }

        private void EventUserControl_Load(object sender, EventArgs e)
        {

        }

        private void descriptionLbl_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Variables for event properties
        /// </summary>
        private string _eventName;
        private string _eventCategory;
        private string _eventLocation;
        private string _eventDescription;
        private DateTime _eventTime;
        private Image _eventImage;

        // Property for Event Name
        [Category("Custom Props")]
        public string EventName
        {
            get { return _eventName; }
            set { _eventName = value; nameLbl.Text = value; }
        }

        // Property for Event Category
        [Category("Custom Props")]
        public string EventCategory
        {
            get { return _eventCategory; }
            set { _eventCategory = value; categoryLbl.Text = value; }
        }

        // Property for Event Location
        [Category("Custom Props")]
        public string EventLocation
        {
            get { return _eventLocation; }
            set { _eventLocation = value; locationLbl.Text = value; }
        }

        // Property for Event Description
        [Category("Custom Props")]
        public string EventDescription
        {
            get { return _eventDescription; }
            set { _eventDescription = value; descriptionLbl.Text = value; }
        }

        // Property for Event Time
        [Category("Custom Props")]
        public DateTime EventTime
        {
            get { return _eventTime; }
            set { _eventTime = value; timeLbl.Text = value.ToString("dd/MM/yyyy hh:mm tt"); }
        }

        // Property for Event Image
        [Category("Custom Props")]
        public Image EventImage
        {
            get { return _eventImage; }
            set
            {
                _eventImage = value;
                pictureBoxDisplay.Image = value;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

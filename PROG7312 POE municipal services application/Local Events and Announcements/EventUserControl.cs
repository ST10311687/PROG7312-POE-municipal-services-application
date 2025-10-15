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

namespace PROG7312_POE_municipal_services_application.Local_Events_and_Announcements
{
    // This UserControl displays the details of a single event in the UI.
    public partial class EventUserControl : UserControl
    {
        public EventUserControl()
        {
            InitializeComponent();
        }

        // Private backing fields for the event properties.
        private string _eventName;
        private string _eventCategory;
        private string _eventLocation;
        private string _eventDescription;
        private DateTime _eventTime;
        private Image _eventImage;

        /// <summary>
        /// Property for the event's name. Updates the name label when set.
        /// </summary>        
        [Category("Custom Props")]
        public string EventName
        {
            get { return _eventName; }
            set { _eventName = value; nameLbl.Text = value; }
        }

        /// <summary>
        /// Property for the event's category. Updates the category label when set.
        /// </summary>
        [Category("Custom Props")]
        public string EventCategory
        {
            get { return _eventCategory; }
            set { _eventCategory = value; categoryLbl.Text = value; }
        }

        /// <summary>
        /// Property for the event's location. Updates the location label when set.
        /// </summary>        
        [Category("Custom Props")]
        public string EventLocation
        {
            get { return _eventLocation; }
            set { _eventLocation = value; locationLbl.Text = value; }
        }

        /// <summary>
        /// Property for the event's description. Updates the description label when set.                                   
        /// </summary>
        [Category("Custom Props")]
        public string EventDescription
        {
            get { return _eventDescription; }
            set { _eventDescription = value; descriptionLbl.Text = value; }
        }

        /// <summary>
        /// Property for the event's time. Updates the time label when set.
        /// </summary>
        [Category("Custom Props")]
        public DateTime EventTime
        {
            get { return _eventTime; }
            set { _eventTime = value; timeLbl.Text = value.ToString("dd/MM/yyyy hh:mm tt"); }
        }

        /// <summary>
        /// Property for the event's image. Updates the picture box when set.
        /// </summary>
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

        private void descriptionLbl_Click(object sender, EventArgs e)
        {

        }

        private void locationLbl_Click(object sender, EventArgs e)
        {

        }
    }
}

//________________________________________________________End of File___________________________________________________________________________________
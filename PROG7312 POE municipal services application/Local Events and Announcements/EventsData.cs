using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7312_POE_municipal_services_application.Local_Events_and_Announcements
{
    public class EventsData
    {

        /// <summary>
        /// generating public getters and setters.
        /// </summary>
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public DateTime Time { get; set; }
        public Image Media { get; set; }
        public string Location { get; set; }


        /// <summary>
        /// New property to store the formatted time
        /// </summary>
        public string FormattedTime { get; set; }

       
        

        /// <summary>
        /// parameterised constructor.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="category"></param>
        /// <param name="description"></param>
        /// <param name="time"></param>
        /// <param name="media"></param>
        /// <param name="location"></param>
        public EventsData(string name, string category, string description, DateTime time, Image media, string location)
        {
            Name = name;
            Category = category;
            Description = description;
            Time = time;
            Media = media;
            Location = location;
        }//__________________________________________________________________________________________________________


        /// <summary>
        /// parameterised constructor to be used in service requests. 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="category"></param>
        /// <param name="description"></param>
        /// <param name="time"></param>
        /// <param name="media"></param>
        /// <param name="location"></param>
        /// <param name="formattedTime"></param>
        public EventsData(string name, string category, string description, DateTime time, Image media, string location, string formattedTime)
        {
            Name = name;
            Category = category;
            Description = description;
            Time = time;
            Media = media;
            Location = location;
            FormattedTime = formattedTime;
        }

    }
}

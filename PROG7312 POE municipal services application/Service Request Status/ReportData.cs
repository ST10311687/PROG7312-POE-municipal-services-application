using System;
using System.Collections.Generic;

//Lee James
//ST10311687

namespace PROG7312_POE_municipal_services_application.Service_Request_Status
{
    public class ReportData 
    {
        /// <summary>
        /// Represents a service request report with details such as location, category, description, media, and status.
        /// </summary>
        /// 
        public string RequestID { get; set; }
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string Media { get; set; }
        public string Status { get; set; }

        public ReportData() { }

        /// <summary>
        /// Initializes a new instance of the ReportData class with all properties specified.
        /// </summary>
        public ReportData(string requestID, string location, string category, string description, string media, string status)
        {
            RequestID = requestID;
            Location = location;
            Category = category;
            Description = description;
            Media = media;
            Status = status;
        }

        /// <summary>
        /// Dictionary mapping status strings to their priority values (lower is higher priority).
        /// </summary>
        
        private static readonly Dictionary<string, int> StatusPriority = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase)
        {
            { "Immediate Attention", 0 },
            { "In Progress", 1 },
            { "Acknowledged", 2 },
            { "Pending", 3 },
            { "Resolved", 4 },
            { "Closed", 5 }
        };

        public int GetPriority()
        {
            if (Status != null && StatusPriority.TryGetValue(Status, out int p))
                return p;
            return 99; 
        }

    }
}

//________________________________________________________End of File___________________________________________________________________________________
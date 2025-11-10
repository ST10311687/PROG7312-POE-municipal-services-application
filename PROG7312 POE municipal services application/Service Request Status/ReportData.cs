// ReportData.cs — add IComparable implementation
using System;
using System.Collections.Generic;

namespace PROG7312_POE_municipal_services_application.Service_Request_Status
{
    public class ReportData 
    {
        public string RequestID { get; set; }
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string Media { get; set; }
        public string Status { get; set; }

        public ReportData() { }

        public ReportData(string requestID, string location, string category, string description, string media, string status)
        {
            RequestID = requestID;
            Location = location;
            Category = category;
            Description = description;
            Media = media;
            Status = status;
        }

        public ReportData(string requestID, string location, string category, string description, string status)
        {
            RequestID = requestID;
            Location = location;
            Category = category;
            Description = description;

            Status = status;
        }

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


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7312_POE_municipal_services_application.Service_Request_Status
{
    public class ReportData
    {
        public string RequestID { get; set; } 
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string Media { get; set; }
        public DateTime SubmissionDate { get; set; }
        public string Status { get; set; } 

  
        public ReportData()
        {

        } 


        public ReportData(string requestID, string location, string category, string description, string media, DateTime submissionDate, string status)
        {
            RequestID = requestID;
            Location = location;
            Category = category;
            Description = description;
            Media = media;
            SubmissionDate = submissionDate;
            Status = status;
        } 

  
        public ReportData(string requestID, string location, string category, string description, DateTime submissionDate, string status)
        {
            RequestID = requestID;
            Location = location;
            Category = category;
            Description = description;
            SubmissionDate = submissionDate;
            Status = status;
        }
    }
}

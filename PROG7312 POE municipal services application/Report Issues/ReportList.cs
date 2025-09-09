using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG7312_POE_municipal_services_application.Report_Issues
{
    public partial class ReportList : Form
    {
        private List<ReportedIssues> issueReports;
        private BindingSource bindingSource;
        public ReportList(List<ReportedIssues> issueReports)
        {
            InitializeComponent();
            this.issueReports = issueReports;
            bindingSource = new BindingSource();
            bindingSource.DataSource = issueReports;
            this.issueReports = issueReports;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ReportList_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bindingSource;
            dataGridView1.AutoGenerateColumns = true;
        }
    }
}

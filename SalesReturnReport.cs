using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventorymanagementsystem
{
    public partial class SalesReturnReport : Form
    {
        ViewData v = new ViewData();
        ReportDocument rd;
        public SalesReturnReport()
        {
            InitializeComponent();
        }

        private void SalesReturnReport_Load(object sender, EventArgs e)
        {
            rd = new ReportDocument();
            v.showreport("SalesReturnReceipt.rpt",rd, crystalReportViewer2, "getrefundreceipt","@saleid","123");
        }
    }
}

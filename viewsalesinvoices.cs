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
    
    public partial class viewsalesinvoices : Sample
    {
        ViewData v = new ViewData();
        public viewsalesinvoices()
        {
            InitializeComponent();
        }

        private void load_Click(object sender, EventArgs e)
        {
            v.showDailysales(selectdate.Value, invoicegrid,salesidgv,useridgv,usergv,totalamountgv,totaldiscountgv,amountgivegv,amountregv);
            foreach (DataGridViewRow row in invoicegrid.Rows)
            {
                row.Cells["totalamountgv"].Value = Math.Ceiling(Convert.ToSingle(row.Cells["totalamountgv"].Value.ToString()));
                row.Cells["totaldiscountgv"].Value = Math.Ceiling(Convert.ToSingle(row.Cells["totaldiscountgv"].Value.ToString()));
                row.Cells["amountgivegv"].Value = Math.Ceiling(Convert.ToSingle(row.Cells["amountgivegv"].Value.ToString()));
                row.Cells["amountregv"].Value = Math.Ceiling(Convert.ToSingle(row.Cells["amountregv"].Value.ToString()));
            }
        }
        

        private void button1_Click_1(object sender, EventArgs e)
        {
            Sales de = new Sales();
            MainClass.showWindow(de, this, mdi.ActiveForm);
        }
        public static int salesid=0;
        private void invoicegrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                DataGridViewRow row = invoicegrid.Rows[e.RowIndex];
                salesid = Convert.ToInt32(row.Cells["salesidgv"].Value.ToString());
                SalesReport sc = new SalesReport();
                sc.Show();
            }
        }
    }
}

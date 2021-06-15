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
    public partial class Stocks : othersample
    {
        public Stocks()
        {
            InitializeComponent();
        }
        ViewData v = new ViewData();
        private void Stocks_Load(object sender, EventArgs e)
        {
            add.Enabled = false;
            edit.Enabled = false;
            save.Enabled = false;
            delete.Enabled = false;
        }

        public override void view_Click(object sender, EventArgs e)
        {
            v.showstocks(stocksfrid, proidgv, productnamegv, barcodegv,bpgv,spgv, expirygv, categorygv, quantitygv,totalamountgv, statusgv);
        }

        public override void searchtx_TextChanged(object sender, EventArgs e)
        {

        }

        public override void button1_Click(object sender, EventArgs e)
        {
            Dashboard de = new Dashboard();
            MainClass.showWindow(de, this, mdi.ActiveForm);
        }

        private void othersample_Load(object sender, EventArgs e)
        {
            userlabel.Text = ViewData.emp_name;

        }
    }
}

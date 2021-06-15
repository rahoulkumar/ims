using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventorymanagementsystem
{
    public partial class Productpricing : othersample
    {
        ViewData v = new ViewData();
        Updation u = new Updation();
        Regex reg = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");
        public Productpricing()
        {
            InitializeComponent();
            v.getCategoryList("ca_viewcategorylist", category, "Category", "ID");
            
        }

        private void category_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (category.SelectedIndex != -1 && category.SelectedIndex != 0)
            {
                v.showsproductsbycategory(Convert.ToInt32(category.SelectedValue.ToString()), pricegrid, proidgv, productnamegv, buyingpricegv,finalgv,discountgv,profitmargingv);

            }
        }

        private void pricegrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                DataGridViewRow row = pricegrid.Rows[e.RowIndex];
                if (row.Cells["profitmargingv"].Value != DBNull.Value && reg.Match(row.Cells["profitmargingv"].Value.ToString()).Success)
                {
                    float buyingprice = Convert.ToSingle(row.Cells["buyingpricegv"].Value.ToString());
                    float profitmargin = Convert.ToSingle(row.Cells["profitmargingv"].Value.ToString()) / 100;
                    float amountincrease = profitmargin * buyingprice;
                    float discount;
                    
                    float finalsellingprice = buyingprice + amountincrease;

                    if (row.Cells["discountgv"].Value != DBNull.Value && reg.Match(row.Cells["discountgv"].Value.ToString()).Success)
                    {
                        discount = finalsellingprice * (Convert.ToSingle(row.Cells["discountgv"].Value.ToString()) / 100);
                    }
                    else
                    {
                        discount = 0;
                    }
                    row.Cells["finalgv"].Value = finalsellingprice-discount;
                }
                else
                {
                    row.Cells["finalgv"].Value = null;
                    row.Cells["profitmargingv"].Value = null;
                    row.Cells["discountgv"].Value = null;
                }
            }
        }

        public override void add_Click(object sender, EventArgs e)
        {

        }

        public override void edit_Click(object sender, EventArgs e)
        {

        }
        int incre=0;
        public override void save_Click(object sender, EventArgs e)
        {
            if (category.SelectedIndex != -1 && category.SelectedIndex != 0)
            {
                foreach (DataGridViewRow row in pricegrid.Rows)
                {
                    if((bool)row.Cells["selectgv"].FormattedValue == true){
                        incre++;
                        float discount,margin,sp,bp;
                        int pid;
                        discount = row.Cells["discountgv"].Value == null ? 0 : Convert.ToSingle(row.Cells["discountgv"].Value.ToString());
                        margin = row.Cells["profitmargingv"].Value == null ?0 : Convert.ToSingle(row.Cells["profitmargingv"].Value.ToString());
                        pid=Convert.ToInt32(row.Cells["proidgv"].Value.ToString());
                        bp=Convert.ToSingle(row.Cells["buyingpricegv"].Value.ToString());
                        if (discount == 0 && margin == 0)
                        {
                            sp=bp;
                        }
                        else
                        {
                            sp=Convert.ToSingle(row.Cells["finalgv"].Value.ToString());
                        }
                        u.updatepriceproducts(pid,bp,sp,discount,margin);
                    }
                }
                if (incre > 0)
                {
                    MainClass.Showmessage("Data Updated Successfully in the System", "Success", "Success");
                    incre = 0;
                }
                else
                {
                    MainClass.Showmessage("Please Select product", "Error", "Error");
                    incre = 0;
                }
            }
        }

        public override void delete_Click(object sender, EventArgs e)
        {

        }

        public override void view_Click(object sender, EventArgs e)
        {

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

        private void pricegrid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void Productpricing_Load(object sender, EventArgs e)
        {
            add.Enabled = false;
            edit.Enabled = false;
            searchtx.Enabled = false;
            delete.Enabled = false;
            view.Enabled = false;
        }

        
    }
}

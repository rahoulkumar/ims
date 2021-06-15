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
using System.Transactions;
namespace inventorymanagementsystem
{
    public partial class PurchaseSupplier : othersample
    {
        Regex re = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");
        
        ViewData p = new ViewData();
        Updation u = new Updation();
        float ge;
        int productid;
        int Edit = 0;//this 0 represent save operation and 1 for update operation//

        public PurchaseSupplier()
        {
            InitializeComponent();
        }
        public override void add_Click(object sender, EventArgs e)
        {
            MainClass.enable_reset(leftpanel);
            productname.Enabled = false;
            Edit = 0;
        }

        public override void edit_Click(object sender, EventArgs e)
        {
            Edit = 1;
            MainClass.enable(leftpanel);
        }
        int dg;
        int purchaseid;
        public override void save_Click(object sender, EventArgs e)
        {
            if(purchasegrid.Rows.Count>0){
               
                Insertion i = new Insertion();
                using (TransactionScope de = new TransactionScope())
           
            {

                purchaseid=i.insertpurchase(DateTime.Today, ViewData.userid, Convert.ToInt32(companys.SelectedValue));
                foreach (DataGridViewRow row in purchasegrid.Rows)
                {
                    dg += i.insertpurchasedetails(purchaseid,Convert.ToInt32(row.Cells["proidgv"].Value.ToString()),Convert.ToInt32(row.Cells["quantitygv"].Value.ToString()),Convert.ToSingle(row.Cells["totalamountgv"].Value.ToString()));
                    if (p.checkproductprice(Convert.ToInt32(row.Cells["proidgv"].Value.ToString())))
                    {
                        u.updatepriceproducts(Convert.ToInt32(row.Cells["proidgv"].Value.ToString()),Convert.ToInt32(row.Cells["perunitpricegv"].Value.ToString()));
                    }
                    else
                    {
                        i.insertpriceproducts(Convert.ToInt32(row.Cells["proidgv"].Value.ToString()), Convert.ToInt32(row.Cells["perunitpricegv"].Value.ToString()));
                    }
                   
                    int q;
                    object ob=p.getproductsquantity(Convert.ToInt32(row.Cells["proidgv"].Value.ToString()));
                    if(ob!=null)
                    {
                        q = Convert.ToInt32(ob);
                        q+=Convert.ToInt32(row.Cells["quantitygv"].Value.ToString());
                        u.updateStocks(Convert.ToInt32(row.Cells["proidgv"].Value.ToString()),q);
                    }
                    else
                    {
                        i.insertStocks(Convert.ToInt32(row.Cells["proidgv"].Value.ToString()), Convert.ToInt32(row.Cells["quantitygv"].Value.ToString()));
                    }
                }
                    if(dg>0){
                        MainClass.Showmessage("Purchase Invoice Has Been Generated Successfully","Success","Success");
                        purchasegrid.Rows.Clear();
                        grandtotal.Text = "0.00";
                    }
                    else{
                         MainClass.Showmessage("Unable to Purchase Invoice Creation","Error","Error");
                    }
                    de.Complete();
            }
        }
        }
    
        public override void delete_Click(object sender, EventArgs e)
        {

        }

        public override void view_Click(object sender, EventArgs e)
        {
            PurchaseDetails de = new PurchaseDetails();
            MainClass.showWindow(de, this, mdi.ActiveForm);
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

        private void PurchaseSupplier_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(leftpanel);
            p.getSupplierList("su_viewsupplierlsit", companys, "Company", "ID");
            edit.Enabled = false;
            delete.Enabled = false;
            searchtx.Enabled = false;
            view.Text = "Details";
        }
        string[] datas = new string[3];
        private void barcode_TextChanged(object sender, EventArgs e)
        {
            if (barcode.Text != "")
            {
                datas = p.getproductsbybarcodesecond(barcode.Text);
                productid = Convert.ToInt32(datas[0]);
                productname.Text = (datas[1]);
                string code = datas[2];
                productname.Enabled = false;

                if (code != null)
                {
                    perunitprice.Focus();
                   
                }
            }
            else
            {
                productid = 0;
                productname.Text = "";
                perunitprice.Text = "";
                quantity.Text = "";
                Array.Clear(datas, 0, datas.Length);
            }
        }

        private void quantity_TextChanged(object sender, EventArgs e)
        {
            if (quantity.Text != "")
            {
                if (re.Match(quantity.Text).Success)
                {
                    float price, total, quant;
                    quant = Convert.ToSingle(quantity.Text);
                    price = Convert.ToSingle(perunitprice.Text);
                    total = quant * price;
                    totals.Text = total.ToString("########.##");
                }
                else
                {
                    quantity.SelectAll();
                }
            }
            else
            {
                totals.Text = "0.00";
            }
        }

        private void addtocart_Click(object sender, EventArgs e)
        {
            if (companys.SelectedIndex == -1 || companys.SelectedIndex == 0) { companyerror.Visible = true; } else { companyerror.Visible = false; }
            if (barcode.Text == "") { barcodeerror.Visible = true; } else { barcodeerror.Visible = false; }
            if (quantity.Text == "") { quantityerror.Visible = true; } else { quantityerror.Visible = false; }


            if (companyerror.Visible || barcodeerror.Visible || quantityerror.Visible)
            {
                MainClass.Showmessage("fields with * are mandatory", "Error", "Error");
            }
            else
            {

                purchasegrid.Rows.Add(productid, productname.Text, quantity.Text, perunitprice.Text, totals.Text);
                    ge += Convert.ToSingle(totals.Text);
                    grandtotal.Text = ge.ToString();
                    productid = 0;
                    barcode.Text = "";
                    productname.Text = "";
                    perunitprice.Text = "";
                    quantity.Text = "";
                    Array.Clear(datas, 0, datas.Length);
                
                
                             
            }
        }

        private void purchasegrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex!=-1)
            {
                if (e.ColumnIndex == 5)
                {
                    DataGridViewRow row = purchasegrid.Rows[e.RowIndex];
                    ge -= Convert.ToSingle(row.Cells["totalamountgv"].Value.ToString());
                    grandtotal.Text = ge.ToString();
                    purchasegrid.Rows.Remove(row);
                    
                }
                
            }
        }

        private void company_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void purchasegrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
     
        private void perunitprice_TextChanged(object sender, EventArgs e)
        {
            if (perunitprice.Text != null)
            {
                if (!re.Match(perunitprice.Text).Success)
                {
                    perunitprice.Text = "";
                    perunitprice.Focus();
                }
            }
        }
    }
}


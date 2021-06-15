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
    public partial class Products : othersample
    {
        ViewData p = new ViewData();
        int proid;
        int Edit = 0;//this 0 represent save operation and 1 for update operation//
        public Products()
        {
            InitializeComponent();
        }
        public override void add_Click(object sender, EventArgs e)
        {
            MainClass.enable_reset(leftpanel);
            Edit = 0;
           
        }

        public override void edit_Click(object sender, EventArgs e)
        {
            Edit = 1;
            MainClass.enable(leftpanel);
        }

        public override void save_Click(object sender, EventArgs e)
        {
            if (productname.Text == "") { productnameerror.Visible = true; } else { productnameerror.Visible = false; }
            
            if (barcode.Text == "") { barcoderror.Visible = true; } else { barcoderror.Visible = false; }
           
            if (categorynames.SelectedIndex == -1 || categorynames.SelectedIndex ==0) { categoryerror.Visible = true; } else { categoryerror.Visible = false; }
            if (expirydate.Value < DateTime.Now) { expiryerror.Visible = true; expiryerror.Text = "invalid date"; } else { expiryerror.Visible = false; }
            if (expirydate.Value.Date == DateTime.Now.Date) { expiryerror.Visible = false; } 


            if (productnameerror.Visible || barcoderror.Visible || categoryerror.Visible || expiryerror.Visible)
            {
                MainClass.Showmessage("fields with * are mandatory", "Error", "Error");
            }
            else
            {
               
                if (Edit == 0)//for save operation
                {
                   
                    DialogResult dr = MessageBox.Show("Are you sure you want to insert data?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        Insertion i = new Insertion();
                        if (expirydate.Value.Date == DateTime.Now.Date)
                        {
                            i.insertProducts(productname.Text, brandname.Text, barcode.Text, Convert.ToInt32(categorynames.SelectedValue));
                        }
                        else
                        {
                            i.insertProducts(productname.Text, brandname.Text, barcode.Text, Convert.ToInt32(categorynames.SelectedValue), expirydate.Value);
                        }
                        p.showProducts(productsgrids,productidgv,productnamegv,brandnamegv,productbarcodegv,categorygv,catidgv,expirydategv);
                        MainClass.disable_reset(leftpanel);
                    }
                }
                else if (Edit == 1)//for edit operation mean update
                {
                    DialogResult dr = MessageBox.Show("Are you sure you want to update data?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        Updation u = new Updation();
                        if (expirydate.Value.Date == DateTime.Now.Date)
                        {
                            u.updateProducts(proid, productname.Text, brandname.Text, barcode.Text, Convert.ToInt32(categorynames.SelectedValue));
                        }
                        else
                        {
                            u.updateProducts(proid, productname.Text, brandname.Text, barcode.Text, Convert.ToInt32(categorynames.SelectedValue), expirydate.Value);
                        }                
                        p.showProducts(productsgrids,productidgv,productnamegv,brandnamegv,productbarcodegv,categorygv,catidgv,expirydategv);
                        MainClass.disable_reset(leftpanel);
                    }

                }
            }
        }

        public override void delete_Click(object sender, EventArgs e)
        {
            if (Edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete data?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Deletion d = new Deletion();
                    d.DeleteProducts(proid, "pr_deleteproducts", "@proid");
                    p.showProducts(productsgrids,productidgv,productnamegv,brandnamegv,productbarcodegv,categorygv,catidgv,expirydategv);
                }
            }
        }

        public override void view_Click(object sender, EventArgs e)
        {
            MainClass.disable(leftpanel);
            p.showProducts(productsgrids, productidgv, productnamegv, brandnamegv, productbarcodegv, categorygv, catidgv, expirydategv);
        }


        public override void searchtx_TextChanged(object sender, EventArgs e)
        {
            if (searchtx.Text != "")
            {
                p.showProducts(productsgrids, productidgv, productnamegv, brandnamegv, productbarcodegv, categorygv, catidgv, expirydategv,searchtx.Text);
            }
            else
            {
                p.showProducts(productsgrids, productidgv, productnamegv, brandnamegv, productbarcodegv, categorygv, catidgv, expirydategv);
            }
        }

        private void Products_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(leftpanel);
            p.getCategoryList("ca_viewcategorylist", categorynames, "Category", "ID");
        }

        

        private void productsgrid_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            MainClass.disable(leftpanel);
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                Edit = 1;
                DataGridViewRow row = productsgrids.Rows[e.RowIndex];
                proid = Convert.ToInt32(row.Cells["productidgv"].Value.ToString());
                productname.Text = (row.Cells["productnamegv"].Value.ToString());
                brandname.Text = (row.Cells["brandnamegv"].Value.ToString());
                barcode.Text = (row.Cells["productbarcodegv"].Value.ToString());
                categorynames.SelectedValue = (row.Cells["catidgv"].Value.ToString());
                if (row.Cells["expirydategv"].FormattedValue.ToString() == "")
                {
                    expirydate.Value = DateTime.Now;
                }
                else
                {
                    expirydate.Value = Convert.ToDateTime(row.Cells["expirydategv"].Value.ToString());
                }

            }
        }
        }
    }


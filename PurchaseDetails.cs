using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Transactions;

namespace inventorymanagementsystem
{

    public partial class PurchaseDetails : othersample
    {
        ViewData p = new ViewData();
        Insertion i = new Insertion();
        Updation u = new Updation();
        Deletion d = new Deletion();
       


        public PurchaseDetails()
        {
            InitializeComponent();
        }
        public override void button1_Click(object sender, EventArgs e)
        {
            PurchaseSupplier de = new PurchaseSupplier();
            MainClass.showWindow(de, this, mdi.ActiveForm);
        }

        private void date_ValueChanged(object sender, EventArgs e)
        {
            p.getinvoiceListparam("getinvoicelist", invoice, "Company", "ID", "@month", date.Value.Month, "@year", date.Value.Year);
        }

        private void PurchaseDetails_Load(object sender, EventArgs e)
        {
            p.getinvoiceListparam("getinvoicelist", invoice, "Company", "ID", "@month", date.Value.Month, "@year", date.Value.Year);
            searchtx.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void invoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            detailsgrid.AutoGenerateColumns = false;
            float gt = 0;

            if (invoice.SelectedIndex != -1 && invoice.SelectedIndex != 0)
            {
                p.showspurchasedetails(Convert.ToInt32(invoice.SelectedValue.ToString()), detailsgrid,pidgv, productidgv, productnamegv, quantitygv, perunitpricegv, totalamountgv);
                foreach (DataGridViewRow row in detailsgrid.Rows)
                {
                    gt += Convert.ToSingle(row.Cells["totalamountgv"].Value.ToString());
                }
                grandtotal.Text = gt.ToString();
                gt = 0;
            }
        }

        private void detailsgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (e.ColumnIndex == 6)
                {

                    DataGridViewRow row = detailsgrid.Rows[e.RowIndex];
                    DialogResult dr = MessageBox.Show("Are you sure you want to delete " + row.Cells["productnamegv"].Value.ToString() + " because they also effects stocks", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    int q;
                    if (dr == DialogResult.Yes)
                       
                    {
                        using (TransactionScope de = new TransactionScope())
                        {
                            i.insertdeletedproducts(Convert.ToInt32(invoice.SelectedValue.ToString()),Convert.ToInt32(row.Cells["productidgv"].Value.ToString()),Convert.ToInt32(row.Cells["quantitygv"].Value.ToString()),ViewData.userid,DateTime.Today);
                            object ob = p.getproductsquantity(Convert.ToInt32(row.Cells["productidgv"].Value.ToString()));
                            if (ob != null)
                            {
                                q = Convert.ToInt32(ob);
                                q -= Convert.ToInt32(row.Cells["quantitygv"].Value.ToString());
                                u.updateStocks(Convert.ToInt32(row.Cells["productidgv"].Value.ToString()), q);
                                float total = Convert.ToSingle(grandtotal.Text) - Convert.ToSingle(row.Cells["totalamountgv"].Value.ToString());
                                grandtotal.Text = total.ToString();
                                d.Deleteproductsbyid(Convert.ToInt32(row.Cells["pidgv"].Value.ToString()),"pr_deleteproductsfrompid","@pid");
                                detailsgrid.Rows.Remove(row);
                                
                            }
                            de.Complete();

                        }
                    }
                }
            }
        }
    }
}
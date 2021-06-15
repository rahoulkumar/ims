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
    public partial class Sales : othersample
    {
        ViewData v = new ViewData();
        Insertion i = new Insertion();
        Regex reg = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");
        string[] product = new string[6];
        float grand = 0;
        public Sales()
        {
            InitializeComponent();
        }
        bool check;
        private void barcodes_Validating(object sender, CancelEventArgs e)
        {
            if (barcodes.Text != "")
            {
                finalgrand.Text = "";
                finaldiscount.Text = "";
                amountgiven.Text = "";
                change.Text = "";
                int quantitycount = 0, stockquantity = 0, numbercount = 0;
                product = v.getproductsbybarcode(barcodes.Text);
                foreach (DataGridViewRow row in salesgrid.Rows)
                {
                    if (product[0] == row.Cells["proidgv"].Value.ToString())
                    {
                        quantitycount = quantitycount + Convert.ToInt32(row.Cells["quantitygv"].Value.ToString());
                    }
                }
                stockquantity = Convert.ToInt32(v.getproductsquantity(Convert.ToInt32(product[0])));

                numbercount = stockquantity - quantitycount;
                if (numbercount <= 0)
                {

                }
                else
                {
                    if (salesgrid.RowCount == 0)
                    {
                        salesgrid.Rows.Add(Convert.ToInt32(product[0]), product[1], 1, Convert.ToSingle(product[3]),product[4], Convert.ToSingle(product[5]));
                    }
                    else
                    {
                        foreach (DataGridViewRow row in salesgrid.Rows)
                        {
                            if (row.Cells["proidgv"].Value.ToString() == product[0])
                            {
                                check = true;
                                break;

                            }
                            else
                            {
                                check = false;

                            }
                        }
                        if (check == true)
                        {
                            foreach (DataGridViewRow row in salesgrid.Rows)
                            {
                                if (row.Cells["proidgv"].Value.ToString() == product[0])
                                {
                                    float disc = 0;
                                    row.Cells["quantitygv"].Value = Convert.ToInt32(row.Cells["quantitygv"].Value.ToString()) + 1;
                                    if (row.Cells["discountgv"].Value.ToString() != null)
                                    {
                                        disc = Convert.ToSingle(row.Cells["discountgv"].Value.ToString()) + Convert.ToSingle(row.Cells["discountgv"].Value.ToString());
                                        row.Cells["discountgv"].Value = disc;
                                    }
                                    float total = Convert.ToSingle(row.Cells["perunitpricegv"].Value.ToString()) * Convert.ToInt32(row.Cells["quantitygv"].Value.ToString()) - Convert.ToSingle(row.Cells["discountgv"].Value.ToString());
                                    row.Cells["totalamountgv"].Value = total;
                                }

                            }
                        }
                        else
                        {
                            salesgrid.Rows.Add(Convert.ToInt32(product[0]), product[1], 1, Convert.ToSingle(product[3]),product[4], Convert.ToSingle(product[5]));
                        }
                    }

                    foreach (DataGridViewRow row in salesgrid.Rows)
                    {
                        grand += Convert.ToSingle(row.Cells["totalamountgv"].Value.ToString());
                    }
                    grandtotal.Text = Math.Ceiling(grand).ToString();
                    grand = 0;
                    barcodes.Focus();
                    barcodes.Text = "";
                }

            }
        }
        float gt, total, dis;
        private void salesgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (e.ColumnIndex == 6)
                {
                    finalgrand.Text = "";
                    finaldiscount.Text = "";
                    amountgiven.Text = "";
                    change.Text = "";
                    DataGridViewRow row = salesgrid.Rows[e.RowIndex];
                    int q = Convert.ToInt32(row.Cells["quantitygv"].Value.ToString());
                    if (q == 1)
                    {
                        gt = Convert.ToSingle(grandtotal.Text);
                        gt = gt - Convert.ToSingle(row.Cells["totalamountgv"].Value.ToString());
                        grandtotal.Text = gt.ToString();
                        salesgrid.Rows.Remove(row);
                    }
                    else if (q > 1)
                    {

                        q--;
                        row.Cells["quantitygv"].Value = q;
                        dis = Convert.ToSingle(row.Cells["discountgv"].Value.ToString()) - Convert.ToSingle(product[4]);
                        row.Cells["discountgv"].Value = dis;
                        total = Convert.ToSingle(row.Cells["quantitygv"].Value.ToString()) * Convert.ToSingle(row.Cells["perunitpricegv"].Value.ToString()) - dis;
                        row.Cells["totalamountgv"].Value = total;

                        foreach (DataGridViewRow item in salesgrid.Rows)
                        {
                            grand += Convert.ToSingle(row.Cells["totalamountgv"].Value.ToString());
                        }
                        grandtotal.Text = grand.ToString();
                        grand = 0;


                    }
                }

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkout_Click(object sender, EventArgs e)
        {
            double disc = 0, grand = 0;
            if (salesgrid.Rows.Count > 0)
            {
               
                foreach (DataGridViewRow row in salesgrid.Rows)
                {
                    disc += Math.Round(Convert.ToSingle(row.Cells["discountgv"].Value.ToString()),0);
                    grand += Convert.ToSingle(row.Cells["totalamountgv"].Value.ToString());
                }
                finalgrand.Text = Math.Round(grand, 0).ToString();
                finaldiscount.Text = disc.ToString();
            }
        }

        private void amountgiven_TextChanged(object sender, EventArgs e)
        {
            if (amountgiven.Text != "")
            {
                if (!reg.Match(amountgiven.Text).Success)
                {
                    amountgiven.Text = "";
                    amountgiven.Focus();
                }
                else
                {
                   
                }
            }
            else
            {
                change.Text = "";
            }
        }

        private void amountgiven_Validating(object sender, CancelEventArgs e)
        {
            if (amountgiven.Text != "" && grandtotal.Text!="")
            {
               
                
                if (!(Convert.ToSingle(grandtotal.Text) <= Convert.ToSingle(amountgiven.Text)))
                    {
                        amountgiven.Text = "";
                        change.Text = "";
                        amountgiven.Focus();
                    }
                else
                {
                    float amountgive = Convert.ToSingle(amountgiven.Text);
                    float returnamount = amountgive - Convert.ToSingle(grandtotal.Text);
                    change.Text = Math.Ceiling(returnamount).ToString();
                }
                }
                    
                }

        private void pay_Click(object sender, EventArgs e)
        {
            if (finalgrand.Text != "" && finaldiscount.Text != "" && paymenttype.SelectedIndex != -1 && amountgiven.Text != "" && change.Text!="")
            {
                DialogResult dr = MessageBox.Show("\n\t Total Amount: " + finalgrand.Text + "\n\tTotal Discount: " + finaldiscount.Text  + "\n\tAmount Given: " + amountgiven.Text + "\n\tAmount Return:"+change.Text +"\n\nAre you sure you want to submit sales?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    i.insertsales(salesgrid, "proidgv", "quantitygv","perunitpricegv","discountgv", ViewData.userid, DateTime.Now, Convert.ToSingle(finalgrand.Text), Convert.ToSingle(finaldiscount.Text), Convert.ToSingle(amountgiven.Text), Convert.ToSingle(change.Text), paymenttype.SelectedItem.ToString());
                    MainClass.enable_reset(payment);
                    salesgrid.Rows.Clear();
                    grandtotal.Text = "0.00";
                    SalesReport sc = new SalesReport();
                    sc.Show();
                }
                
            }
        }

        public override void view_Click(object sender, EventArgs e)
        {
            viewsalesinvoices vs = new viewsalesinvoices();
            MainClass.showWindow(vs, this, mdi.ActiveForm);
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            add.Enabled = false;
            edit.Enabled = false;
            searchtx.Enabled = false;
            delete.Enabled = false;
            
        }
        
            }
        }
    

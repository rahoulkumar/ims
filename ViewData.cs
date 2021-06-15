using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventorymanagementsystem
{
    class ViewData
    {
        public void showusers(DataGridView gv, DataGridViewColumn useridgv, DataGridViewColumn namegv, DataGridViewColumn usernamegv, DataGridViewColumn gendergv, DataGridViewColumn emailgv, DataGridViewColumn passwordgv, DataGridViewColumn phonegv, DataGridViewColumn statusgv, string data = null)
        {
            try
            {
                SqlCommand cmd;
                if (data == null)
                {
                    cmd = new SqlCommand("us_viewpeople", MainClass.con);
                }
                else
                {
                    cmd = new SqlCommand("us_searchpeople", MainClass.con);
                    cmd.Parameters.AddWithValue("@data", data);
                }
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable de = new DataTable();
                da.Fill(de);
                useridgv.DataPropertyName = de.Columns["ID"].ToString();
                namegv.DataPropertyName = de.Columns["Name"].ToString();
                usernamegv.DataPropertyName = de.Columns["Username"].ToString();
                gendergv.DataPropertyName = de.Columns["Gender"].ToString();
                emailgv.DataPropertyName = de.Columns["Email"].ToString();
                passwordgv.DataPropertyName = de.Columns["Password"].ToString();
                phonegv.DataPropertyName = de.Columns["Phone"].ToString();
                statusgv.DataPropertyName = de.Columns["Status"].ToString();

                gv.DataSource = de;
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.Showmessage(ex.Message, "Error", "Error");
            }
        }

        public void showCategory(DataGridView gv, DataGridViewColumn catidgv, DataGridViewColumn categorynamegv, DataGridViewColumn catstatusgv, string data = null)
        {
            try
            {
                SqlCommand cmd;
                if (data == null)
                {
                    cmd = new SqlCommand("ca_viewcategory", MainClass.con);
                }
                else
                {
                    cmd = new SqlCommand("ca_searchcategory", MainClass.con);
                    cmd.Parameters.AddWithValue("@data", data);
                }
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable de = new DataTable();
                da.Fill(de);
                catidgv.DataPropertyName = de.Columns["ID"].ToString();
                categorynamegv.DataPropertyName = de.Columns["Category"].ToString();
                catstatusgv.DataPropertyName = de.Columns["Status"].ToString();

                gv.DataSource = de;
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.Showmessage(ex.Message, "Error", "Error");
            }
        }

        public void getCategoryList(string procedure, ComboBox ca, string DisplayMember, string ValueMember)
        {
            try
            {
                ca.Items.Clear();
                ca.DataSource = null;
                SqlCommand cmd = new SqlCommand(procedure, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "Select Category" };
                dt.Rows.InsertAt(dr, 0);
                ca.DisplayMember = DisplayMember;
                ca.ValueMember = ValueMember;
                ca.DataSource = dt;
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.Showmessage(ex.Message, "Error", "Error");
            }
        }
        public void showProducts(DataGridView gv, DataGridViewColumn productidgv, DataGridViewColumn productnamegv, DataGridViewColumn brandnamegv, DataGridViewColumn productbarcodegv, DataGridViewColumn categorygv, DataGridViewColumn catidgv, DataGridViewColumn expirydategv, string data = null)
        {
            try
            {
                SqlCommand cmd;
                if (data == null)
                {
                    cmd = new SqlCommand("pr_viewproducts", MainClass.con);
                }
                else
                {
                    cmd = new SqlCommand("pr_searchproducts", MainClass.con);
                    cmd.Parameters.AddWithValue("@data", data);
                }
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable de = new DataTable();
                da.Fill(de);
                productidgv.DataPropertyName = de.Columns["ID"].ToString();
                productnamegv.DataPropertyName = de.Columns["Name"].ToString();
                brandnamegv.DataPropertyName = de.Columns["Brand"].ToString();
                productbarcodegv.DataPropertyName = de.Columns["Barcode"].ToString();
                expirydategv.DataPropertyName = de.Columns["Expiry"].ToString();
                categorygv.DataPropertyName = de.Columns["Category"].ToString();
                catidgv.DataPropertyName = de.Columns["Category ID"].ToString();
                gv.DataSource = de;
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.Showmessage(ex.Message, "Error", "Error");
            }
        }



        public void showsupplier(DataGridView gv, DataGridViewColumn suppidgv, DataGridViewColumn companygv, DataGridViewColumn addressgv, DataGridViewColumn contactpersongv, DataGridViewColumn contactnumbergv, DataGridViewColumn ntngv, DataGridViewColumn statusgv, string data = null)
        {
            try
            {
                SqlCommand cmd;
                if (data == null)
                {
                    cmd = new SqlCommand("su_viewsupplier", MainClass.con);
                }
                else
                {
                    cmd = new SqlCommand("su_searchsupplier", MainClass.con);
                    cmd.Parameters.AddWithValue("@data", data);
                }
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable de = new DataTable();
                da.Fill(de);
                suppidgv.DataPropertyName = de.Columns["ID"].ToString();
                companygv.DataPropertyName = de.Columns["Company"].ToString();
                addressgv.DataPropertyName = de.Columns["Address"].ToString();
                contactpersongv.DataPropertyName = de.Columns["Contact Person"].ToString();
                contactnumbergv.DataPropertyName = de.Columns["Contact Number"].ToString();
                ntngv.DataPropertyName = de.Columns["Ntn"].ToString();
                statusgv.DataPropertyName = de.Columns["Status"].ToString();

                gv.DataSource = de;
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.Showmessage(ex.Message, "Error", "Error");
            }
        }
        public void getSupplierList(string procedure, ComboBox su, string DisplayMember, string ValueMember)
        {
            try
            {
                su.Items.Clear();
                su.DataSource = null;
                SqlCommand cmd = new SqlCommand(procedure, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "Select Company" };
                dt.Rows.InsertAt(dr, 0);
                su.DisplayMember = DisplayMember;
                su.ValueMember = ValueMember;
                su.DataSource = dt;
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.Showmessage(ex.Message, "Error", "Error");
            }
        }

        public static int userid
        {
            get;
            private set;
        }
        public static string emp_name
        {
            get;
            private set;
        }
        public static string emp_pass
        {
            get;
            private set;
        }
        private static string user_name = null, pass_word = null;
        private static bool logincheck;
        public static bool getuser(string user, string pass)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("getusers", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@user", user);
                cmd.Parameters.AddWithValue("@pass", pass);
                MainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    logincheck = true;
                    while (dr.Read())
                    {
                        userid = Convert.ToInt32(dr["ID"].ToString());
                        emp_name = dr["Name"].ToString();
                        user_name = dr["Username"].ToString();
                        pass_word = dr["Password"].ToString();
                    }

                }

                else
                {
                    logincheck = false;
                    if (user_name != null && pass_word != null)
                    {
                        if (user_name != user && pass_word == pass)
                        {
                            MainClass.Showmessage("Invalid Username", "Error", "Error");
                        }
                        if (user_name == user && pass_word != pass)
                        {
                            MainClass.Showmessage("Invalid Password", "Error", "Error");
                        }
                        if (user_name != user && pass_word != pass)
                        {
                            MainClass.Showmessage("Invalid Username and Password", "Error", "Error");
                        }
                    }


                }
                MainClass.con.Close();
            }

            catch (Exception)
            {
                MainClass.con.Close();
                MainClass.Showmessage("Unable to Login", "Error", "Error");
            }
            return logincheck;
        }
        private string[] data = new string[6];
        public string[] getproductsbybarcode(string barcode)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("getproductsbybarcode", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@barcode", barcode);
                MainClass.con.Open();
                SqlDataReader de = cmd.ExecuteReader();
                if (de.HasRows)
                {
                    while (de.Read())
                    {
                        data[0] = de[0].ToString();
                        data[1] = de[1].ToString();
                        data[2] = de[2].ToString();
                        data[3] = de[3].ToString();
                        data[4] = de[4].ToString();
                        data[5] = de[5].ToString();

                    }
                }
                else
                {
                    Array.Clear(data, 0, data.Length);
                }
                MainClass.con.Close();
            }
            catch (Exception)
            {

                MainClass.con.Close();
                MainClass.Showmessage("No Products Available", "Error", "Error");
            }
            return data;
        }
        

        public void getinvoiceList(string procedure, ComboBox su, string DisplayMember, string ValueMember)
        {
            try
            {

                su.DataSource = null;
                SqlCommand cmd = new SqlCommand(procedure, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "Select Company" };
                dt.Rows.InsertAt(dr, 0);
                su.DisplayMember = DisplayMember;
                su.ValueMember = ValueMember;
                su.DataSource = dt;
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.Showmessage(ex.Message, "Error", "Error");
            }
        }

        public void getinvoiceListparam(string procedure, ComboBox su, string DisplayMember, string ValueMember, string param, object val1, string param2, object val2)
        {
            try
            {

                su.DataSource = null;
                SqlCommand cmd = new SqlCommand(procedure, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(param, val1);
                cmd.Parameters.AddWithValue(param2, val2);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "Select Company" };
                dt.Rows.InsertAt(dr, 0);
                su.DisplayMember = DisplayMember;
                su.ValueMember = ValueMember;
                su.DataSource = dt;
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.Showmessage(ex.Message, "Error", "Error");
            }
        }

        public void showspurchasedetails(int psid, DataGridView gv, DataGridViewColumn pidgv, DataGridViewColumn productidgv, DataGridViewColumn productnamegv, DataGridViewColumn quantitygv, DataGridViewColumn perunitpricegv, DataGridViewColumn totalamountgv, string data = null)
        {
            try
            {
                SqlCommand cmd;
                if (data == null)
                {
                    cmd = new SqlCommand("getdetails", MainClass.con);
                }
                else
                {
                    cmd = new SqlCommand("su_searchsupplier", MainClass.con);
                    cmd.Parameters.AddWithValue("@data", data);
                }
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ps", psid);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable de = new DataTable();
                da.Fill(de);
                pidgv.DataPropertyName = de.Columns["ID"].ToString();
                productidgv.DataPropertyName = de.Columns["Product id"].ToString();
                productnamegv.DataPropertyName = de.Columns["Product Name"].ToString();
                quantitygv.DataPropertyName = de.Columns["Quantity"].ToString();
                totalamountgv.DataPropertyName = de.Columns["Total Price"].ToString();
                perunitpricegv.DataPropertyName = de.Columns["Per Unit Price"].ToString();


                gv.DataSource = de;
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.Showmessage(ex.Message, "Error", "Error");
            }

        }
       
        public void showreport(string reportname,ReportDocument rc,CrystalReportViewer cr,string proc,string param1=null,object val1=null)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                if (param1 != null && val1 != null)
                {
                    cmd.Parameters.AddWithValue(param1, val1);
                }
                else
                {

                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                rc.Load(Application.StartupPath+"\\Reports\\"+reportname);
                rc.SetDataSource(dt);
                cr.ReportSource = rc;
                cr.RefreshReport();


            }
            catch(Exception ex)
            {
                
                MainClass.Showmessage(ex.Message, "Error", "Error");
            }
        }
        private object productcount = 0;
        public object getproductsquantity(int prid)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("getproductquantity", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proid", prid);
                MainClass.con.Open();
                productcount = cmd.ExecuteScalar();
                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.Showmessage(ex.Message, "Error", "Error");
            }
            return productcount;
        }

        public object getproductsquantitywithoutconnection(int prid)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("getproductquantity", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proid", prid);

                productcount = cmd.ExecuteScalar();

            }
            catch (Exception ex)
            {
                MainClass.Showmessage(ex.Message, "Error", "Error");
            }
            return productcount;
        }


        public void showstocks(DataGridView gv, DataGridViewColumn productidgv, DataGridViewColumn productnamegv, DataGridViewColumn productbarcodegv, DataGridViewColumn bpgv, DataGridViewColumn spgv, DataGridViewColumn expirygv, DataGridViewColumn categorygv, DataGridViewColumn quantitygv, DataGridViewColumn totalamountgv, DataGridViewColumn status)
        {
            try
            {

                SqlCommand cmd;
                cmd = new SqlCommand("st_viewstocks", MainClass.con);

                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable de = new DataTable();
                da.Fill(de);
                productidgv.DataPropertyName = de.Columns["ID"].ToString();
                productnamegv.DataPropertyName = de.Columns["Name"].ToString();
                productbarcodegv.DataPropertyName = de.Columns["Barcode"].ToString();
                bpgv.DataPropertyName = de.Columns["Buyingprice"].ToString();
                spgv.DataPropertyName = de.Columns["Sellingprice"].ToString();
                expirygv.DataPropertyName = de.Columns["Expiry"].ToString();
                categorygv.DataPropertyName = de.Columns["Category"].ToString();
                quantitygv.DataPropertyName = de.Columns["Available Stocks"].ToString();
                totalamountgv.DataPropertyName = de.Columns["Total Amount"].ToString();
                status.DataPropertyName = de.Columns["Status"].ToString();
                gv.DataSource = de;
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.Showmessage(ex.Message, "Error", "Error");
            }
        }
        public void showsproductsbycategory(int catid, DataGridView gv, DataGridViewColumn proidgv, DataGridViewColumn productnamegv, DataGridViewColumn buyingpricegv, DataGridViewColumn spgv, DataGridViewColumn discountgv, DataGridViewColumn margingv)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("getproductcategory", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@catid", catid);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable de = new DataTable();
                da.Fill(de);
                proidgv.DataPropertyName = de.Columns["Product id"].ToString();
                productnamegv.DataPropertyName = de.Columns["Product Name"].ToString();
                buyingpricegv.DataPropertyName = de.Columns["Buying Price"].ToString();
                spgv.DataPropertyName = de.Columns["selling price"].ToString();
                discountgv.DataPropertyName = de.Columns["discount"].ToString();
                margingv.DataPropertyName = de.Columns["margin"].ToString();

                gv.DataSource = de;
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.Showmessage(ex.Message, "Error", "Error");
            }

        }
        private bool checkpp;
        public bool checkproductprice(int proid)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("checkproductpriceexist", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proid", proid);
                MainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    checkpp = true;
                }
                else
                {
                    checkpp = false;
                }
                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.Showmessage(ex.Message, "Error", "Error");
            }
            return checkpp;
        }

        public void showDailysales(DateTime date, DataGridView gv, DataGridViewColumn salesidgv, DataGridViewColumn useridgv, DataGridViewColumn usergv, DataGridViewColumn totamountgv, DataGridViewColumn totdiscountgv, DataGridViewColumn amountgivengv, DataGridViewColumn amountreturngv)
        {
            try
            {

                 SqlCommand cmd = new SqlCommand("getdailysales", MainClass.con);   
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@date", date);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable de = new DataTable();
                da.Fill(de);
                salesidgv.DataPropertyName = de.Columns["Sales id"].ToString();
                useridgv.DataPropertyName = de.Columns["user id"].ToString();
                usergv.DataPropertyName = de.Columns["User"].ToString();
                totamountgv.DataPropertyName = de.Columns["Total Amount"].ToString();
                totdiscountgv.DataPropertyName = de.Columns["Total discount"].ToString();
                amountgivengv.DataPropertyName = de.Columns["Amount Given"].ToString();
                amountreturngv.DataPropertyName = de.Columns["Amount return"].ToString();
               
                
                gv.DataSource = de;
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.Showmessage(ex.Message, "Error", "Error");
            }
        }
        private string[] datas = new string[3];
        public string[] getproductsbybarcodesecond(string barcode)
        {
            try
            {

                SqlCommand cmd2 = new SqlCommand("getproductsbybarcode2", MainClass.con);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.AddWithValue("@barcode", barcode);
                MainClass.con.Open();
                SqlDataReader dc = cmd2.ExecuteReader();
                if (dc.HasRows)
                {
                    while (dc.Read())
                    {
                        datas[0] = dc[0].ToString();
                        datas[1] = dc[1].ToString();
                        datas[2] = dc[2].ToString();


                    }
                }
                else
                {

                }
                MainClass.con.Close();
            }
            catch (Exception)
            {

                MainClass.con.Close();
                MainClass.Showmessage("No Products Available", "Error", "Error");
            }
            return datas;
        }


        public void showdetailbysalid(int salesid,DataGridView gv, DataGridViewColumn saleidgv, DataGridViewColumn barcodegv, DataGridViewColumn productgv, DataGridViewColumn quantitygv, DataGridViewColumn totalamountgv, DataGridViewColumn totaldiscountgv, DataGridViewColumn amountgivengv, DataGridViewColumn amountreturngv, DataGridViewColumn dategv, DataGridViewColumn pricegv, DataGridViewColumn perproductdiscountgv, DataGridViewColumn perproducttotalgv, DataGridViewColumn usergv, DataGridViewColumn paymentgv, DataGridViewColumn proidgv)
        {

        
            try
            {

                SqlCommand cmd = new SqlCommand("getsalesreceiptbysaleid", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@saleid", salesid);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable de = new DataTable();
                da.Fill(de);
                saleidgv.DataPropertyName = de.Columns["Sales ID"].ToString();
                barcodegv.DataPropertyName = de.Columns["Barcode"].ToString();
                productgv.DataPropertyName = de.Columns["Product Name"].ToString();
                quantitygv.DataPropertyName = de.Columns["Quantity"].ToString();
                totalamountgv.DataPropertyName = de.Columns["Total Amount"].ToString();
                totaldiscountgv.DataPropertyName = de.Columns["Total Discount"].ToString();
                amountgivengv.DataPropertyName = de.Columns["Amount Given"].ToString();
                amountreturngv.DataPropertyName = de.Columns["Amount Return"].ToString();
                dategv.DataPropertyName = de.Columns["Date"].ToString();
                pricegv.DataPropertyName = de.Columns["Product Price"].ToString();
                perproductdiscountgv.DataPropertyName = de.Columns["Per Product Discount"].ToString();
                perproducttotalgv.DataPropertyName = de.Columns["Per Product Total"].ToString();
                usergv.DataPropertyName = de.Columns["User"].ToString();
                paymentgv.DataPropertyName = de.Columns["Paytype"].ToString();
                proidgv.DataPropertyName = de.Columns["Product id"].ToString();
                

                gv.DataSource = de;
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.Showmessage(ex.Message, "Error", "Error");
            }
        }
    }
}


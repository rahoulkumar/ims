using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace inventorymanagementsystem
{
    class Insertion
    {
        ViewData v = new ViewData();
        Updation u = new Updation();

        public void insertUsers(string name, string gender, string username, string Email, string password, string phone, Int16 status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("us_insertpeople", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@email", Email);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@status", status);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.Showmessage("Data Inserted Successfully in the System", "Success", "Success");

            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.Showmessage(ex.Message, "Error", "Error");
            }
        }

        public void insertCategory(string catname, Int16 catstatus)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ca_insertcategory", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", catname);
                cmd.Parameters.AddWithValue("@status", catstatus);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.Showmessage("Data Inserted Successfully in the System", "Success", "Success");

            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.Showmessage(ex.Message, "Error", "Error");
            }
        }
        public void insertProducts(string productname, string brand, string barcode, int catid, DateTime? expiry = null)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("pr_insertproducts", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", productname);
                cmd.Parameters.AddWithValue("@brand", brand);
                cmd.Parameters.AddWithValue("@barcode", barcode);
                if (expiry == null)
                {
                    cmd.Parameters.AddWithValue("@expiry", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@expiry", expiry);
                }
                cmd.Parameters.AddWithValue("@catid", catid);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.Showmessage("Data Inserted Successfully in the System", "Success", "Success");

            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.Showmessage(ex.Message, "Error", "Error");
            }
        }
        public void insertSupplier(string company, string address, string contactperson, string contactnumber, string ntn, Int16 status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("su_insertsupplier", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@company", company);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@contactperson", contactperson);
                cmd.Parameters.AddWithValue("@contactnumber", contactnumber);
                cmd.Parameters.AddWithValue("@ntn", ntn);
                cmd.Parameters.AddWithValue("@status", status);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.Showmessage("Data Inserted Successfully in the System", "Success", "Success");

            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.Showmessage(ex.Message, "Error", "Error");
            }

        }
        private int purchaseid;
        public int insertpurchase(DateTime date, int doneby, int suppid)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("purchaseinsert", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@doneby", doneby);
                cmd.Parameters.AddWithValue("@supp_id", suppid);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                cmd.CommandText = "purchaselastid";
                cmd.Parameters.Clear();
                purchaseid = Convert.ToInt32(cmd.ExecuteScalar());
                MainClass.con.Close();

            }
            catch (Exception)
            {
                MainClass.con.Close();

            }
            return purchaseid;
        }
        private int count;
        public int insertpurchasedetails(int purchaseinid, int proid, int quantity, float total)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("purchasedetails", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@purchaseid", purchaseinid);
                cmd.Parameters.AddWithValue("@proid", proid);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@totalprice", total);
                MainClass.con.Open();
                count = cmd.ExecuteNonQuery();
                MainClass.con.Close();

            }
            catch (Exception)
            {
                MainClass.con.Close();

            }
            return count;
        }


        public void insertStocks(int proid, int quantity)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insertstocks", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proid", proid);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();


            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.Showmessage(ex.Message, "Error", "Error");
            }

        }


        public void insertdeletedproducts(int psid, int proid, int quan, int userid, DateTime date)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("userstrackingdatainsert", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ps", psid);
                cmd.Parameters.AddWithValue("@userid", userid);
                cmd.Parameters.AddWithValue("@prid", proid);
                cmd.Parameters.AddWithValue("@pid_proquan", quan);
                cmd.Parameters.AddWithValue("@deletedate", date);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
               

            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.Showmessage(ex.Message, "Error", "Error");
            }
        }

        public void insertpriceproducts(int proid, float buyingprice)
        {
            try
            {
                
                SqlCommand cmd = new SqlCommand("insertproductprice", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prid", proid);
                cmd.Parameters.AddWithValue("@buyingprice", buyingprice);
                
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();


            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.Showmessage(ex.Message, "Error", "Error");
            }
        }
        int salecount = 0;
        int salesid;
        public void insertsales(DataGridView gv, string proidgv,string quangv,string perunitpricegv,string discountgv,int doneby, DateTime date, float totalamount, float totaldiscount, float amountgiven, float amountreturn,String paytype)
        {
            try
            {
                using (TransactionScope de = new TransactionScope())
                {
                    SqlCommand cmd = new SqlCommand("insertsales", MainClass.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@doneby", doneby);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@totalamount", totalamount);
                    cmd.Parameters.AddWithValue("@totaldiscount", totaldiscount);
                    cmd.Parameters.AddWithValue("@amountgiven", amountgiven);
                    cmd.Parameters.AddWithValue("@amountreturn", amountreturn);
                    if (paytype == "Cash")
                    {
                        cmd.Parameters.AddWithValue("@paytype", 0);
                    }
                    else if (paytype == "Debit Card")
                    {
                        cmd.Parameters.AddWithValue("@paytype", 1);
                    }
                    else if (paytype == "Credit Card")
                    {
                        cmd.Parameters.AddWithValue("@paytype", 2);
                    }  
              
                    MainClass.con.Open();
                    salecount = cmd.ExecuteNonQuery();
                    if (salecount > 0)
                    {
                        SqlCommand cmd2 = new SqlCommand("getsalesid", MainClass.con);
                        cmd2.CommandType = CommandType.StoredProcedure;
                        salesid = Convert.ToInt32(cmd2.ExecuteScalar());
                        foreach (DataGridViewRow row in gv.Rows)
                        {
                            SqlCommand cmd3 = new SqlCommand("insertsalesdetails", MainClass.con);
                            cmd3.CommandType = CommandType.StoredProcedure;
                            cmd3.Parameters.AddWithValue("@salId", salesid);
                            cmd3.Parameters.AddWithValue("@proid", Convert.ToInt32(row.Cells[proidgv].Value.ToString()));
                            cmd3.Parameters.AddWithValue("@quan", Convert.ToInt32(row.Cells[quangv].Value.ToString()));
                            cmd3.Parameters.AddWithValue("@sellingprice", Convert.ToSingle(row.Cells[perunitpricegv].Value.ToString()));
                            cmd3.Parameters.AddWithValue("@discount", Convert.ToSingle(row.Cells[discountgv].Value.ToString()));
                           
                            cmd3.ExecuteNonQuery();
                            int stockproduct=Convert.ToInt32(v.getproductsquantitywithoutconnection(Convert.ToInt32(row.Cells[proidgv].Value.ToString())));
                            int currentquantity=Convert.ToInt32(row.Cells[quangv].Value.ToString());
                            int finalQuantity = stockproduct - currentquantity;
                            u.updateStockswithoutconnection(Convert.ToInt32(row.Cells[proidgv].Value.ToString()), finalQuantity);
                        }

                    }
                    MainClass.con.Close();
                    MainClass.Showmessage("Data Inserted Successfully in the System", "Success", "Success");


                    de.Complete();
                }
               
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.Showmessage(ex.Message, "Error", "Error");
            }
           
        }

        int x = 0;
        public int insertReturnRefund(int salid, DateTime date, int doneby, int proid,int quantity, float amount)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insertreturnrefund", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@salid", salid);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@doneby", doneby);
                cmd.Parameters.AddWithValue("@proid", proid);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@amount", amount);
                MainClass.con.Open();
                x=cmd.ExecuteNonQuery();
                MainClass.con.Close();
                

            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.Showmessage(ex.Message, "Error", "Error");
            }
            return x;
        }
    }
}

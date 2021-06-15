using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventorymanagementsystem
{
    class Updation
    {
        public void updateUsers(int id, string name, string gender, string username, string Email, string password, string phone, Int16 status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("us_updatepeople", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@email", Email);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@id", id);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.Showmessage("Data Updated Successfully in the System", "Success", "Success");

            }
            catch (Exception e)
            {
                MainClass.con.Close();
                MainClass.Showmessage(e.Message, "Error", "Error");
            }
        }
        public void updateCategory(int id, string name, Int16 status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ca_updatecategory", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@id", id);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.Showmessage("Data Updated Successfully in the System", "Success", "Success");

            }
            catch (Exception e)
            {
                MainClass.con.Close();
                MainClass.Showmessage(e.Message, "Error", "Error");
            }
        }

        public void updateProducts(int proid, string productname, string brand, string barcode, int catid, DateTime? expiry = null)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("pr_updateproduct", MainClass.con);
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
                cmd.Parameters.AddWithValue("@proid", proid);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.Showmessage("Data Updated Successfully in the System", "Success", "Success");

            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.Showmessage(ex.Message, "Error", "Error");
            }
        }
        public void updateSupplier(int supid, string company, string address, string contactperson, string contactnumber,string ntn, Int16 status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("su_updatesupplier", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@company", company);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@contactperson", contactperson);
                cmd.Parameters.AddWithValue("@contactnumber", contactnumber);
                cmd.Parameters.AddWithValue("@ntn", ntn);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@suppid", supid);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.Showmessage("Data Updated Successfully in the System", "Success", "Success");

            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.Showmessage(ex.Message, "Error", "Error");
            }
        }

        public void updateStocks(int proid, int quantity)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("updatestocks", MainClass.con);
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

        public void updateStockswithoutconnection(int proid, int quantity)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("updatestocks", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proid", proid);
                cmd.Parameters.AddWithValue("@quantity", quantity);
               
                cmd.ExecuteNonQuery();
              
            }
            catch (Exception ex)
            {
                MainClass.Showmessage(ex.Message, "Error", "Error");
                
            }

        }

        public void updatequantityinsalesdetails(int quantity, int saleid)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("updatequantityinsalesdetails", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@quan", quantity);
                cmd.Parameters.AddWithValue("@saleid", saleid);
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

        public void updatepriceproducts(int proid, float buyingprice, float sellingprice=0, float discount=0, float margin=0)
        {
            try
            {
                SqlCommand cmd;
                    if(sellingprice==0 && margin==0 && discount==0){
                    cmd = new SqlCommand("updateproductprice1", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prid", proid);
                cmd.Parameters.AddWithValue("@buyingprice", buyingprice);
                    }
                    else
                    {
                        cmd = new SqlCommand("updateproductprice", MainClass.con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@prid", proid);
                        cmd.Parameters.AddWithValue("@buyingprice", buyingprice);
                        cmd.Parameters.AddWithValue("@sellingprice", sellingprice);
                        cmd.Parameters.AddWithValue("@discount", discount);
                        cmd.Parameters.AddWithValue("@margin", margin);
                    }
              
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
       
    }
}
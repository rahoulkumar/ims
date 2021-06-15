using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventorymanagementsystem
{
    class Deletion
    {
        public void DeleteUsers(object id, string procedure, string paramater)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(procedure, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(paramater, id);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.Showmessage("Data Deleted Successfully in the System", "Success", "Success");

            }
            catch (Exception e)
            {
                MainClass.con.Close();
                MainClass.Showmessage(e.Message, "Error", "Error");
            }
        }
        public void DeleteCategory(object id, string procedure, string paramater)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(procedure, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(paramater, id);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.Showmessage("Data Deleted Successfully in the System", "Success", "Success");

            }
            catch (Exception e)
            {
                MainClass.con.Close();
                MainClass.Showmessage(e.Message, "Error", "Error");
            }
        }

        public void DeleteProducts(object id, string procedure, string paramater)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(procedure, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(paramater, id);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.Showmessage("Data Deleted Successfully in the System", "Success", "Success");

            }
            catch (Exception e)
            {
                MainClass.con.Close();
                MainClass.Showmessage(e.Message, "Error", "Error");
            }
        }

        public void DeleteSupplier(object id, string procedure, string paramater)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(procedure, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(paramater, id);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.Showmessage("Data Deleted Successfully in the System", "Success", "Success");

            }
            catch (Exception e)
            {
                MainClass.con.Close();
                MainClass.Showmessage(e.Message, "Error", "Error");
            }
        }

        public void Deleteproductsbyid(object id, string procedure, string paramater)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(procedure, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(paramater, id);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.Showmessage("Data Deleted Successfully in the System", "Success", "Success");

            }
            catch (Exception e)
            {
                MainClass.con.Close();
                MainClass.Showmessage(e.Message, "Error", "Error");
            }
        }

    }
}

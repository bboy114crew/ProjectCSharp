using GameShop.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShop.DAL
{
    class AccountDB
    {
        static public DataTable getDataTable(string sql)
        {
            SqlConnection con = new SqlConnection(DBContext.url());
            SqlCommand command = new SqlCommand(sql, con);
            SqlDataAdapter adapt = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            return ds.Tables[0];
        }
        static public bool GetAccountByUsername(string username,string password)
        {
            string sql = "SELECT * FROM [Accounts] WHERE Username = "+username +" AND Password = "+password;
            DataTable dt = getDataTable(sql);
            if (dt.Rows == null)
                return false;
            else
                return true;
        }
        static public bool duplicateAccount(string username)
        {
            string sql = "SELECT * FROM [Accounts] WHERE Username = @username";
            DataTable dt = getDataTable(sql);
            if (dt.Rows == null)
                return true;
            else
                return false;
        }
        static public void register(string cusname,string email,string address,string phone,string username,string password)
        {
            string sql = "INSERT INTO [Customer]([CustomerName],[Email],[Address],[Phone]) VALUES(@cname,@mail,@address,@phone)";
            SqlConnection con = new SqlConnection(DBContext.url());
            con.Open();
            SqlCommand com = new SqlCommand(sql, con);
            SqlParameter p1 = new SqlParameter("@cname", cusname);
            SqlParameter p2 = new SqlParameter("@mail", email);
            SqlParameter p3 = new SqlParameter("@address", address);
            SqlParameter p4 = new SqlParameter("@phone", phone);
            com.Parameters.Add(p1);
            com.Parameters.Add(p2);
            com.Parameters.Add(p3);
            com.Parameters.Add(p4);
            com.ExecuteNonQuery();
            int cid = Convert.ToUInt16(com.ExecuteScalar());
            con.Close();
            registerAccount(username, password,cid);

        }
        static public void registerAccount(string username,string password,int cid)
        {
            string sql = "INSERT INTO [Accounts]([Username],[Password],[CustomerID]) VALUES ( @username, @password,@cusid)";
            SqlConnection con = new SqlConnection(DBContext.url());
            con.Open();
            SqlCommand com1 = new SqlCommand(sql, con);
            SqlParameter p4 = new SqlParameter("@username", username);
            SqlParameter p5 = new SqlParameter("@password", password);
            SqlParameter p6 = new SqlParameter("@cusid", cid);
            com1.Parameters.Add(p4);
            com1.Parameters.Add(p5);
            com1.Parameters.Add(p6);
            com1.ExecuteNonQuery();
            con.Close();

        }
    }
}

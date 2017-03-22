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

        static public bool GetAccountByUsername(string username,string password)
        {
            string sql = "SELECT * FROM [Accounts] WHERE Username = @username AND Password = @pass";
            SqlConnection connection = DBContext.openConnection();
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@pass", password);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                return true;
            }
            else
                return false;

        }
        static public bool duplicateAccount(string username)
        {
            string sql = "SELECT * FROM [Accounts] WHERE Username = @username";
            SqlConnection connection = DBContext.openConnection();
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            command.Parameters.AddWithValue("@username", username);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                return false;
            }
            else
                return true;
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
            int cid = Convert.ToInt32(com.ExecuteScalar());
            con.Close();
            registerAccount(username, password,cid);

        }
        static public void registerAccount(string username,string password,int cid)
        {
            string sql = "INSERT INTO [Accounts]( [Username] , [Password], [CustomerID] ) VALUES ( @username, @password , @cusid ) ";
            SqlConnection con = new SqlConnection(DBContext.url());
            con.Open();
            SqlCommand com1 = new SqlCommand(sql, con);
            SqlParameter p4 = new SqlParameter("@username", username);
            SqlParameter p5 = new SqlParameter("@password", password);
            SqlParameter p6 = new SqlParameter("@cusid", 6);
            com1.Parameters.Add(p4);
            com1.Parameters.Add(p5);
            com1.Parameters.Add(p6);
            com1.ExecuteNonQuery();
            con.Close();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShop.DAL
{
    class CustomerDB
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
        static public int getCustomerID(string username)
        {
            string sql = "select * from Accounts WHERE Username = @username";
            SqlConnection connection = DBContext.openConnection();
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            command.Parameters.AddWithValue("@username", username);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                return Convert.ToInt32(dr["CustomerID"].ToString());
            }
            return 1;
        }
    }
}

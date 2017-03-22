using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShop.DAL
{
    class CheckoutDB
    {
        static public int insert(int cusid)
        {
            string sql = "INSERT INTO [dbo].[Orders]([CustomerID], OrderDate) output inserted.OrderID VALUES (@customerID, GETDATE())";
            SqlConnection con = new SqlConnection(DBContext.url());
            con.Open();
            SqlCommand com = new SqlCommand(sql, con);
            SqlParameter p1 = new SqlParameter("@customerID", cusid);
            com.Parameters.Add(p1);
            com.ExecuteNonQuery();
            int orderid = Convert.ToUInt16(com.ExecuteScalar());
            con.Close();
            return orderid;

        }
        static public void insertOrderDetail(int orderid,int proid, int quantity, float price)
        {
            string sql = "INSERT INTO [dbo].[OrderDetails]([OrderID],[ProductID],[Quantity],[UnitPrice]) VALUES (@orderID, @productID, @quantity, @unitPrice) ";
            SqlConnection con = new SqlConnection(DBContext.url());
            con.Open();
            SqlCommand com1 = new SqlCommand(sql, con);
            SqlParameter p5 = new SqlParameter("@orderID", orderid);
            SqlParameter p6 = new SqlParameter("@productID", proid);
            SqlParameter p7 = new SqlParameter("@quantity", orderid);
            SqlParameter p8 = new SqlParameter("@unitPrice", price);
            com1.Parameters.Add(p5);
            com1.Parameters.Add(p6);
            com1.Parameters.Add(p7);
            com1.Parameters.Add(p8);
            com1.ExecuteNonQuery();
            con.Close();

        }
    }
}

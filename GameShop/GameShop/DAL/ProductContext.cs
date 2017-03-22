using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameShop.Model;

namespace GameShop.DAL
{
    class ProductContext
    {
        public List<Products> getByCategoryID(int cid)
        {
            SqlCommand command;
            List<Products> ps = new List<Products>();
            SqlConnection connection = null;
            SqlDataReader data = null;
            string sql = "SELECT [ProductID], [ProductName], [Description], " +
                         "[Price], [Sale], [CategoryID], [SupplierID], [PublishDate], " +
                         "[Rating] FROM [Products] WHERE CategoryID = @param";
            try
            {
                connection = DBContext.openConnection();
                command = connection.CreateCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = sql;
                command.Parameters.AddWithValue("@param", cid);
                data = command.ExecuteReader();
                while (data.Read())
                {
                    int id = Convert.ToInt16(data["ProductID"]);
                    string name = Convert.ToString(data["ProductName"]);
                    string des = Convert.ToString(data["Description"]);
                    double price = Convert.ToDouble(data["Price"]);
                    float sale = (float) data["Sale"];
                    int cateID = Convert.ToInt16(data["CategoryID"]);
                    int spID = Convert.ToInt16(data["SupplierID"]);
                    DateTime date = Convert.ToDateTime(data["PublishDate"]);
                    int rate = Convert.ToInt16(data["Rating"]);
                    Products p = new Products(id, name, des, price, sale, date, rate, new Categories(1, "") , new Suppliers(1, ""));
                    ps.Add(p);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            finally
            {
                data.Close();
                DBContext.closeConnection(connection);
            }
            return ps;
        }

        public List<Products> getByID(int pid)
        {
            SqlCommand command;
            List<Products> ps = new List<Products>();
            SqlConnection connection = null;
            SqlDataReader data = null;
            string sql = "SELECT [ProductID], [ProductName], [Description], " +
                         "[Price], [Sale], [CategoryID], [SupplierID], [PublishDate], " +
                         "[Rating] FROM [Products] WHERE ProductID = @param";
            try
            {
                connection = DBContext.openConnection();
                command = connection.CreateCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = sql;
                command.Parameters.AddWithValue("@param", pid);
                data = command.ExecuteReader();
                while (data.Read())
                {
                    int id = Convert.ToInt16(data["ProductID"]);
                    string name = Convert.ToString(data["ProductName"]);
                    string des = Convert.ToString(data["Description"]);
                    double price = Convert.ToDouble(data["Price"]);
                    float sale = (float)data["Sale"];
                    int cateID = Convert.ToInt16(data["CategoryID"]);
                    int spID = Convert.ToInt16(data["SupplierID"]);
                    DateTime date = Convert.ToDateTime(data["PublishDate"]);
                    int rate = Convert.ToInt16(data["Rating"]);
                    Products p = new Products(id, name, des, price, sale, date, rate, new Categories(1, ""), new Suppliers(1, ""));
                    ps.Add(p);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            finally
            {
                data.Close();
                DBContext.closeConnection(connection);
            }
            return ps;
        }

    }
}

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
                    int sale = Convert.ToInt16(data["Sale"]);
                    int cateID = Convert.ToInt16(data["CategoryID"]);
                    int spID = Convert.ToInt16(data["SupplierID"]);
                    DateTime date = Convert.ToDateTime(data["PublishDate"]);
                    int rate = Convert.ToInt16(data["Rating"]);
                    Products p = new Products(id, name, des, price, sale, date, rate, new Categories(cateID, "") , new Suppliers(spID, ""));
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
                    int sale = Convert.ToInt16(data["Sale"]);
                    int cateID = Convert.ToInt16(data["CategoryID"]);
                    int spID = Convert.ToInt16(data["SupplierID"]);
                    DateTime date = Convert.ToDateTime(data["PublishDate"]);
                    int rate = Convert.ToInt16(data["Rating"]);
                    Products p = new Products(id, name, des, price, sale, date, rate, new Categories(cateID, ""), new Suppliers(spID, ""));
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

        public List<Products> searchProduct(string search, int cid)
        {
            SqlCommand command;
            List<Products> ps = new List<Products>();
            SqlConnection connection = null;
            SqlDataReader data = null;
            string sql = "SELECT [ProductID], [ProductName], [Description], " +
                         "[Price], [Sale], p.SupplierID, c.CategoryID, c.CategoryName, s.CompanyName, " +
                         "[PublishDate], [Rating] FROM [Products] p JOIN Categories c ON p.CategoryID = c.CategoryID " +
                         "JOIN Suppliers s ON s.SupplierID = p.SupplierID " +
                         "WHERE c.CategoryID = @param2 AND ( p.ProductName LIKE '%'+@param1+'%' OR s.CompanyName LIKE '%'+@param3+'%') ";
            try
            {
                connection = DBContext.openConnection();
                command = connection.CreateCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = sql;
                command.Parameters.AddWithValue("@param1", search);
                command.Parameters.AddWithValue("@param2", cid);
                command.Parameters.AddWithValue("@param3", search);
                data = command.ExecuteReader();
                while (data.Read())
                {
                    int id = Convert.ToInt16(data["ProductID"]);
                    string name = Convert.ToString(data["ProductName"]);
                    string des = Convert.ToString(data["Description"]);
                    double price = Convert.ToDouble(data["Price"]);
                    int sale = Convert.ToInt16(data["Sale"]);
                    int cateID = Convert.ToInt16(data["CategoryID"]);
                    int spID = Convert.ToInt16(data["SupplierID"]);
                    string cateName = Convert.ToString(data["CategoryName"]);
                    string spName = Convert.ToString(data["CompanyName"]);
                    DateTime date = Convert.ToDateTime(data["PublishDate"]);
                    int rate = Convert.ToInt16(data["Rating"]);
                    Products p = new Products(id, name, des, price, sale, date, rate, new Categories(cateID, cateName), new Suppliers(spID, spName));
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

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
        public List<Products> getByCategoryID()
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
                data = command.ExecuteReader();
                while (data.Read())
                {
                    int id = Convert.ToInt16(data["ProductID"]);
                    string name = Convert.ToString(data["ProductName"]);
                    string des = Convert.ToString(data["Description"]);
                    double price = Convert.ToDouble(data["Price"]);
                    Products p = new Products();
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

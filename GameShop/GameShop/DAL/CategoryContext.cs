using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameShop.Model;

namespace GameShop.DAL
{
    class CategoryContext
    {
        public List<Categories> getAll()
        {
            SqlCommand command;
            List<Categories> cs = new List<Categories>();
            SqlConnection connection = null;
            SqlDataReader data = null;
            string sql = "SELECT [CategoryID], [CategoryName] FROM [Categories]";
            try
            {
                connection = DBContext.openConnection();
                command = connection.CreateCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = sql;
                data = command.ExecuteReader();
                while (data.Read())
                {
                    int id = Convert.ToInt16(data["CategoryID"]);
                    string name = Convert.ToString(data["CategoryName"]);
                    Categories c = new Categories(id, name);
                    cs.Add(c);
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
            return cs;
        }
    }
}

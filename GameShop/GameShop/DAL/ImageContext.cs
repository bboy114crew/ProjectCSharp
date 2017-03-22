using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameShop.Model;

namespace GameShop.DAL
{
    class ImageContext
    {
        public Images getByProductID(int pid)
        {
            SqlCommand command;
            Images img = null;
            SqlConnection connection = null;
            SqlDataReader data = null;
            string sql = "SELECT TOP(1) [ImageID], [ProductID], [ImageURL] FROM [Images] WHERE ProductID = @param";
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
                    int id = Convert.ToInt16(data["ImageID"]);
                    string url = Convert.ToString(data["ImageURL"]);
                    img = new Images(id, null, url);
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
            return img;
        }
    }
}

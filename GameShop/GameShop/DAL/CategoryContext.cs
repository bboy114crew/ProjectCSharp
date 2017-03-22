using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShop.DAL
{
    class CategoryContext
    {
        public DataTable getAll()
        {
            SqlConnection connection = DBContext.openConnection();
            string sql = "SELECT [CategoryID], [CategoryName] FROM [Categories]"; 
            SqlCommand com = new SqlCommand(sql, connection); 
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); 
            DataTable dt = new DataTable(); 
            da.Fill(dt);  
            DBContext.closeConnection(connection);  
            return dt;
        }
    }
}

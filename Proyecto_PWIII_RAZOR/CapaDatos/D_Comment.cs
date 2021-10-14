using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace DataLayer
{
    public class D_Comment
    {
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=D:\GitHub\Proyecto_WebIII_razor\Proyecto_PWIII_RAZOR\Proyecto_PWIII_RAZOR\App_Data\DBPrograWebIII.mdf;Integrated Security = True");
        public DataTable ShowComment()
        {
            DataTable search = new DataTable();
            SqlCommand command = new SqlCommand(@"SELECT Description, CommentType, StudentName FROM Comment", connection)
            {
                CommandType = CommandType.Text
            };

            connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(search);
            connection.Close();
            return search;
        }
    }
}

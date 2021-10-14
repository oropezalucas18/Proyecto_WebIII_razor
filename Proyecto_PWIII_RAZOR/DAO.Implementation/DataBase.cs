using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DAO.Implementation
{
    class DataBase
    {
        static string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=D:\GitHub\Proyecto_WebIII_razor\Proyecto_PWIII_RAZOR\Proyecto_PWIII_RAZOR\App_Data\DBPrograWebIII.mdf;Integrated Security = True";
        public static SqlCommand CreateBasicCommand()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            return command;
        }
        public static SqlCommand CreateBasicCommand(string query)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query);
            command.Connection = connection;
            return command;
        }
        public static int ExecuteBasicCommand(SqlCommand command)
        {
            try
            {
                command.Connection.Open();
                return command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                command.Connection.Close();
            }
        }
        public static DataTable ExecuteDataTableCommand(SqlCommand command)
        {
            DataTable res = new DataTable();
            try
            {
                command.Connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(res);

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                command.Connection.Close();
            }
            return res;
        }
        public static SqlDataReader ExecuteDataReaderCommand(SqlCommand command)
        {
            SqlDataReader dr = null;
            try
            {
                command.Connection.Open();
                dr = command.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dr;
        }
    }
}

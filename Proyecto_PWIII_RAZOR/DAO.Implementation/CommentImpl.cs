using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO.Model;
using DAO.Interfaces;
using System.Data.SqlClient;
using System.Data;

namespace DAO.Implementation
{
    public class CommentImpl : IComment
    {
        public int Delete(Comment t)
        {
            string query = @"UPDATE Comment SET status=0
                        WHERE CommentID = @CommentID";
            try
            {
                SqlCommand command = DataBase.CreateBasicCommand(query);
                command.Parameters.AddWithValue("@CommentID", t.CommentID);
                return DataBase.ExecuteBasicCommand(command);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Comment Get(byte id)
        {
            Comment t = null;
            string query = @"SELECT Description , StudentName , CommentType
                            FROM Comment WHERE CommentID=@CommentID";
            SqlCommand command = null;
            SqlDataReader dr = null;
            try
            {
                command = DataBase.CreateBasicCommand(query);
                command.Parameters.AddWithValue("@CommentID", id);
                dr = DataBase.ExecuteDataReaderCommand(command);
                while (dr.Read())
                {

                    t = new Comment(byte.Parse(dr[0].ToString()),dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                command.Connection.Close();
                dr.Close();
            }
            return t;
        }
        public int Insert(Comment t)
        {
            int res = 0;
            string query = "INSERT INTO Comment (Description, StudentName, CommentType) " +
                "VALUES (@Description, @StudentName, @CommentType)";
            try
            {
                SqlCommand command = DataBase.CreateBasicCommand(query);
                command.Parameters.AddWithValue("@Description", t.Description);
                command.Parameters.AddWithValue("@StudentName", t.StudentName);
                command.Parameters.AddWithValue("@CommentType", t.CommentType);
                res = DataBase.ExecuteBasicCommand(command);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return res;
        }
        public DataTable Select()
        {
            DataTable dt = new DataTable();
            string query = @"SELECT *
                                FROM Comment
                                WHERE status=1";
            try
            {
                SqlCommand command = DataBase.CreateBasicCommand(query);
                dt = DataBase.ExecuteDataTableCommand(command);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }
        public int Update(Comment t)
        {
            string query = @"UPDATE Comment
                        SET Description = @Description, 
                        WHERE CommentID = @CommentID";
            try
            {
                SqlCommand command = DataBase.CreateBasicCommand(query);
                command.Parameters.AddWithValue("@Description", t.Description);
                return DataBase.ExecuteBasicCommand(command);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

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
    class PersonImpl : IPerson
    {
        public int Delete(Person t)
        {
            throw new NotImplementedException();
        }
        public Person Get(byte id)
        {
            throw new NotImplementedException();
        }
        public int Insert(Person t)
        {
            string query = @"INSERT INTO Person (FirstName, LastName, SecondLastName, Email , Password , Role)
                            VALUES (@FirstName, @LastName, @SecondLastName, @Email , @Password , @Role)";
            try
            {
                SqlCommand command = DataBase.CreateBasicCommand(query);
                command.Parameters.AddWithValue("@FirstName", t.FirstName);
                command.Parameters.AddWithValue("@LastName", t.LastName);
                command.Parameters.AddWithValue("@SecondLastName", t.SecondLastName);
                command.Parameters.AddWithValue("@Email", t.Email);
                command.Parameters.AddWithValue("@Password", t.Password);
                command.Parameters.AddWithValue("@Role", t.Role);
                return DataBase.ExecuteBasicCommand(command);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable Login(string Email, string Password)
        {
            try
            {
                string query = @"SELECT Email, Password, Role
                             FROM Person
                             WHERE  Email= @Email AND Password=@Password";
                SqlCommand command = DataBase.CreateBasicCommand(query);
                command.Parameters.AddWithValue("@Email", Email);
                command.Parameters.AddWithValue("@Password", Password);
                return DataBase.ExecuteDataTableCommand(command);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable Select()
        {
            throw new NotImplementedException();
        }
        public int Update(Person t)
        {
            throw new NotImplementedException();
        }
        public DataTable VerifyUser(string Email, string Password)
        {
            try
            {
                string query = @"SELECT Email, Password, Role
                             FROM Person
                             WHERE  Email= @Email AND Password=@Password";
                SqlCommand command = DataBase.CreateBasicCommand(query);
                command.Parameters.AddWithValue("@Email", Email);
                command.Parameters.AddWithValue("@Password", Password);
                return DataBase.ExecuteDataTableCommand(command);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

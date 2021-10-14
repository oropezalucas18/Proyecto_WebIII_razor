using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO.Model;
using System.Data;

namespace DAO.Interfaces
{
    public interface IPerson:IDAO<Person>
    {
        DataTable Login(string Email, string Password);
        DataTable VerifyUser(string Email, string Password);
        Person Get(byte id);
    }
}

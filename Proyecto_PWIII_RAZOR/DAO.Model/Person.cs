using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Model
{
    public class Person
    {
        public byte PersonID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SecondLastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public char Role { get; set; }
        public Person()
        {

        }
        public Person(byte personID, string firstName, string lastName, string secondLastName, string email, string password, char role)
        {
            PersonID = personID;
            FirstName = firstName;
            LastName = lastName;
            SecondLastName = secondLastName;
            Email = email;
            Password = password;
            Role = role;
        }
    }
}

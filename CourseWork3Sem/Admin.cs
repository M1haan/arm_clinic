using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork3Sem
{
    class Admin
    {
        public string Password { get; private set; }

        public Admin(string fullName, string passportID,
            string residentialAddress, string phoneNumber, string password, string login) : base(fullName, passportID, residentialAddress, phoneNumber)
        {
            Password = password;
        }
        public override string ToString()
        {
            return ($"{FullName}, {PassportID}, {ResidentialAddress}, {PhoneNumber}, {Password}");
        }

    }
}

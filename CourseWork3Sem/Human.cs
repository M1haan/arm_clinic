using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork3Sem
{
    abstract class Human : IComparable
    {
        public string FullName { get; private set; }
        public string PassportID { get; private set; }
        public string ResidentialAddress { get; private set; }
        public string PhoneNumber { get; private set; }

        public Human(string fullName, string passportID,
            string residentialAddress, string phoneNumber)
        {
            FullName = fullName;
            PassportID = passportID;
            ResidentialAddress = residentialAddress;
            PhoneNumber = phoneNumber;
        }

        public int CompareTo(object obj)
        {
            if (obj is Human human)
                return FullName.CompareTo(human.FullName);
            else
                throw new ArgumentException("Некорректное значение параметра");
        }
    }
}

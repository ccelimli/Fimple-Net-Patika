using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    public class Person
    {
        private string _firstName;
        private string _lastName;
        private string _phoneNumber;

        public Person(string firstName, string lastName, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
        }

        public Person(){}
        public string FirstName { get=> _firstName; set=>_firstName=value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public string PhoneNumber { get => _phoneNumber; set => _phoneNumber = value; }
    }
}

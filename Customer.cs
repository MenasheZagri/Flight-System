using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_System
{
    class Customer: IPoco,IUser
    {
        public int _id;
        public string _firstName;
        public string _lastName;
        public string _userName;
        public string _password;
        public string _address;
        public int _phoneNumber;
        public int _creditCardNumber;

        public Customer(int id, string firstName, string lastName, string userName, string password, string address, int phoneNumber, int creditCardNumber)
        {
            _id = id;
            _firstName = firstName;
            _lastName = lastName;
            _userName = userName;
            _password = password;
            _address = address;
            _phoneNumber = phoneNumber;
            _creditCardNumber = creditCardNumber;
        }
    }
}

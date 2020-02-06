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

        public Customer()
        {
            
        }

        #region Overrides
        public static bool operator ==(Customer a, Customer b)
        {
            if (a == b)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public static bool operator !=(Customer a, Customer b)
        {
            if (a != b)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public override bool Equals(object obj)
        {
            Customer customer = obj as Customer;
            return (this._id == customer._id);
        }

        public override int GetHashCode()
        {
            return this._id;
        }
        public override string ToString()
        {
            return $"{_id}{_firstName}{_lastName}{_address}{_phoneNumber}{_userName}{_password}{_creditCardNumber} ";
        }
        #endregion
    }
}

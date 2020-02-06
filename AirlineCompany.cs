using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_System
{
    class AirlineCompany : IPoco, IUser
    {
        public int _id;
        public string _airlineName;
        public string _userName;
        public string _password;
        public int _countryCode;

        public AirlineCompany(int id, string airlineName, string userName, string password, int countryCode)
        {
            _id = id;
            _airlineName = airlineName;
            _userName = userName;
            _password = password;
            _countryCode = countryCode;
        }

        public AirlineCompany()
        {
            
        }

        #region Overrides
        public static bool operator ==(AirlineCompany a, AirlineCompany b)
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

        public static bool operator !=(AirlineCompany a, AirlineCompany b)
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
            AirlineCompany airlineCompany = obj as AirlineCompany;
            return (this._id == airlineCompany._id);
        }

        public override int GetHashCode()
        {
            return this._id;
        }
        public override string ToString()
        {
            return $"{_id} {_airlineName} {_countryCode} {_password} {_userName}";
        }
        #endregion
    }
}

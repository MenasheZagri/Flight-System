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
    }
}

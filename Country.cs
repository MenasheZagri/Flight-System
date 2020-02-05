using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Flight_System
{
    class Country: IPoco,IUser
    {

        private int _id;
        private string _airlineName;
        private string _userName;
        private string _password;
        private int _countryCode;

        public Country (int id, string airlineName, string userName, string password, int countryCode)
        {
            _id = id;
            _airlineName = airlineName;
            _userName = userName;
            _password = password;
            _countryCode = countryCode;
        }


    }
}

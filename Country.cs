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
        public int _id;
        public string _countryName;

        public Country(int id, string countryName)
        {
            _id = id;
            _countryName = countryName;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices.WindowsRuntime;
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

        public Country()
        {
            
        }

        #region Overrides
        public static bool operator ==(Country a, Country b)
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

        public static bool operator !=(Country a, Country b)
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
            Country country = obj as Country;
            return (this._id == country._id);
        }

        public override int GetHashCode()
        {
            return this._id;
        }
        public override string ToString()
        {
            return $"{_id} {_countryName}";
        }
        #endregion
    }
}

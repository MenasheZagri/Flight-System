using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_System
{
    class Ticket :IPoco
    {
        public int _id;
        public int _flightId;
        public int _customerId;

        public Ticket(int id, int flightId, int customerId)
        {
            _id = id;
            _flightId = flightId;
            _customerId = customerId;
        }

        public Ticket()
        {
            
        }

        #region Overrides
        public static bool operator ==(Ticket a, Ticket b)
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

        public static bool operator !=(Ticket a, Ticket b)
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
            Ticket ticket = obj as Ticket;
            return (this._id == ticket._id);
        }

        public override int GetHashCode()
        {
            return this._id;
        }
        public override string ToString()
        {
            return $"{_id} {_flightId} {_customerId}";
        }
        #endregion
    }
}

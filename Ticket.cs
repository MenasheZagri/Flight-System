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
    }
}

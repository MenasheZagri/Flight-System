using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_System
{
    class Flight: IPoco
    {
        public int _id;
        public int _airlineCompanyId;
        public int _originCountryCode;
        public int _destinationCountryCode;
        public DateTime _departureTime;
        public DateTime _landingTime;
        public int _remainingTickets;

        public Flight(int id, int airlineCompanyId, int originCountryCode, int destinationCountryCode, DateTime departureTime, DateTime landingTime, int remainingTickets)
        {
            _id = id;
            _airlineCompanyId = airlineCompanyId;
            _originCountryCode = originCountryCode;
            _destinationCountryCode = destinationCountryCode;
            _departureTime = departureTime;
            _landingTime = landingTime;
            _remainingTickets = remainingTickets;
        }
    }
}

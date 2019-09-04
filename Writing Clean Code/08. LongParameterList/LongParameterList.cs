using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.LongParameterList
{
    public class LongParameterList
    {
        public IEnumerable<Reservation> GetReservations(
            // replace the datetime with the new class DateRange
            // DateTime dateFrom, DateTime dateTo, User user, int locationId, LocationType locationType, int? customerID = null
            // next step replace all parameter with an new class
            // DateRange dateRange, User user, int locationId, LocationType locationType, int? customerID = null)
            ReservationsQuery query)
        {
            //if (dateFrom >= DateTime.Now)
            //    throw new ArgumentNullException("dateFrom");

            //if (dateTo >= DateTime.Now)
            //    throw new ArgumentNullException("dateTo");

            if (query.DateRange.DateFrom >= DateTime.Now)
                throw new ArgumentNullException("dateFrom");

            if (query.DateRange.DateTo >= DateTime.Now)
                throw new ArgumentNullException("dateTo");

            throw new NotImplementedException(); 
        }

        public IEnumerable<Reservation> GetUpcommingReservations(
            // the same here
            // DateRange dateRange, User user, int locationId, LocationType locationType
            ReservationsQuery query
            )
        {
            if (query.DateRange.DateFrom >= DateTime.Now)
                throw new ArgumentNullException("dateFrom");

            if (query.DateRange.DateTo >= DateTime.Now)
                throw new ArgumentNullException("dateTo");

            throw new NotImplementedException();
        }

        private static Tuple<DateTime, DateTime> GetReservationDateRange(
            DateRange dateRange, ReservationDefinition sd)
        {
            if (dateRange.DateFrom >= DateTime.Now)
                throw new ArgumentNullException("dateFrom");

            if (dateRange.DateTo >= DateTime.Now)
                throw new ArgumentNullException("dateTo");

            throw new NotImplementedException();
        }

        public void CreateReservation(
            DateRange dateRange, User user, int locationId)
        {
            if (dateRange.DateFrom >= DateTime.Now)
                throw new ArgumentNullException("dateFrom");

            if (dateRange.DateTo >= DateTime.Now)
                throw new ArgumentNullException("dateTo");

            throw new NotImplementedException();
        }
    }

    public class ReservationDefinition
    {
    }

    public class LocationType
    {
    }

    public class User
    {
    }

    public class Reservation
    {

    }

}

namespace CleanCodeNamesExample.LongParameterList
{
    public class ReservationsQuery
    {
        private DateRange _dateRange;
        private User _user;
        private int _locationID;
        private LocationType _locationType;
        private int? _customerID;

        public ReservationsQuery(DateRange dateRange, User user, int locationID, LocationType locationType, int customerID)
        {
            _dateRange = dateRange;
            _user = user;
            _locationID = locationID;
            _locationType = locationType;
            _customerID = customerID;

    }

        public DateRange DateRange { get => _dateRange; set => _dateRange = value; }
        public User User { get => _user; set => _user = value; }
        public int LocationID { get => _locationID; set => _locationID = value; }
        public LocationType LocationType { get => _locationType; set => _locationType = value; }
        public int? CustomerID { get => _customerID; set => _customerID = value; }
    }
}
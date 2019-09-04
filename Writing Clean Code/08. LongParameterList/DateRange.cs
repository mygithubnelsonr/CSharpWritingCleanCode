using System;

namespace CleanCode.LongParameterList
{
    public class DateRange
    {
        private DateTime _dateFrom;
        private DateTime _dateTo;

        public DateRange(DateTime dateFrom, DateTime dateTo)
        {
            _dateFrom = dateFrom;
            _dateTo = dateTo;

        }

        public DateTime DateFrom { get => _dateFrom; }
        public DateTime DateTo { get => _dateTo; }

    }
}
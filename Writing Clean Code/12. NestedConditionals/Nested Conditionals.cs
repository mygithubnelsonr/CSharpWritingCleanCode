using System;

namespace CleanCode.Nested_Conditionals
{

    public class ReservationOld
    {
        public ReservationOld(Customer customer, DateTime dateTime)
        {
            From = dateTime;
            Customer = customer;
        }

        public DateTime From { get; private set; }
        public Customer Customer { get; private set; }
        public bool IsCanceed { get; private set; }

        public void Cancel()
        {
            // Gold customers can cancel up to 24 hours before
            if(Customer.LoyaltyPoints > 100)
            {
                // if reservation already started throw exeption
                if(DateTime.Now > From)
                {
                    throw new InvalidOperationException("It's too late to cancel.");
                }
                if((From - DateTime.Now).TotalHours < 24)
                {
                    throw new InvalidOperationException("It's too late to cancel.");
                }

                IsCanceed = true;
            }
            else
            {
                // Regular customers can cancel up to 48 hours before

                // if reservation alredy starteds throw exeption
                if(DateTime.Now > From)
                {
                    throw new InvalidOperationException("It's too late to cancel.");
                }
                if((From - DateTime.Now).TotalHours < 48)
                {
                    throw new InvalidOperationException("It's too late to cancel.");
                }
                IsCanceed = true;
            }
        }

    }

    public class Reservation
    {
        public DateTime From { get; private set; }
        public Customer Customer { get; private set; }
        public bool IsCanceed { get; private set; }
        public int maxCancelHours { get; set; }

        public Reservation(Customer customer, DateTime dateTime)
        {
            From = dateTime;
            Customer = customer;
        }

        public void Cancel(int cancelHours)
        {
            // first optimizion is
            // if reservation already started throw exeption
            // then clean code using some new methods
            // IsGoldCustomer, LessThen, IsCancelationPeriodeOver
            // we get rid of the method IsAllreadyStarted is not needed
            // because it doesn't matter if IsAllreadyStarted or IsCancelationPeriodeOver
            if(IsCancelationPeriodeOver())
                throw new InvalidOperationException("It's too late to cancel.");

            IsCanceed = true;

        }

        private bool IsCancelationPeriodeOver()
        {
            return (Customer.IsGoldCustomer() && LessThen(12)) || (!Customer.IsGoldCustomer() && LessThen(48));
        }

        private bool LessThen(int maxValue)
        {
            // Gold customers can cancel up to 24 hours before
            // Regular customers can cancel up to 48 hours before
            return (From - DateTime.Now).TotalHours <= maxValue;
        }

    }
}

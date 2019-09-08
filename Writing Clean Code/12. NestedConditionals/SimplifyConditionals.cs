using System;

namespace CleanCode.Nested_Conditionals
{
    public class SimplifyConditionals
    {
        // simplify conditions
        private Customer customer;
        private float discount;
        private bool a = false;
        private bool b = false;
        private bool c = false;

        public float UseTernaryOperator()
        {
            customer = new Customer();

            // example
            if(customer.TotalOrders > 50)
                discount = 0.1f;
            else
                discount = 0.01f;

            // nested condition
            discount = (customer.TotalOrders > 50) ? 0.1f : 0.01f;

            // or
            return (customer.TotalOrders > 50) ? 0.1f : 0.01f;

        }

        public void SimplifyTrueOrFalse()
        {
            bool isGoldCustomer;

            customer = new Customer();

            // instate of 
            if(customer.TotalOrders > 50)
                isGoldCustomer = true;
            else
                isGoldCustomer = false;

            // use
            isGoldCustomer = customer.TotalOrders > 50;

            // combine
            if(a)
            {
                if(b)
                {
                    Statement();
                }
            }
            // become
            if(a && b)
                Statement();

            // Early Exit
            if(a)
            {
                if(b)
                {
                    Statement();
                }
            }

            // becomes
            if(!a)
                return;

            if(!b)
                return;

            Statement();

            // Early Exit + Combine
            if(!a || !b)
                return;

            Statement();

        }

        public void SwapOrders()
        {
            bool isValid = false;

            // swap orders
            if(a)
            {
                if(b)
                {
                    isValid = true;
                }
            }

            if(c)
            {
                if(b)
                {
                    isValid = true;
                }
            }

            // becomes
            if(b)
            {
                if(a || c)
                {
                    isValid = true;
                }
            }
            // becomes
            if(b && (a || c))
                isValid = true;

            // becomes
            isValid = (b && (a || c));

        }

        public void Statement()
        {
            Console.WriteLine("statement");
        }
    }
}

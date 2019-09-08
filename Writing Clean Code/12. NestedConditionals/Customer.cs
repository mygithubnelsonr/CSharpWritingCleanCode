namespace CleanCode.Nested_Conditionals
{
    public class Customer
    {
        public int TotalOrders { get; internal set; }
        public int LoyaltyPoints { get; internal set; }

        public bool IsGoldCustomer()
        {
            return LoyaltyPoints > 100;
        }
    }
}

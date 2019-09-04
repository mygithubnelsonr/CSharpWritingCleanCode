using System.Collections.Generic;

namespace CleanCode.OutputParameters
{
    public class GetCustomersResult
    {
        public IEnumerable<Customer> Customers { get; set; }
        public int TotalCount { get; set; }

    }
}

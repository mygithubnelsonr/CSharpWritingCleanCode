using System.Collections.Generic;

namespace CleanCodeNamesExample.OutputParameters
{
    public class GetCustomersResult
    {
        public IEnumerable<Customer> Customers { get; set; }
        public int TotalCount { get; set; }

    }
}

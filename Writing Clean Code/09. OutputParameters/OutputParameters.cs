using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.OutputParameters
{
    public partial class OutputParameters
    {
        // output parameters are code smelling and we will go to replacde them
        public void DisplayCustomers()
        {
            var pageIndex = 1;
            var result = GetCustomers(pageIndex);

            // old var customers = GetCustomers(1, out totalCount);
            //var customers = result.Customer;

            Console.WriteLine($"Total Customersw: {result.TotalCount} ");

            foreach(var c in result.Customers)
                Console.WriteLine(c);

        }

        // replace this with an new class GetCustomersResult
        // public IEnumerable<Customer> GetCustomers(int pageIndex, out int totalCount)
        public GetCustomersResult GetCustomers(int pageIndex)
        {
            var totalCount = 100;
            return new GetCustomersResult() { Customers = new List<Customer>(),  TotalCount = totalCount };
        }
    }
}

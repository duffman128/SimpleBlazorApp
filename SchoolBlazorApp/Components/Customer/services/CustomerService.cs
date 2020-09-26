using SchoolBlazorApp.Components.Customer.models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchoolBlazorApp.Components.Customer.services
{
    //Services are registered in Program.cs file.
    public class CustomerService : ICustomerService
    {
        private static List<ICustomer> Customers { get; set; } = new List<ICustomer>
        {
            new CustomerModel()
            {
                FirstName = "Makoto",
                LastName = "Shougi", 
                IsResident = false,
                TaxAmount = 350517.159f
            },
            new CustomerModel()
            {
                FirstName = "Olebogeng",
                LastName = "Thothela",
                IsResident = true,
                TaxAmount = 805.841f
            },
            new CustomerModel()
            {
                FirstName = "Kagoentle",
                LastName = "Thothela",
                IsResident = true,
                TaxAmount = 0f
            },
            new CustomerModel()
            {
                FirstName = "Geese",
                LastName = "Haword",
                IsResident = false,
                TaxAmount = 1000000000.99f
            },
        };

        public async Task<IReadOnlyList<ICustomer>> GetCustomersAsync()
        {
            await Task.Delay(1000);
            return Customers;
        }
    }
}

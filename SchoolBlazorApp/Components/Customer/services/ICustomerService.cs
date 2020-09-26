using SchoolBlazorApp.Components.Customer.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolBlazorApp.Components.Customer.services
{
    public interface ICustomerService
    {
        Task<IReadOnlyList<ICustomer>> GetCustomersAsync();
    }
}

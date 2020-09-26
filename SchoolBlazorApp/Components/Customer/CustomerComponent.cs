using Microsoft.AspNetCore.Components;
using SchoolBlazorApp.Components.Customer.models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolBlazorApp.Components.Customer
{
    public partial class CustomerComponent
    {
        [Parameter]
        public ICustomer Customer { get; set; }

        [Parameter]
        public EventCallback<string> OnCustomerClick { get; set; }

        private readonly CultureInfo zaCultureInfo = CultureInfo.GetCultureInfo("en-ZA");

        private async Task OnClick()
        {
            await OnCustomerClick.InvokeAsync($"{Customer.FirstName} {Customer.LastName}");
        }
    }
}

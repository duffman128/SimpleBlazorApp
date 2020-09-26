using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Newtonsoft.Json;
using SchoolBlazorApp.Components.Customer.viewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SchoolBlazorApp.Components.Customer
{
    public partial class AddCustomerComponent
    {
        private CustomerVM customerVM = new CustomerVM();

        protected override void OnInitialized()
        {}

        private void HandleValidSubmit()
        {
            Console.WriteLine(JsonConvert.SerializeObject(customerVM));
        }
    }
}

using Microsoft.AspNetCore.Components;
using SchoolBlazorApp.Components.Customer.models;
using SchoolBlazorApp.Components.Customer.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolBlazorApp.Components.Customer
{
    public partial class CustomersComponent // class must be created for code behind. partial class because of razor file.
    {
        public bool HighlightResidents { get; set; } = false;
        public string LastCustomerClicked { get; set; } = "";

        IReadOnlyList<ICustomer> customers;

        [Inject]
        protected ICustomerService CustomerService { get; set; }

        [Inject]
        protected NavigationManager NavigationManager { get; set; }

        private void NavToAddCustomer()
        {
            NavigationManager.NavigateTo("addcustomer");
        }

        private void OnChildClick(string lastCustomerClicked)
        {
            LastCustomerClicked = lastCustomerClicked;
        }

        protected override async Task OnInitializedAsync()
        {
            customers = await CustomerService.GetCustomersAsync();
        }
    }
}

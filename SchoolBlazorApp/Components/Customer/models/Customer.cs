namespace SchoolBlazorApp.Components.Customer.models
{
    public class CustomerModel : ICustomer
    {
        private static int nextId = 0;
        public CustomerModel()
        {
            Id = nextId++;
        }

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public bool IsResident { get; set; }

        public float TaxAmount { get; set; }
    }
}

namespace SchoolBlazorApp.Components.Customer.models
{
    public interface ICustomer
    {
        public int Id { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsResident { get; set; }
        public float TaxAmount { get; set; }
    }
}

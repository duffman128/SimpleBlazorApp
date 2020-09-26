using System.ComponentModel.DataAnnotations;

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

        [Required(ErrorMessage = "First name is required")]
        [StringLength(16, MinimumLength = 2, ErrorMessage = "Length must be between 2 and 16 characters")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        [StringLength(16, MinimumLength = 2, ErrorMessage = "Length must be between 2 and 16 characters")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Resident is required")]
        [Display(Name = "Resident")]
        public bool IsResident { get; set; }

        public float TaxAmount { get; set; }
    }
}

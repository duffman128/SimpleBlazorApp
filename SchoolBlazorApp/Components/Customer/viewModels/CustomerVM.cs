using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolBlazorApp.Components.Customer.viewModels
{
    public class CustomerVM
    {
        [Required(ErrorMessage = "First name is required")]
        [StringLength(16, MinimumLength = 2, ErrorMessage = "Length must be between 2 and 16 characters")]
        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        [StringLength(16, MinimumLength = 2, ErrorMessage = "Length must be between 2 and 16 characters")]
        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Resident is required")]
        [Display(Name = "Resident")]
        public bool IsResident { get; set; }

        [Required(ErrorMessage = "Tax Amount is required")]
        [Display(Name = "Tax Amount")]
        public float TaxAmount { get; set; }
    }
}

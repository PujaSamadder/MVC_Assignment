using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CustomerManagementSystem.Models
{
    public partial class CUSTOMER
    {
        public int CustomerId { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter Name...")]
        [StringLength(50)]
        public string CustomerName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Enter City")]
        [StringLength(50, ErrorMessage = "City Length max 50 char")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter Age")]
        [Range(0, 150)]
        public Nullable<int> Age { get; set; }

        [Required(ErrorMessage = "Please Enter Phone Number")]
        public Nullable<long> Phone { get; set; }


        [Required(ErrorMessage = "Please Enter Pincode")]
        public Nullable<int> PinCode { get; set; }
    }
}
    
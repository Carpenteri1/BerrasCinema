using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BerrasCinema.Models
{
    public class Order
    {
        [Key]
        public int BookingID { get; set; }

        [Required(ErrorMessage = "Required!")]
        [Range(1, 2, ErrorMessage = "Can only order 1 or 2 tickets")]
        public int amountOfTrickets { get; set; }

        [Required(ErrorMessage = "Required!")]
        [DisplayName("First Name")]
        public string CustomerFirstName { get; set; }
        [Required(ErrorMessage = "Required!")]
        [DisplayName("Last Name")]
        public string CustomerLastName { get; set; }
        [Required(ErrorMessage = "Required!")]
        [DataType(DataType.EmailAddress)]
        [DisplayName("Email")]
        public string CustomerEmail { get; set; }
        [Required(ErrorMessage = "Required!")]
        [DataType(DataType.EmailAddress)]
        [Compare("CustomerEmail")]
        [DisplayName("Confirm Email")]
        public string CustomerConfirmEmail { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BerrasCinema.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
        public DateTime OrderDate { get { return DateTime.Now; } }
        [Range(1,2)]
        [Required]
        public int AmmountOfTickets { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [DataType(DataType.EmailAddress)]
        [Required]
        public string Email { get; set; }
        [Required]
        [Compare("Email")]
        public string ConfirmEmail { get; set; }
        [Required]
        public string MovieName { get; set; }

        [ForeignKey("Movies")]
        public int MovieID { get; set ; }
        public virtual Movies Movies { get; set; }

    }
}

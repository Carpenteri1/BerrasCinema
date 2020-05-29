using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BerrasCinema.Models
{
    public class Movies
    {
        [Key]
        public int MovieID { get; set; }
        public string MovieName { get; set; }

        public DateTime MovieDuration { get; set; }

        public DateTime MovieStart { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingSofka.Web.Data.Entities
{
    public class TravelsEntity
    {
        public int Id { get; set; }
        [MaxLength(50, ErrorMessage = "The field {0} can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Destination { get; set; }
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public int Days { get; set; }
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public double Distance { get; set; }
      
        public decimal Total { get; set; }
    }
}

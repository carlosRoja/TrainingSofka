using System.ComponentModel.DataAnnotations;

namespace TrainingSofka.Web.Data.Entities
{
    public class TravelEntity
    {
        public int Id { get; set; }
        [MaxLength(50, ErrorMessage = "The field {0} can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Destination { get; set; }
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public int Days { get; set; }
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public double Distance { get; set; }
        public double Discount { get; set; }
        public double  Total { get; set; }
    }
}

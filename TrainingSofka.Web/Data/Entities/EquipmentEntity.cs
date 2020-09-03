using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingSofka.Web.Data.Entities
{
    public class EquipmentEntity
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public double Peso { get; set; }
        public int ValueDolars { get; set; }
        public double ValuePesos { get; set; }
        public double TotalEquipment { get; set; }
        public FlightEntity FlightEntity { get; set; }
    }
}

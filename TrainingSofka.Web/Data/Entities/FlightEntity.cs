using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingSofka.Web.Data.Entities
{
    public class FlightEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
       public int TotalPackage { get; set; }
        public int PackageMax { get; set; }
        public int PackageMin{ get; set; }
        public ICollection<EquipmentEntity> Equipments { get; set; }

    }
}

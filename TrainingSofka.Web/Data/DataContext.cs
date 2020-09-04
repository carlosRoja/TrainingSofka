using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainingSofka.Web.Data.Entities;

namespace TrainingSofka.Web.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<TravelEntity> Travels { get; set; }
        public DbSet<EquipmentEntity> Equipments { get; set; }
     
    }
}

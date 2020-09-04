using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingSofka.Web.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;
        public SeedDb(DataContext context)
        {
            _context = context;
           
        }
        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();//esta linea reemplaza el update database, siempre pasa por aca
            
        }
    }
}

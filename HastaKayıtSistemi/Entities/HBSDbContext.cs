using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaKayitSistemi.Entities
{
    class HBSDbContext : DbContext
    {
        public HBSDbContext()
        {
            this.Database.Connection.ConnectionString = "Server=BKK;Database=HBSDB2;User Id=sa;Password=xxx;";
        }
        public DbSet<AileHekim> AileHekimleri { get; set; }
        public DbSet<Hasta> Hastalar { get; set; }
        public DbSet<Hastalik> Hastaliklar { get; set; }
        public DbSet<Muayene> Muayeneler { get; set; }
        public DbSet<MuayeneHastalik> MuayeneHastaliklar { get; set; }
        public DbSet<Recete> Receteler { get; set; }
        public DbSet<ReceteIlac> ReceteIlaclar { get; set; }
        public DbSet<Ilac> Ilaclar { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaKayitSistemi.Entities
{
    [Table("Muayeneler")]
    public class Muayene : BaseEntity
    {
        public DateTime MuayeneTarihi { get; set; }
        public int HastaID { get; set; }
        public Hasta Hasta { get; set; }
        public int AileHekimID { get; set; }
        public AileHekim AileHekim { get; set; }
        public List<MuayeneHastalik> MuayeneHastalik { get; set; }
        public Recete Recete { get; set; }
    }
}

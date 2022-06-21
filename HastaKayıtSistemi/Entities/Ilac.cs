using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaKayitSistemi.Entities
{
    [Table("Ilaclar")]
    public class Ilac : BaseEntity
    {
        [Required]
        [StringLength(50)]
        public string IlacAdi { get; set; }
        [Required]
        [StringLength(20)]
        public string IlacKodu { get; set; }
        public List<ReceteIlac> ReceteIlaclar { get; set; }
    }
}

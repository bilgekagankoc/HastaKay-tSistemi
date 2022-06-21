using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaKayitSistemi.Entities
{
    [Table("Receteler")]
    public class Recete
    {
        [Key]
        [ForeignKey("Muayene")]
        public int ID { get; set; }
        [Required]
        [StringLength(8)]
        public string ReceteNo { get; set; }
        public List<ReceteIlac> ReceteIlaclar { get; set; }
        public Muayene Muayene { get; set; }
    }
}

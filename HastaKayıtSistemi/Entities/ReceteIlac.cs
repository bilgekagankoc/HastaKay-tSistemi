using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaKayitSistemi.Entities
{
    [Table("ReceteIlac")]
    public class ReceteIlac
    {
        [Key]
        [Column(Order = 0)]
        [ForeignKey("Recete")]
        public int ReceteID { get; set; }
        public Recete Recete { get; set; }
        [Key]
        [Column(Order = 1)]
        [ForeignKey("Ilac")]
        public int IlacID { get; set; }
        public Ilac Ilac { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaKayitSistemi.Entities
{
    [Table("MuayeneHastalik")]
    public class MuayeneHastalik
    {
        [Key]
        [Column(Order = 0)]
        public int MuayeneID { get; set; }
        public Muayene Muayene { get; set; }
        [Key]
        [Column(Order = 1)]
        public int HastalikID { get; set; }
        public Hastalik Hastalik { get; set; }

    }
}

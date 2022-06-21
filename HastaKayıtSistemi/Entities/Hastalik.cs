using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaKayitSistemi.Entities
{
    [Table("Hastaliklar")]
    public class Hastalik : BaseEntity
    {
        [Required]
        [StringLength(50)]
        public string HastalikAdi { get; set; }
        [Required]
        [MaxLength(7),MinLength(3)]
        public string ICD10 { get; set; }
        public List<MuayeneHastalik> MuayeneHastalik { get; set; }

        public override string ToString()
        {
            return this.HastalikAdi + " " + this.ICD10;
        }
    }
}

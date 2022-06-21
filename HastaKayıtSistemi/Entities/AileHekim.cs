using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaKayitSistemi.Entities
{
    [Table("AileHekimleri")]
    public class AileHekim :BaseEntity
    {
        [Required]
        [StringLength(50)]
        public string HekimAdi { get; set; }
        [Required]
        [StringLength(50)]
        public string HekimSoyadi { get; set; }
        [Required]
        [StringLength(10)]
        public string DiplomaNo { get; set; }
        [Required]
        [MaxLength(11, ErrorMessage = "TCKN 11 haneli olmak zorundadır."), MinLength(11, ErrorMessage = "TCKN 11 haneli olmak zorundadır.")]
        public string TCKN { get; set; }

        public List<Hasta> Hastalar { get; set; }
        public List<Muayene> Muayeneler { get; set; }


        public override string ToString()
        {
            return this.HekimAdi + " " + this.HekimSoyadi;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaKayitSistemi.Entities
{
    [Table("Hastalar")]
    public class Hasta : BaseEntity
    {
        [Required]
        [StringLength(50)]
        public string HastaAdi { get; set; }
        [Required]
        [StringLength(50)]
        public string HastaSoyadi { get; set; }
        [Required]
        [MaxLength(11,ErrorMessage ="TCKN 11 haneli olmak zorundadır."),MinLength(11, ErrorMessage = "TCKN 11 haneli olmak zorundadır.")]
        public string TCKN { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Adres { get; set; }

        [ForeignKey("AileHekim")]
        public int AileHekimID { get; set; }
        public AileHekim AileHekim { get; set; }

        public List<Muayene> Muayeneler { get; set; }
        public override string ToString()
        {
            return this.HastaAdi + " " + this.HastaSoyadi;
        }
    }
}

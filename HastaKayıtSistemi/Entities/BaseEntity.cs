using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaKayitSistemi.Entities
{
    public class BaseEntity
    {
        public int ID { get; set; }
        public bool Aktif { get; set; }
        public DateTime OlusturmaTarihi { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public int OlusturanKullaniciID { get; set; }
        public int? GuncelleyenKullaniciID { get; set; }
    }
}

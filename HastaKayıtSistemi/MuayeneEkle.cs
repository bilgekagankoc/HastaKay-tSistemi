using HastaKayitSistemi.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaKayıtSistemi
{
    public partial class MuayeneEkle : Form
    {
        private HBSDbContext _db;
        public MuayeneEkle()
        {
            _db = new HBSDbContext();
            InitializeComponent();
        }

        private void MuayeneEkle_Load(object sender, EventArgs e)
        {
            var aileHekimleri = _db.AileHekimleri.ToList();
            var hastalar = _db.Hastalar.ToList();
            var hastaliklar = _db.Hastaliklar.ToList();

            foreach (var aileHekimi in aileHekimleri)
            {
                cbmAileHekimi.Items.Add(aileHekimi);
            }
            foreach (var hasta in hastalar)
            {
                cmbHasta.Items.Add(hasta);
            }
            foreach (var hastalik in hastaliklar)
            {
                chblbHastaliklar.Items.Add(hastalik);
            }

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var secilenHastaliklar = new List<MuayeneHastalik>();
            foreach (Hastalik hastalik in chblbHastaliklar.CheckedItems)
            {
                var muayeneHastalik = new MuayeneHastalik()
                {
                    HastalikID = hastalik.ID
                };

                secilenHastaliklar.Add(muayeneHastalik);
            }
            Muayene muayene = new Muayene()
            {
                AileHekimID = ((AileHekim)cbmAileHekimi.SelectedItem).ID,
                HastaID = ((Hasta)cmbHasta.SelectedItem).ID,
                MuayeneTarihi = DateTime.Now,
                MuayeneHastalik = secilenHastaliklar,
                OlusturanKullaniciID = 1,
                OlusturmaTarihi = DateTime.Now,
                Aktif = true
            };
            _db.Muayeneler.Add(muayene);
            var sonuc = _db.SaveChanges();
            if (sonuc > 0)
            {
                MessageBox.Show("Muayene Kaydı Başarılı");
            }
            else
            {
                MessageBox.Show("Muayene Kaydı Başarısız");
            }
        }
    }
}

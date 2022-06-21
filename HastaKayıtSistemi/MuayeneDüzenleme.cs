using HastaKayitSistemi.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaKayıtSistemi
{
    public partial class MuayeneDüzenleme : Form
    {
        private HBSDbContext _db;
        public MuayeneDüzenleme()
        {
            _db = new HBSDbContext();
            InitializeComponent();
        }

        private void MuayeneDüzenleme_Load(object sender, EventArgs e)
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
            var secilenId = Convert.ToInt32(lblId.Text);
            var muayene = _db.Muayeneler.Include(x => x.MuayeneHastalik).FirstOrDefault(x => x.ID == secilenId);
            var muayeneHastaliklar = _db.MuayeneHastaliklar.Include(x => x.Hastalik).Include(x => x.Muayene).Where(x => x.MuayeneID == Convert.ToInt32(lblId.Text));
            cbmAileHekimi.SelectedItem = muayene.AileHekim;
            cmbHasta.SelectedItem = muayene.Hasta;

            foreach (var muayeneHastalik in muayene.MuayeneHastalik)
            {
                chblbHastaliklar.SetItemChecked(muayeneHastalik.HastalikID-1, true);
            }

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var secilenHastaliklar = new List<MuayeneHastalik>();
            var secilenId = Convert.ToInt32(lblId.Text);
            var muayene = _db.Muayeneler.Include(x => x.MuayeneHastalik).FirstOrDefault(x => x.ID == secilenId);
            foreach (Hastalik hastalik in chblbHastaliklar.CheckedItems)
            {
                var muayeneHastalik = new MuayeneHastalik()
                {
                    HastalikID = hastalik.ID
                };

                secilenHastaliklar.Add(muayeneHastalik);
            }
            muayene.AileHekimID = ((AileHekim)cbmAileHekimi.SelectedItem).ID;
            muayene.HastaID = ((Hasta)cmbHasta.SelectedItem).ID;
            muayene.MuayeneHastalik = secilenHastaliklar;
            muayene.GuncellemeTarihi = DateTime.Now;
            muayene.GuncelleyenKullaniciID = 2;
            var sonuc = _db.SaveChanges();
            this.Close();
            if (sonuc > 0)
            {
                MessageBox.Show("Muayene Düzenleme Başarılı");
            }
            else
            {
                MessageBox.Show("Muayene Düzenleme Başarısız");
            }
        }
    }
}

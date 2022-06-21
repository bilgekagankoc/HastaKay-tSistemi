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
    public partial class HastaDüzenleme : Form
    {
        private HBSDbContext _db;
        public HastaDüzenleme()
        {
            _db = new HBSDbContext();
            InitializeComponent();
        }

        private void HastaDüzenleme_Load(object sender, EventArgs e)
        {
            var secilenId = Convert.ToInt32(lblId.Text);
            var hasta = _db.Hastalar.Include(x=>x.AileHekim).FirstOrDefault(x => x.ID == secilenId);
            var aileHekimleri = _db.AileHekimleri.Where(x => x.Aktif).ToList();
            txtAdres.Text = hasta.Adres;
            txtHastaAdi.Text = hasta.HastaAdi;
            txtHastaSoyadi.Text = hasta.HastaSoyadi;
            txtTckn.Text = hasta.TCKN;
            dtpDogumTarihi.Value = hasta.DogumTarihi;
            foreach (var aileHekim in aileHekimleri)
            {
                cmbAileHekimi.Items.Add(aileHekim);
            }
            cmbAileHekimi.SelectedItem = hasta.AileHekim;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var secilenId = Convert.ToInt32(lblId.Text);
            var hasta = _db.Hastalar.Include(x => x.AileHekim).FirstOrDefault(x => x.ID == secilenId);
            hasta.HastaAdi = txtHastaAdi.Text;
            hasta.HastaSoyadi = txtHastaSoyadi.Text;
            hasta.TCKN = txtTckn.Text;
            hasta.DogumTarihi = dtpDogumTarihi.Value;
            hasta.Adres = txtAdres.Text;
            hasta.AileHekimID = ((AileHekim)cmbAileHekimi.SelectedItem).ID;
            hasta.GuncelleyenKullaniciID = 2;
            hasta.GuncellemeTarihi = DateTime.Now;
            this.Close();

            var sonuc = _db.SaveChanges();
            if (sonuc > 0)
            {
                MessageBox.Show("Hasta Düzenleme İşlemi Başarılı");
            }
        }
    }
}

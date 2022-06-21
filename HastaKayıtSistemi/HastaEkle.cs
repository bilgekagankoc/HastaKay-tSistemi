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
    
    public partial class HastaEkle : Form
    {
        private HBSDbContext _db;
        public HastaEkle()
        {
            _db = new HBSDbContext();
            InitializeComponent();
        }

        private void HastaEkle_Load(object sender, EventArgs e)
        {
            var aileHekimleri = _db.AileHekimleri.ToList();

            foreach (var aileHekimi in aileHekimleri)
            {
                cmbAileHekimi.Items.Add(aileHekimi);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Hasta hasta = new Hasta()
            {
                HastaAdi = txtHastaAdi.Text,
                HastaSoyadi = txtHastaSoyadi.Text,
                TCKN = txtTckn.Text,
                DogumTarihi = dtpDogumTarihi.Value,
                Adres = txtAdres.Text,
                AileHekimID = ((AileHekim)cmbAileHekimi.SelectedItem).ID,
                OlusturanKullaniciID = 1,
                OlusturmaTarihi = DateTime.Now,
                Aktif = true
            };
            if (string.IsNullOrEmpty(txtHastaAdi.Text) || string.IsNullOrEmpty(txtHastaSoyadi.Text) || string.IsNullOrEmpty(txtTckn.Text) || string.IsNullOrEmpty(dtpDogumTarihi.Text) || string.IsNullOrEmpty(txtAdres.Text))
            {
                MessageBox.Show("Bilgileri Tam Giriniz");
            }
            else if (txtTckn.Text.Length != 11)
            {
                MessageBox.Show("TCKN 11 hane olmalıdır");
            }
            else
            {
                _db.Hastalar.Add(hasta);
                var sonuc = _db.SaveChanges();
                if(sonuc > 0)
                {
                    MessageBox.Show("Hasta EKlendi");
                }
                else
                {
                    MessageBox.Show("Hasta Eklenemedi");
                }
            }
        }
    }
}

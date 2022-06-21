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
    public partial class HastalikEkle : Form
    {

        private HBSDbContext _db;
        public HastalikEkle()
        {
            _db = new HBSDbContext();
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Hastalik hastalik = new Hastalik()
            {
                HastalikAdi = txtHastalikAdi.Text,
                ICD10 = txtICD10.Text,
                OlusturanKullaniciID = 1,
                OlusturmaTarihi = DateTime.Now,
                Aktif = true
            };
            if(string.IsNullOrEmpty(txtHastalikAdi.Text) || string.IsNullOrEmpty(txtICD10.Text))
            {
                MessageBox.Show("Bilgileri Tam Giriniz");
            }
            else
            {
                _db.Hastaliklar.Add(hastalik);
                var sonuc = _db.SaveChanges();
                if (sonuc > 0)
                {
                    MessageBox.Show("Hastalik Eklendi");
                }
                else
                {
                    MessageBox.Show("Hastalik Eklenemedi");
                }
            }
        }
    }
}

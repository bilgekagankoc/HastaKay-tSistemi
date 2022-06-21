using HastaKayitSistemi.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaKayitSistemi
{
    public partial class AileHekimEkle : Form
    {
        private HBSDbContext _db;
        public AileHekimEkle()
        {
            _db = new HBSDbContext();
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            AileHekim ailehekim = new AileHekim()
            {
                DiplomaNo = txtDiplomaNo.Text,
                HekimAdi = txtHekimAdi.Text,
                HekimSoyadi = txtHekimSoyadi.Text,
                TCKN = txtTckn.Text,
                OlusturmaTarihi = DateTime.Now,
                OlusturanKullaniciID = 1,
                Aktif = true
            };
            if(string.IsNullOrEmpty(txtDiplomaNo.Text) || string.IsNullOrEmpty(txtHekimAdi.Text) || string.IsNullOrEmpty(txtHekimSoyadi.Text) || string.IsNullOrEmpty(txtTckn.Text))
            {
                MessageBox.Show("Bilgileri Tam Giriniz");
            }
            else if (txtTckn.Text.Length != 11)
            {
                MessageBox.Show("TCKN 11 hane olmalıdır");
            }
            else
            {
                _db.AileHekimleri.Add(ailehekim);

                var sonuc = _db.SaveChanges();
                if ( sonuc > 0)
                {
                    MessageBox.Show("Aile Hekimi Başarıyla EKlendi");
                }
                else
                {
                    MessageBox.Show("Aile Hekimi Eklenemdi");
                }
            }
        }

        public static explicit operator AileHekimEkle(ObjectHandle v)
        {
            throw new NotImplementedException();
        }
    }
}

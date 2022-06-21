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
    public partial class HastalikDüzenleme : Form
    {
        private HBSDbContext _db;
        public HastalikDüzenleme()
        {
            _db = new HBSDbContext();
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var secilenId = Convert.ToInt32(lblId.Text);
            var hastalik = _db.Hastaliklar.FirstOrDefault(x => x.ID == secilenId);
            hastalik.ICD10 = txtICD10.Text;
            hastalik.HastalikAdi = txtHastalikAdi.Text;
            hastalik.GuncelleyenKullaniciID = 2;
            hastalik.GuncellemeTarihi = DateTime.Now;
            var sonuc = _db.SaveChanges();
            if (sonuc > 0)
            {
                MessageBox.Show("Hastalik Düzenleme Yapıldı");
            }
            else
            {
                MessageBox.Show("Hastalik Düzenleme yapılamadı.");
            }
        }

        private void HastalikDüzenleme_Load(object sender, EventArgs e)
        {
            var secilenId = Convert.ToInt32(lblId.Text);
            var hastalik = _db.Hastaliklar.FirstOrDefault(x => x.ID == secilenId);
            txtHastalikAdi.Text = hastalik.HastalikAdi;
            txtICD10.Text = hastalik.ICD10;
            this.Close();
        }
    }
}

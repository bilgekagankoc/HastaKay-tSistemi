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
    public partial class AileHekimiDüzenleme : Form
    {
        private HBSDbContext _db;
        public AileHekimiDüzenleme()
        {
            _db = new HBSDbContext();
            InitializeComponent();
        }

        private void AileHekimiDüzenleme_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            
            var id = Convert.ToInt32(lblId.Text);
            var aileHekimi = _db.AileHekimleri.FirstOrDefault(x => x.ID == id);
            aileHekimi.HekimAdi = txtHekimAdi.Text;
            aileHekimi.HekimSoyadi = txtHekimSoyadi.Text;
            aileHekimi.TCKN = txtTckn.Text;
            aileHekimi.DiplomaNo = txtDiplomaNo.Text;
            aileHekimi.GuncellemeTarihi = DateTime.Now;
            aileHekimi.GuncelleyenKullaniciID = 2;
            var sonuc = _db.SaveChanges();
            this.Close();
            if (sonuc>0)
            {
                MessageBox.Show("Düzenleme Başarılı");
                this.Close();
            }
            else
            {
                MessageBox.Show("DÜzenleme Başarısız");
            }
        }
    }
}

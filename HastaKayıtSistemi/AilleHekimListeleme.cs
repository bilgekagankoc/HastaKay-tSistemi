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
    public partial class AilleHekimListeleme : Form
    {
        private HBSDbContext _db;
        public AilleHekimListeleme()
        {
            _db = new HBSDbContext();
            InitializeComponent();
        }

        private void AilleHekimListeleme_Load(object sender, EventArgs e)
        {
            Listele();
        }
        private void Listele()
        {
            lstvAileHekim.Items.Clear();
            var aileHekimleri = _db.AileHekimleri.Where(x=>x.Aktif).ToList();

            foreach (var aileHekim in aileHekimleri)
            {
                ListViewItem li = new ListViewItem(aileHekim.ID.ToString());
                li.SubItems.Add(aileHekim.HekimAdi);
                li.SubItems.Add(aileHekim.HekimSoyadi);
                li.SubItems.Add(aileHekim.DiplomaNo);
                li.SubItems.Add(aileHekim.TCKN);
                li.SubItems.Add(aileHekim.OlusturmaTarihi.ToString("dd/MM/yyyy"));
                lstvAileHekim.Items.Add(li);
            }

        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var secilenEleman = lstvAileHekim.SelectedItems[0].Text;
            var secilenId = Convert.ToInt32(secilenEleman);
            AileHekimiDüzenleme ahd = new AileHekimiDüzenleme();
            ahd.lblId.Text = secilenEleman;
            var aileHekimi = _db.AileHekimleri.FirstOrDefault(x => x.ID == secilenId);
            ahd.txtDiplomaNo.Text = aileHekimi.DiplomaNo;
            ahd.txtHekimAdi.Text = aileHekimi.HekimAdi;
            ahd.txtHekimSoyadi.Text = aileHekimi.HekimSoyadi;
            ahd.txtTckn.Text = aileHekimi.TCKN;
            ahd.Show();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var secilenEleman = lstvAileHekim.SelectedItems[0].Text;
            var secilenId = Convert.ToInt32(secilenEleman);
            var aileHekimleri = _db.AileHekimleri.FirstOrDefault(x => x.ID == secilenId);
            aileHekimleri.Aktif = false;

            var sonuc = _db.SaveChanges();
            if (sonuc > 0)
            {
                MessageBox.Show("Silme İşlemi Başarılı");
            }
            Listele();
        }
    }
}

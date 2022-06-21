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
    public partial class HastaListeleme : Form
    {

        private HBSDbContext _db;
        public HastaListeleme()
        {
            _db = new HBSDbContext();
            InitializeComponent();
        }
        public void Listele()
        {
            lsvHastalar.Items.Clear();
            var hastalar = _db.Hastalar.Include(x=>x.AileHekim).Where(x=>x.Aktif).ToList();
            
            foreach (var hasta in hastalar)
            {
                ListViewItem li = new ListViewItem(hasta.ID.ToString());
                li.SubItems.Add(hasta.HastaAdi);
                li.SubItems.Add(hasta.HastaSoyadi);
                li.SubItems.Add(hasta.TCKN);
                li.SubItems.Add(hasta.DogumTarihi.ToString("dd/MM/yyyy"));
                li.SubItems.Add(hasta.Adres);
                li.SubItems.Add(hasta.AileHekim.HekimAdi);
                li.SubItems.Add(hasta.OlusturmaTarihi.ToString("dd/MM/yyyy"));

                lsvHastalar.Items.Add(li);
            }
        }
        private void HastaListeleme_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var secilenEleman = lsvHastalar.SelectedItems[0].Text;
            var secilenId = Convert.ToInt32(secilenEleman);

            HastaDüzenleme hd = new HastaDüzenleme();
            hd.lblId.Text = secilenEleman;

            hd.Show();

        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var secilenEleman = lsvHastalar.SelectedItems[0].Text;
            var secilenId = Convert.ToInt32(secilenEleman);
            var hasta = _db.Hastalar.FirstOrDefault(x => x.ID == secilenId);
            hasta.Aktif = false;
            var sonuc = _db.SaveChanges();
            if (sonuc > 0)
            {
                MessageBox.Show("Hasta Silme İşlemi Başarılı");
            }
        }
    }
}

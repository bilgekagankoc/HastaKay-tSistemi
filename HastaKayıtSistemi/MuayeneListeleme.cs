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
    public partial class MuayeneListeleme : Form
    {
        private HBSDbContext _db;
        public MuayeneListeleme()
        {
            _db = new HBSDbContext();
            InitializeComponent();
        }
        public void Listele()
        {
            lstMuayene.Items.Clear();
            var muayeneler = _db.Muayeneler.Include(x => x.AileHekim).Include(x => x.Hasta).Include(x => x.MuayeneHastalik).Where(x => x.Aktif).ToList();

            foreach (var muayene in muayeneler)
            {
                var muayeneHastaliklarString = "";
                var muayeneHastaliklar = _db.MuayeneHastaliklar.Include(x => x.Hastalik).Where(x => x.MuayeneID == muayene.ID).ToList();
                ListViewItem li = new ListViewItem(muayene.ID.ToString());
                li.SubItems.Add(muayene.MuayeneTarihi.ToString("dd/MM/yyyy"));
                li.SubItems.Add(muayene.AileHekim.ToString());
                li.SubItems.Add(muayene.Hasta.ToString());
                foreach (var muayeneHastalik in muayeneHastaliklar)
                {
                    muayeneHastaliklarString += muayeneHastalik.Hastalik.HastalikAdi + " ";
                }
                li.SubItems.Add(muayeneHastaliklarString);
                li.SubItems.Add(muayene.OlusturmaTarihi.ToString("dd/MM/yyyy"));
                lstMuayene.Items.Add(li);
            }
        }
        private void MuayeneListeleme_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var secilenEleman = lstMuayene.SelectedItems[0].Text;
            var secilenId = Convert.ToInt32(secilenEleman);
            MuayeneDüzenleme md = new MuayeneDüzenleme();
            md.lblId.Text = secilenEleman;
            md.Show();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var secilenEleman = lstMuayene.SelectedItems[0].Text;
            var secilenId = Convert.ToInt32(secilenEleman);
            var muayene = _db.Muayeneler.FirstOrDefault(x => x.ID == secilenId);
            muayene.Aktif = false;
            _db.SaveChanges();
            Listele();
        }
    }
}

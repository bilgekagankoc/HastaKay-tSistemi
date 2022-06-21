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
    public partial class HastalikListeleme : Form
    {
        private HBSDbContext _db;
        public HastalikListeleme()
        {
            _db = new HBSDbContext();
            InitializeComponent();
        }
        public void Listele()
        {
            lstvHastalik.Items.Clear();
            var hastaliklar = _db.Hastaliklar.Where(x => x.Aktif).ToList();
            foreach (var hastalik in hastaliklar)
            {
                ListViewItem li = new ListViewItem(hastalik.ID.ToString());
                li.SubItems.Add(hastalik.HastalikAdi);
                li.SubItems.Add(hastalik.ICD10);
                li.SubItems.Add(hastalik.OlusturmaTarihi.ToString("dd/MM/yyyy"));
                lstvHastalik.Items.Add(li);
            }
        }
        private void HastalikListeleme_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HastalikDüzenleme hd = new HastalikDüzenleme();
            hd.lblId.Text = lstvHastalik.SelectedItems[0].Text;
            hd.Show();
        }

        private void sİlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var secilenId = Convert.ToInt32(lstvHastalik.SelectedItems[0].Text);
            var hastalik = _db.Hastaliklar.FirstOrDefault(x => x.ID == secilenId);
            hastalik.Aktif = false;
            _db.SaveChanges();
            Listele();
        }
    }
}

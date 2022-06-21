using HastaKayitSistemi;
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

namespace HastaKayıtSistemi
{
    public partial class AnaSayfa1 : Form
    {

        public AnaSayfa1()
        {
            InitializeComponent();
        }

        private void ShowNewForm(string acilacakFormunAdi , Type acilacakFormunTipi)
        {
            Form acilacakForm = null;
            foreach (Form acikOlanForm in Application.OpenForms)
            {
                if(acikOlanForm.Name == acilacakFormunAdi)
                {
                    acilacakForm = acikOlanForm;
                }
            }
            if(acilacakForm == null)
            {
                Form yeniAcilacakForm = (Form)Activator.CreateInstance(acilacakFormunTipi);
                yeniAcilacakForm.MdiParent = this;
                yeniAcilacakForm.Show();
            }
            else
            {
                acilacakForm.BringToFront();
            }
        }
    
   

        private void AileHekimEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowNewForm("AileHekimEkle",typeof(AileHekimEkle));
        }

        private void AileHekimListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowNewForm("AilleHekimListeleme", typeof(AilleHekimListeleme));
        }

        private void HastaEkleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowNewForm("HastaEkle", typeof(HastaEkle));
        }

        private void HastaListeleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowNewForm("HastaListeleme", typeof(HastaListeleme));
        }

        private void MuayeneEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowNewForm("MuayeneEkle", typeof(MuayeneEkle));
        }

        private void MuayeneListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowNewForm("MuayeneListeleme", typeof(MuayeneListeleme));
        }

        private void HastalikekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowNewForm("HastalikEkle", typeof(HastalikEkle));
        }

        private void HastaliklisteleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowNewForm("HastalikListeleme", typeof(HastalikListeleme));
        }
    }
}

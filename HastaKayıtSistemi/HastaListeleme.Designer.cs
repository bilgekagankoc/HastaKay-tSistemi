
namespace HastaKayıtSistemi
{
    partial class HastaListeleme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lsvHastalar = new System.Windows.Forms.ListView();
            this.lvlId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvlHastaAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvlHastaSoyadi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvlTckn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvlDogumTarihi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvlAdres = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvlAileHekim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lvlOlusturmaTarihi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsvHastalar
            // 
            this.lsvHastalar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvlId,
            this.lvlHastaAdi,
            this.lvlHastaSoyadi,
            this.lvlTckn,
            this.lvlDogumTarihi,
            this.lvlAdres,
            this.lvlAileHekim,
            this.lvlOlusturmaTarihi});
            this.lsvHastalar.ContextMenuStrip = this.contextMenuStrip1;
            this.lsvHastalar.FullRowSelect = true;
            this.lsvHastalar.GridLines = true;
            this.lsvHastalar.HideSelection = false;
            this.lsvHastalar.Location = new System.Drawing.Point(13, 13);
            this.lsvHastalar.MultiSelect = false;
            this.lsvHastalar.Name = "lsvHastalar";
            this.lsvHastalar.Size = new System.Drawing.Size(775, 425);
            this.lsvHastalar.TabIndex = 0;
            this.lsvHastalar.UseCompatibleStateImageBehavior = false;
            this.lsvHastalar.View = System.Windows.Forms.View.Details;
            // 
            // lvlId
            // 
            this.lvlId.Text = "Id";
            this.lvlId.Width = 45;
            // 
            // lvlHastaAdi
            // 
            this.lvlHastaAdi.Text = "Hasta Adı";
            this.lvlHastaAdi.Width = 114;
            // 
            // lvlHastaSoyadi
            // 
            this.lvlHastaSoyadi.Text = "Hasta Soyadı";
            this.lvlHastaSoyadi.Width = 107;
            // 
            // lvlTckn
            // 
            this.lvlTckn.Text = "TCKN";
            this.lvlTckn.Width = 86;
            // 
            // lvlDogumTarihi
            // 
            this.lvlDogumTarihi.Text = "Doğum Tarihi";
            this.lvlDogumTarihi.Width = 98;
            // 
            // lvlAdres
            // 
            this.lvlAdres.Text = "Adres";
            this.lvlAdres.Width = 107;
            // 
            // lvlAileHekim
            // 
            this.lvlAileHekim.Text = "Aile Hekimi";
            this.lvlAileHekim.Width = 125;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.düzenleToolStripMenuItem,
            this.silToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(117, 48);
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            this.düzenleToolStripMenuItem.Click += new System.EventHandler(this.düzenleToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // lvlOlusturmaTarihi
            // 
            this.lvlOlusturmaTarihi.Text = "Oluşturma Tarihi";
            // 
            // HastaListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lsvHastalar);
            this.Name = "HastaListeleme";
            this.Text = "HastaListeleme";
            this.Load += new System.EventHandler(this.HastaListeleme_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lsvHastalar;
        private System.Windows.Forms.ColumnHeader lvlId;
        private System.Windows.Forms.ColumnHeader lvlHastaAdi;
        private System.Windows.Forms.ColumnHeader lvlHastaSoyadi;
        private System.Windows.Forms.ColumnHeader lvlTckn;
        private System.Windows.Forms.ColumnHeader lvlDogumTarihi;
        private System.Windows.Forms.ColumnHeader lvlAdres;
        private System.Windows.Forms.ColumnHeader lvlAileHekim;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader lvlOlusturmaTarihi;
    }
}
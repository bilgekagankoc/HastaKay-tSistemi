
namespace HastaKayıtSistemi
{
    partial class AilleHekimListeleme
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
            this.lstvAileHekim = new System.Windows.Forms.ListView();
            this.lvlId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvlHekimAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvlHekimSoyadi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvlDiplomaNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvlTckn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lvlOlusturmaTarihi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstvAileHekim
            // 
            this.lstvAileHekim.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvlId,
            this.lvlHekimAdi,
            this.lvlHekimSoyadi,
            this.lvlDiplomaNo,
            this.lvlTckn,
            this.lvlOlusturmaTarihi});
            this.lstvAileHekim.ContextMenuStrip = this.contextMenuStrip1;
            this.lstvAileHekim.FullRowSelect = true;
            this.lstvAileHekim.GridLines = true;
            this.lstvAileHekim.HideSelection = false;
            this.lstvAileHekim.Location = new System.Drawing.Point(12, 12);
            this.lstvAileHekim.MultiSelect = false;
            this.lstvAileHekim.Name = "lstvAileHekim";
            this.lstvAileHekim.Size = new System.Drawing.Size(776, 426);
            this.lstvAileHekim.TabIndex = 0;
            this.lstvAileHekim.UseCompatibleStateImageBehavior = false;
            this.lstvAileHekim.View = System.Windows.Forms.View.Details;
            // 
            // lvlId
            // 
            this.lvlId.Text = "Id";
            this.lvlId.Width = 83;
            // 
            // lvlHekimAdi
            // 
            this.lvlHekimAdi.Text = "Hekim Adı";
            this.lvlHekimAdi.Width = 107;
            // 
            // lvlHekimSoyadi
            // 
            this.lvlHekimSoyadi.Text = "Hekim Soyadi";
            this.lvlHekimSoyadi.Width = 96;
            // 
            // lvlDiplomaNo
            // 
            this.lvlDiplomaNo.Text = "Diploma No";
            this.lvlDiplomaNo.Width = 115;
            // 
            // lvlTckn
            // 
            this.lvlTckn.Text = "TCKN";
            this.lvlTckn.Width = 109;
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
            this.lvlOlusturmaTarihi.Width = 122;
            // 
            // AilleHekimListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstvAileHekim);
            this.Name = "AilleHekimListeleme";
            this.Text = "AilleHekimListeleme";
            this.Load += new System.EventHandler(this.AilleHekimListeleme_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstvAileHekim;
        private System.Windows.Forms.ColumnHeader lvlId;
        private System.Windows.Forms.ColumnHeader lvlHekimAdi;
        private System.Windows.Forms.ColumnHeader lvlHekimSoyadi;
        private System.Windows.Forms.ColumnHeader lvlDiplomaNo;
        private System.Windows.Forms.ColumnHeader lvlTckn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader lvlOlusturmaTarihi;
    }
}

namespace HastaKayıtSistemi
{
    partial class MuayeneListeleme
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
            this.lstMuayene = new System.Windows.Forms.ListView();
            this.lvlId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvlMuayeneTarihi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvlAileHekimi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvlHasta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvlMuayeneHastalik = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lvlOlusturmaTarihi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstMuayene
            // 
            this.lstMuayene.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvlId,
            this.lvlMuayeneTarihi,
            this.lvlAileHekimi,
            this.lvlHasta,
            this.lvlMuayeneHastalik,
            this.lvlOlusturmaTarihi});
            this.lstMuayene.ContextMenuStrip = this.contextMenuStrip1;
            this.lstMuayene.FullRowSelect = true;
            this.lstMuayene.GridLines = true;
            this.lstMuayene.HideSelection = false;
            this.lstMuayene.Location = new System.Drawing.Point(12, 12);
            this.lstMuayene.MultiSelect = false;
            this.lstMuayene.Name = "lstMuayene";
            this.lstMuayene.Size = new System.Drawing.Size(776, 426);
            this.lstMuayene.TabIndex = 1;
            this.lstMuayene.UseCompatibleStateImageBehavior = false;
            this.lstMuayene.View = System.Windows.Forms.View.Details;
            // 
            // lvlId
            // 
            this.lvlId.Text = "Id";
            this.lvlId.Width = 83;
            // 
            // lvlMuayeneTarihi
            // 
            this.lvlMuayeneTarihi.Text = "Muayene Tarihi";
            this.lvlMuayeneTarihi.Width = 143;
            // 
            // lvlAileHekimi
            // 
            this.lvlAileHekimi.Text = "Aile Hekimi";
            this.lvlAileHekimi.Width = 173;
            // 
            // lvlHasta
            // 
            this.lvlHasta.Text = "Hasta";
            this.lvlHasta.Width = 141;
            // 
            // lvlMuayeneHastalik
            // 
            this.lvlMuayeneHastalik.Text = "Hastaliklar";
            this.lvlMuayeneHastalik.Width = 87;
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
            this.lvlOlusturmaTarihi.Width = 101;
            // 
            // MuayeneListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstMuayene);
            this.Name = "MuayeneListeleme";
            this.Text = "MuayeneListeleme";
            this.Load += new System.EventHandler(this.MuayeneListeleme_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstMuayene;
        private System.Windows.Forms.ColumnHeader lvlId;
        private System.Windows.Forms.ColumnHeader lvlMuayeneTarihi;
        private System.Windows.Forms.ColumnHeader lvlAileHekimi;
        private System.Windows.Forms.ColumnHeader lvlHasta;
        private System.Windows.Forms.ColumnHeader lvlMuayeneHastalik;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader lvlOlusturmaTarihi;
    }
}
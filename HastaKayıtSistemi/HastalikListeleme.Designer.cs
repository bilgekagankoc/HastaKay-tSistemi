
namespace HastaKayıtSistemi
{
    partial class HastalikListeleme
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
            this.lstvHastalik = new System.Windows.Forms.ListView();
            this.lvlId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvlHastalikAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvlICD10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sİlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lvlOlusturmaTarihi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstvHastalik
            // 
            this.lstvHastalik.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvlId,
            this.lvlHastalikAdi,
            this.lvlICD10,
            this.lvlOlusturmaTarihi});
            this.lstvHastalik.ContextMenuStrip = this.contextMenuStrip1;
            this.lstvHastalik.FullRowSelect = true;
            this.lstvHastalik.GridLines = true;
            this.lstvHastalik.HideSelection = false;
            this.lstvHastalik.Location = new System.Drawing.Point(12, 12);
            this.lstvHastalik.MultiSelect = false;
            this.lstvHastalik.Name = "lstvHastalik";
            this.lstvHastalik.Size = new System.Drawing.Size(776, 426);
            this.lstvHastalik.TabIndex = 1;
            this.lstvHastalik.UseCompatibleStateImageBehavior = false;
            this.lstvHastalik.View = System.Windows.Forms.View.Details;
            // 
            // lvlId
            // 
            this.lvlId.Text = "Id";
            this.lvlId.Width = 83;
            // 
            // lvlHastalikAdi
            // 
            this.lvlHastalikAdi.Text = "HastalıkAdı";
            this.lvlHastalikAdi.Width = 189;
            // 
            // lvlICD10
            // 
            this.lvlICD10.Text = "ICD10";
            this.lvlICD10.Width = 144;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.düzenleToolStripMenuItem,
            this.sİlToolStripMenuItem});
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
            // sİlToolStripMenuItem
            // 
            this.sİlToolStripMenuItem.Name = "sİlToolStripMenuItem";
            this.sİlToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.sİlToolStripMenuItem.Text = "Sİl";
            this.sİlToolStripMenuItem.Click += new System.EventHandler(this.sİlToolStripMenuItem_Click);
            // 
            // lvlOlusturmaTarihi
            // 
            this.lvlOlusturmaTarihi.Text = "Oluşturma Tarihi";
            // 
            // HastalikListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstvHastalik);
            this.Name = "HastalikListeleme";
            this.Text = "HastalikListeleme";
            this.Load += new System.EventHandler(this.HastalikListeleme_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstvHastalik;
        private System.Windows.Forms.ColumnHeader lvlId;
        private System.Windows.Forms.ColumnHeader lvlHastalikAdi;
        private System.Windows.Forms.ColumnHeader lvlICD10;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sİlToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader lvlOlusturmaTarihi;
    }
}
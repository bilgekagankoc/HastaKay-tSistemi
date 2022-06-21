
namespace HastaKayıtSistemi
{
    partial class MuayeneEkle
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbmAileHekimi = new System.Windows.Forms.ComboBox();
            this.cmbHasta = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.chblbHastaliklar = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Aile Hekimi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Hasta";
            // 
            // cbmAileHekimi
            // 
            this.cbmAileHekimi.FormattingEnabled = true;
            this.cbmAileHekimi.Location = new System.Drawing.Point(109, 31);
            this.cbmAileHekimi.Name = "cbmAileHekimi";
            this.cbmAileHekimi.Size = new System.Drawing.Size(200, 21);
            this.cbmAileHekimi.TabIndex = 2;
            // 
            // cmbHasta
            // 
            this.cmbHasta.FormattingEnabled = true;
            this.cmbHasta.Location = new System.Drawing.Point(109, 63);
            this.cmbHasta.Name = "cmbHasta";
            this.cmbHasta.Size = new System.Drawing.Size(200, 21);
            this.cmbHasta.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hastalik";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(234, 282);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 5;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // chblbHastaliklar
            // 
            this.chblbHastaliklar.FormattingEnabled = true;
            this.chblbHastaliklar.Location = new System.Drawing.Point(109, 104);
            this.chblbHastaliklar.Name = "chblbHastaliklar";
            this.chblbHastaliklar.Size = new System.Drawing.Size(200, 154);
            this.chblbHastaliklar.TabIndex = 6;
            // 
            // MuayeneEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 466);
            this.Controls.Add(this.chblbHastaliklar);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbHasta);
            this.Controls.Add(this.cbmAileHekimi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "MuayeneEkle";
            this.Text = "MuayeneEkle";
            this.Load += new System.EventHandler(this.MuayeneEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbmAileHekimi;
        private System.Windows.Forms.ComboBox cmbHasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.CheckedListBox chblbHastaliklar;
    }
}
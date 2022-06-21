
namespace HastaKayıtSistemi
{
    partial class MuayeneDüzenleme
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
            this.chblbHastaliklar = new System.Windows.Forms.CheckedListBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbHasta = new System.Windows.Forms.ComboBox();
            this.cbmAileHekimi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chblbHastaliklar
            // 
            this.chblbHastaliklar.FormattingEnabled = true;
            this.chblbHastaliklar.Location = new System.Drawing.Point(104, 117);
            this.chblbHastaliklar.Name = "chblbHastaliklar";
            this.chblbHastaliklar.Size = new System.Drawing.Size(200, 154);
            this.chblbHastaliklar.TabIndex = 13;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(229, 295);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 12;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Hastalik";
            // 
            // cmbHasta
            // 
            this.cmbHasta.FormattingEnabled = true;
            this.cmbHasta.Location = new System.Drawing.Point(104, 76);
            this.cmbHasta.Name = "cmbHasta";
            this.cmbHasta.Size = new System.Drawing.Size(200, 21);
            this.cmbHasta.TabIndex = 9;
            // 
            // cbmAileHekimi
            // 
            this.cbmAileHekimi.FormattingEnabled = true;
            this.cbmAileHekimi.Location = new System.Drawing.Point(104, 44);
            this.cbmAileHekimi.Name = "cbmAileHekimi";
            this.cbmAileHekimi.Size = new System.Drawing.Size(200, 21);
            this.cbmAileHekimi.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Aile Hekimi";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(29, 13);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(16, 13);
            this.label.TabIndex = 14;
            this.label.Text = "Id";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(79, 13);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 13);
            this.lblId.TabIndex = 15;
            // 
            // MuayeneDüzenleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 373);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.label);
            this.Controls.Add(this.chblbHastaliklar);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbHasta);
            this.Controls.Add(this.cbmAileHekimi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "MuayeneDüzenleme";
            this.Text = "MuayeneDüzenleme";
            this.Load += new System.EventHandler(this.MuayeneDüzenleme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.CheckedListBox chblbHastaliklar;
        public System.Windows.Forms.ComboBox cmbHasta;
        public System.Windows.Forms.ComboBox cbmAileHekimi;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btnKaydet;
        public System.Windows.Forms.Label lblId;
    }
}
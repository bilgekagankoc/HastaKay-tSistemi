
namespace HastaKayitSistemi
{
    partial class AileHekimEkle
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
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTckn = new System.Windows.Forms.TextBox();
            this.txtDiplomaNo = new System.Windows.Forms.TextBox();
            this.txtHekimSoyadi = new System.Windows.Forms.TextBox();
            this.txtHekimAdi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(200, 125);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "TCKN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Diploma No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Hekim Soyadı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Hekim Adı";
            // 
            // txtTckn
            // 
            this.txtTckn.Location = new System.Drawing.Point(154, 93);
            this.txtTckn.Name = "txtTckn";
            this.txtTckn.Size = new System.Drawing.Size(121, 20);
            this.txtTckn.TabIndex = 3;
            // 
            // txtDiplomaNo
            // 
            this.txtDiplomaNo.Location = new System.Drawing.Point(154, 67);
            this.txtDiplomaNo.Name = "txtDiplomaNo";
            this.txtDiplomaNo.Size = new System.Drawing.Size(121, 20);
            this.txtDiplomaNo.TabIndex = 2;
            // 
            // txtHekimSoyadi
            // 
            this.txtHekimSoyadi.Location = new System.Drawing.Point(154, 41);
            this.txtHekimSoyadi.Name = "txtHekimSoyadi";
            this.txtHekimSoyadi.Size = new System.Drawing.Size(121, 20);
            this.txtHekimSoyadi.TabIndex = 1;
            // 
            // txtHekimAdi
            // 
            this.txtHekimAdi.Location = new System.Drawing.Point(154, 15);
            this.txtHekimAdi.Name = "txtHekimAdi";
            this.txtHekimAdi.Size = new System.Drawing.Size(121, 20);
            this.txtHekimAdi.TabIndex = 0;
            // 
            // AileHekimEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 160);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTckn);
            this.Controls.Add(this.txtDiplomaNo);
            this.Controls.Add(this.txtHekimSoyadi);
            this.Controls.Add(this.txtHekimAdi);
            this.Name = "AileHekimEkle";
            this.Text = "Aİle Hekim Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTckn;
        private System.Windows.Forms.TextBox txtDiplomaNo;
        private System.Windows.Forms.TextBox txtHekimSoyadi;
        private System.Windows.Forms.TextBox txtHekimAdi;
    }
}


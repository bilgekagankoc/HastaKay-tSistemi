
namespace HastaKayıtSistemi
{
    partial class HastalikEkle
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHastalikAdi = new System.Windows.Forms.TextBox();
            this.txtICD10 = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hastalik Adi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ICD10";
            // 
            // txtHastalikAdi
            // 
            this.txtHastalikAdi.Location = new System.Drawing.Point(133, 31);
            this.txtHastalikAdi.Name = "txtHastalikAdi";
            this.txtHastalikAdi.Size = new System.Drawing.Size(100, 20);
            this.txtHastalikAdi.TabIndex = 2;
            // 
            // txtICD10
            // 
            this.txtICD10.Location = new System.Drawing.Point(133, 61);
            this.txtICD10.Name = "txtICD10";
            this.txtICD10.Size = new System.Drawing.Size(100, 20);
            this.txtICD10.TabIndex = 2;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(158, 87);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // HastalikEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 144);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtICD10);
            this.Controls.Add(this.txtHastalikAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HastalikEkle";
            this.Text = "Hastalik Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHastalikAdi;
        private System.Windows.Forms.TextBox txtICD10;
        private System.Windows.Forms.Button btnKaydet;
    }
}

namespace HastaKayıtSistemi
{
    partial class AileHekimiDüzenleme
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
            this.lblId = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTckn = new System.Windows.Forms.TextBox();
            this.txtDiplomaNo = new System.Windows.Forms.TextBox();
            this.txtHekimSoyadi = new System.Windows.Forms.TextBox();
            this.txtHekimAdi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(86, 9);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 13);
            this.lblId.TabIndex = 0;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(199, 134);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 19;
            this.btnKaydet.Text = "Düzenle";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "TCKN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Diploma No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Hekim Soyadı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Hekim Adı";
            // 
            // txtTckn
            // 
            this.txtTckn.Location = new System.Drawing.Point(153, 108);
            this.txtTckn.Name = "txtTckn";
            this.txtTckn.Size = new System.Drawing.Size(121, 20);
            this.txtTckn.TabIndex = 18;
            // 
            // txtDiplomaNo
            // 
            this.txtDiplomaNo.Location = new System.Drawing.Point(153, 82);
            this.txtDiplomaNo.Name = "txtDiplomaNo";
            this.txtDiplomaNo.Size = new System.Drawing.Size(121, 20);
            this.txtDiplomaNo.TabIndex = 17;
            // 
            // txtHekimSoyadi
            // 
            this.txtHekimSoyadi.Location = new System.Drawing.Point(153, 56);
            this.txtHekimSoyadi.Name = "txtHekimSoyadi";
            this.txtHekimSoyadi.Size = new System.Drawing.Size(121, 20);
            this.txtHekimSoyadi.TabIndex = 16;
            // 
            // txtHekimAdi
            // 
            this.txtHekimAdi.Location = new System.Drawing.Point(153, 30);
            this.txtHekimAdi.Name = "txtHekimAdi";
            this.txtHekimAdi.Size = new System.Drawing.Size(121, 20);
            this.txtHekimAdi.TabIndex = 15;
            // 
            // AileHekimiDüzenleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 201);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTckn);
            this.Controls.Add(this.txtDiplomaNo);
            this.Controls.Add(this.txtHekimSoyadi);
            this.Controls.Add(this.txtHekimAdi);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.label1);
            this.Name = "AileHekimiDüzenleme";
            this.Text = "AileHekimiDüzenleme";
            this.Load += new System.EventHandler(this.AileHekimiDüzenleme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblId;
        public System.Windows.Forms.TextBox txtTckn;
        public System.Windows.Forms.TextBox txtDiplomaNo;
        public System.Windows.Forms.TextBox txtHekimSoyadi;
        public System.Windows.Forms.TextBox txtHekimAdi;
    }
}
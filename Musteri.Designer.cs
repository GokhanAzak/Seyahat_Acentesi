
namespace GeçtimTurizim
{
    partial class Musteri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Musteri));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Musteri_isim = new System.Windows.Forms.TextBox();
            this.txt_Musteri_soyad = new System.Windows.Forms.TextBox();
            this.txt_Musteri_cinsiyet = new System.Windows.Forms.TextBox();
            this.txt_Musteri_telefon = new System.Windows.Forms.TextBox();
            this.btn_Musteri_Kayit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyisim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "cinsiyet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefon";
            // 
            // txt_Musteri_isim
            // 
            this.txt_Musteri_isim.Location = new System.Drawing.Point(127, 70);
            this.txt_Musteri_isim.Name = "txt_Musteri_isim";
            this.txt_Musteri_isim.Size = new System.Drawing.Size(100, 22);
            this.txt_Musteri_isim.TabIndex = 4;
            // 
            // txt_Musteri_soyad
            // 
            this.txt_Musteri_soyad.Location = new System.Drawing.Point(127, 112);
            this.txt_Musteri_soyad.Name = "txt_Musteri_soyad";
            this.txt_Musteri_soyad.Size = new System.Drawing.Size(100, 22);
            this.txt_Musteri_soyad.TabIndex = 5;
            // 
            // txt_Musteri_cinsiyet
            // 
            this.txt_Musteri_cinsiyet.Location = new System.Drawing.Point(127, 156);
            this.txt_Musteri_cinsiyet.Name = "txt_Musteri_cinsiyet";
            this.txt_Musteri_cinsiyet.Size = new System.Drawing.Size(100, 22);
            this.txt_Musteri_cinsiyet.TabIndex = 6;
            // 
            // txt_Musteri_telefon
            // 
            this.txt_Musteri_telefon.Location = new System.Drawing.Point(127, 198);
            this.txt_Musteri_telefon.Name = "txt_Musteri_telefon";
            this.txt_Musteri_telefon.Size = new System.Drawing.Size(100, 22);
            this.txt_Musteri_telefon.TabIndex = 7;
            // 
            // btn_Musteri_Kayit
            // 
            this.btn_Musteri_Kayit.Location = new System.Drawing.Point(127, 240);
            this.btn_Musteri_Kayit.Name = "btn_Musteri_Kayit";
            this.btn_Musteri_Kayit.Size = new System.Drawing.Size(100, 33);
            this.btn_Musteri_Kayit.TabIndex = 8;
            this.btn_Musteri_Kayit.Text = "Kayit";
            this.btn_Musteri_Kayit.UseVisualStyleBackColor = true;
            this.btn_Musteri_Kayit.Click += new System.EventHandler(this.btn_Musteri_Kayit_Click);
            // 
            // Musteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 450);
            this.Controls.Add(this.btn_Musteri_Kayit);
            this.Controls.Add(this.txt_Musteri_telefon);
            this.Controls.Add(this.txt_Musteri_cinsiyet);
            this.Controls.Add(this.txt_Musteri_soyad);
            this.Controls.Add(this.txt_Musteri_isim);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Musteri";
            this.Text = "Müşteri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Musteri_isim;
        private System.Windows.Forms.TextBox txt_Musteri_soyad;
        private System.Windows.Forms.TextBox txt_Musteri_cinsiyet;
        private System.Windows.Forms.TextBox txt_Musteri_telefon;
        private System.Windows.Forms.Button btn_Musteri_Kayit;
    }
}
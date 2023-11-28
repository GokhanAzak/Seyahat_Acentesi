
namespace GeçtimTurizim
{
    partial class YetkiliContorlForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YetkiliContorlForm));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_PersonelGiris = new System.Windows.Forms.Button();
            this.beniHatırla = new System.Windows.Forms.CheckBox();
            this.btn_PersonelKayıtTıklayınız = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(155, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(155, 138);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Parola";
            // 
            // Btn_PersonelGiris
            // 
            this.Btn_PersonelGiris.Location = new System.Drawing.Point(155, 197);
            this.Btn_PersonelGiris.Name = "Btn_PersonelGiris";
            this.Btn_PersonelGiris.Size = new System.Drawing.Size(82, 28);
            this.Btn_PersonelGiris.TabIndex = 4;
            this.Btn_PersonelGiris.Text = "Giriş";
            this.Btn_PersonelGiris.UseVisualStyleBackColor = true;
            // 
            // beniHatırla
            // 
            this.beniHatırla.AutoSize = true;
            this.beniHatırla.Location = new System.Drawing.Point(155, 170);
            this.beniHatırla.Name = "beniHatırla";
            this.beniHatırla.Size = new System.Drawing.Size(103, 21);
            this.beniHatırla.TabIndex = 5;
            this.beniHatırla.Text = "Beni Hatırla";
            this.beniHatırla.UseVisualStyleBackColor = true;
            // 
            // btn_PersonelKayıtTıklayınız
            // 
            this.btn_PersonelKayıtTıklayınız.Location = new System.Drawing.Point(519, 122);
            this.btn_PersonelKayıtTıklayınız.Name = "btn_PersonelKayıtTıklayınız";
            this.btn_PersonelKayıtTıklayınız.Size = new System.Drawing.Size(85, 36);
            this.btn_PersonelKayıtTıklayınız.TabIndex = 6;
            this.btn_PersonelKayıtTıklayınız.Text = "Tıklayınız";
            this.btn_PersonelKayıtTıklayınız.UseVisualStyleBackColor = true;
            this.btn_PersonelKayıtTıklayınız.Click += new System.EventHandler(this.btn_PersonelKayıtTıklayınız_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(466, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Personel Kayıt İçin Tıklayınız";
            // 
            // YetkiliContorlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 377);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_PersonelKayıtTıklayınız);
            this.Controls.Add(this.beniHatırla);
            this.Controls.Add(this.Btn_PersonelGiris);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "YetkiliContorlForm";
            this.Text = "Personel Giriş";
            this.Load += new System.EventHandler(this.YetkiliContorlForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_PersonelGiris;
        private System.Windows.Forms.CheckBox beniHatırla;
        private System.Windows.Forms.Button btn_PersonelKayıtTıklayınız;
        private System.Windows.Forms.Label label3;
    }
}
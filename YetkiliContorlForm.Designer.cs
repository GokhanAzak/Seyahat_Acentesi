
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
            this.txt_KullaniciAdi = new System.Windows.Forms.TextBox();
            this.txt_Parola = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.beniHatırla = new System.Windows.Forms.CheckBox();
            this.btn_PersonelKayıtTıklayınız = new System.Windows.Forms.Button();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Btn_PersonelGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_KullaniciAdi
            // 
            this.txt_KullaniciAdi.Location = new System.Drawing.Point(115, 84);
            this.txt_KullaniciAdi.Name = "txt_KullaniciAdi";
            this.txt_KullaniciAdi.Size = new System.Drawing.Size(100, 22);
            this.txt_KullaniciAdi.TabIndex = 0;
            // 
            // txt_Parola
            // 
            this.txt_Parola.Location = new System.Drawing.Point(115, 145);
            this.txt_Parola.Name = "txt_Parola";
            this.txt_Parola.Size = new System.Drawing.Size(100, 22);
            this.txt_Parola.TabIndex = 1;
            this.txt_Parola.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Parola";
            // 
            // beniHatırla
            // 
            this.beniHatırla.AutoSize = true;
            this.beniHatırla.Location = new System.Drawing.Point(115, 193);
            this.beniHatırla.Name = "beniHatırla";
            this.beniHatırla.Size = new System.Drawing.Size(98, 20);
            this.beniHatırla.TabIndex = 5;
            this.beniHatırla.Text = "Beni Hatırla";
            this.beniHatırla.UseVisualStyleBackColor = true;
            // 
            // btn_PersonelKayıtTıklayınız
            // 
            this.btn_PersonelKayıtTıklayınız.ImageKey = "(none)";
            this.btn_PersonelKayıtTıklayınız.Location = new System.Drawing.Point(504, 111);
            this.btn_PersonelKayıtTıklayınız.Name = "btn_PersonelKayıtTıklayınız";
            this.btn_PersonelKayıtTıklayınız.Size = new System.Drawing.Size(159, 53);
            this.btn_PersonelKayıtTıklayınız.TabIndex = 6;
            this.btn_PersonelKayıtTıklayınız.Text = "Personel Kayıt İçin Tıklayınız";
            this.btn_PersonelKayıtTıklayınız.UseVisualStyleBackColor = true;
            this.btn_PersonelKayıtTıklayınız.Click += new System.EventHandler(this.btn_PersonelKayıtTıklayınız_Click);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Image = global::GeçtimTurizim.Properties.Resources._3994415_account_avatar_person_profile_user_icon1;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.Location = new System.Drawing.Point(287, 0);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Size = new System.Drawing.Size(107, 75);
            this.guna2ImageButton1.TabIndex = 7;
            // 
            // Btn_PersonelGiris
            // 
            this.Btn_PersonelGiris.BackgroundImage = global::GeçtimTurizim.Properties.Resources.denem1;
            this.Btn_PersonelGiris.ForeColor = System.Drawing.Color.Lime;
            this.Btn_PersonelGiris.Location = new System.Drawing.Point(93, 245);
            this.Btn_PersonelGiris.Name = "Btn_PersonelGiris";
            this.Btn_PersonelGiris.Size = new System.Drawing.Size(122, 33);
            this.Btn_PersonelGiris.TabIndex = 4;
            this.Btn_PersonelGiris.Text = "Giriş";
            this.Btn_PersonelGiris.UseVisualStyleBackColor = true;
            this.Btn_PersonelGiris.Click += new System.EventHandler(this.btn_PersonelGiris_Click);
            // 
            // YetkiliContorlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(693, 377);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.btn_PersonelKayıtTıklayınız);
            this.Controls.Add(this.beniHatırla);
            this.Controls.Add(this.Btn_PersonelGiris);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Parola);
            this.Controls.Add(this.txt_KullaniciAdi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "YetkiliContorlForm";
            this.Text = "Personel Giriş";
            this.Load += new System.EventHandler(this.YetkiliContorlForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_KullaniciAdi;
        private System.Windows.Forms.TextBox txt_Parola;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_PersonelGiris;
        private System.Windows.Forms.CheckBox beniHatırla;
        private System.Windows.Forms.Button btn_PersonelKayıtTıklayınız;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
    }
}
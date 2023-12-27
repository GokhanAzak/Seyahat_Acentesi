
namespace GeçtimTurizim
{
    partial class AnaSayfaForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfaForm));
            this.btn_BiletİişlemTıklama = new System.Windows.Forms.Button();
            this.btn_MusteriIslemTıklama = new System.Windows.Forms.Button();
            this.btn_YetkiliGirişTıkla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_BiletİişlemTıklama
            // 
            this.btn_BiletİişlemTıklama.Location = new System.Drawing.Point(39, 175);
            this.btn_BiletİişlemTıklama.Name = "btn_BiletİişlemTıklama";
            this.btn_BiletİişlemTıklama.Size = new System.Drawing.Size(109, 51);
            this.btn_BiletİişlemTıklama.TabIndex = 0;
            this.btn_BiletİişlemTıklama.Text = "Bilet İşlemleri İçin Tıklaynız";
            this.btn_BiletİişlemTıklama.UseVisualStyleBackColor = true;
            this.btn_BiletİişlemTıklama.Click += new System.EventHandler(this.btn_BiletAlTıklama_Click);
            // 
            // btn_MusteriIslemTıklama
            // 
            this.btn_MusteriIslemTıklama.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.btn_MusteriIslemTıklama.Location = new System.Drawing.Point(297, 175);
            this.btn_MusteriIslemTıklama.Name = "btn_MusteriIslemTıklama";
            this.btn_MusteriIslemTıklama.Size = new System.Drawing.Size(99, 51);
            this.btn_MusteriIslemTıklama.TabIndex = 2;
            this.btn_MusteriIslemTıklama.Text = "Müşteri İşemleri İçin tıklayınız";
            this.btn_MusteriIslemTıklama.UseVisualStyleBackColor = true;
            this.btn_MusteriIslemTıklama.Click += new System.EventHandler(this.btn_MusteriIslemTıklama_Click);
            // 
            // btn_YetkiliGirişTıkla
            // 
            this.btn_YetkiliGirişTıkla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_YetkiliGirişTıkla.Location = new System.Drawing.Point(565, 175);
            this.btn_YetkiliGirişTıkla.Name = "btn_YetkiliGirişTıkla";
            this.btn_YetkiliGirişTıkla.Size = new System.Drawing.Size(111, 51);
            this.btn_YetkiliGirişTıkla.TabIndex = 4;
            this.btn_YetkiliGirişTıkla.Text = "Personel Giriş";
            this.btn_YetkiliGirişTıkla.UseVisualStyleBackColor = true;
            this.btn_YetkiliGirişTıkla.Click += new System.EventHandler(this.btn_YetkiliGirişTıkla_Click);
            // 
            // AnaSayfaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GeçtimTurizim.Properties.Resources.denem1;
            this.ClientSize = new System.Drawing.Size(728, 447);
            this.Controls.Add(this.btn_YetkiliGirişTıkla);
            this.Controls.Add(this.btn_MusteriIslemTıklama);
            this.Controls.Add(this.btn_BiletİişlemTıklama);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnaSayfaForm";
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.AnaSayfaForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_BiletİişlemTıklama;
        private System.Windows.Forms.Button btn_MusteriIslemTıklama;
        private System.Windows.Forms.Button btn_YetkiliGirişTıkla;
    }
}


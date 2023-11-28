
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
            this.Label_BiletIslem = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_MusteriIslemTıklama = new System.Windows.Forms.Button();
            this.btn_YetkiliGirişTıkla = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_BiletİişlemTıklama
            // 
            this.btn_BiletİişlemTıklama.Location = new System.Drawing.Point(309, 162);
            this.btn_BiletİişlemTıklama.Name = "btn_BiletİişlemTıklama";
            this.btn_BiletİişlemTıklama.Size = new System.Drawing.Size(99, 51);
            this.btn_BiletİişlemTıklama.TabIndex = 0;
            this.btn_BiletİişlemTıklama.Text = "Tıklayınız";
            this.btn_BiletİişlemTıklama.UseVisualStyleBackColor = true;
            this.btn_BiletİişlemTıklama.Click += new System.EventHandler(this.btn_BiletAlTıklama_Click);
            // 
            // Label_BiletIslem
            // 
            this.Label_BiletIslem.AutoSize = true;
            this.Label_BiletIslem.Location = new System.Drawing.Point(275, 101);
            this.Label_BiletIslem.Name = "Label_BiletIslem";
            this.Label_BiletIslem.Size = new System.Drawing.Size(173, 16);
            this.Label_BiletIslem.TabIndex = 1;
            this.Label_BiletIslem.Text = "Bilet İşlemleri İçin Tıklayanız";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Müşteri İşlemleri İçin Tıklayanız";
            // 
            // btn_MusteriIslemTıklama
            // 
            this.btn_MusteriIslemTıklama.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.btn_MusteriIslemTıklama.Location = new System.Drawing.Point(60, 161);
            this.btn_MusteriIslemTıklama.Name = "btn_MusteriIslemTıklama";
            this.btn_MusteriIslemTıklama.Size = new System.Drawing.Size(99, 51);
            this.btn_MusteriIslemTıklama.TabIndex = 2;
            this.btn_MusteriIslemTıklama.Text = "Tıklayınız";
            this.btn_MusteriIslemTıklama.UseVisualStyleBackColor = true;
            this.btn_MusteriIslemTıklama.Click += new System.EventHandler(this.btn_MusteriIslemTıklama_Click);
            // 
            // btn_YetkiliGirişTıkla
            // 
            this.btn_YetkiliGirişTıkla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_YetkiliGirişTıkla.Location = new System.Drawing.Point(562, 161);
            this.btn_YetkiliGirişTıkla.Name = "btn_YetkiliGirişTıkla";
            this.btn_YetkiliGirişTıkla.Size = new System.Drawing.Size(111, 51);
            this.btn_YetkiliGirişTıkla.TabIndex = 4;
            this.btn_YetkiliGirişTıkla.Text = "Tıklayınız";
            this.btn_YetkiliGirişTıkla.UseVisualStyleBackColor = true;
            this.btn_YetkiliGirişTıkla.Click += new System.EventHandler(this.btn_YetkiliGirişTıkla_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label2.Location = new System.Drawing.Point(543, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Yetkili Giriş İçin Tıklayınız";
            // 
            // AnaSayfaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GeçtimTurizim.Properties.Resources.denem1;
            this.ClientSize = new System.Drawing.Size(728, 447);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_YetkiliGirişTıkla);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_MusteriIslemTıklama);
            this.Controls.Add(this.Label_BiletIslem);
            this.Controls.Add(this.btn_BiletİişlemTıklama);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnaSayfaForm";
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.AnaSayfaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_BiletİişlemTıklama;
        private System.Windows.Forms.Label Label_BiletIslem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_MusteriIslemTıklama;
        private System.Windows.Forms.Button btn_YetkiliGirişTıkla;
        private System.Windows.Forms.Label label2;
    }
}


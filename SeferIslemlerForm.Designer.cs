using System;

namespace GeçtimTurizim
{
    partial class SeferIslemlerForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeferIslemlerForm));
            this.txt_Kalkis = new System.Windows.Forms.TextBox();
            this.labelsefer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Varis = new System.Windows.Forms.TextBox();
            this.txt_Tarih = new System.Windows.Forms.MaskedTextBox();
            this.txt_SeferıdSil = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_yeni_tarih = new System.Windows.Forms.MaskedTextBox();
            this.txt_Guncelle_Varıs = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_GidisGuncelle = new System.Windows.Forms.TextBox();
            this.txt_seferIdGuncelle = new System.Windows.Forms.TextBox();
            this.txt_Ucret = new System.Windows.Forms.TextBox();
            this.Txt_Sefer_Muavin = new System.Windows.Forms.TextBox();
            this.txt_Sefer_sofor = new System.Windows.Forms.TextBox();
            this.txt_YeniUcret = new System.Windows.Forms.TextBox();
            this.txt_YeniMuavin = new System.Windows.Forms.TextBox();
            this.txt_YeniSofor = new System.Windows.Forms.TextBox();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_GunaGuncelle = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Btn_GunaSeferEkle = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Kalkis
            // 
            this.txt_Kalkis.Location = new System.Drawing.Point(99, 67);
            this.txt_Kalkis.Name = "txt_Kalkis";
            this.txt_Kalkis.Size = new System.Drawing.Size(100, 22);
            this.txt_Kalkis.TabIndex = 0;
            // 
            // labelsefer
            // 
            this.labelsefer.AutoSize = true;
            this.labelsefer.Location = new System.Drawing.Point(96, 15);
            this.labelsefer.Name = "labelsefer";
            this.labelsefer.Size = new System.Drawing.Size(98, 16);
            this.labelsefer.TabIndex = 1;
            this.labelsefer.Text = "Sefer Bilgi Giriş";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gidiş";
            // 
            // txt_Varis
            // 
            this.txt_Varis.Location = new System.Drawing.Point(99, 121);
            this.txt_Varis.Name = "txt_Varis";
            this.txt_Varis.Size = new System.Drawing.Size(100, 22);
            this.txt_Varis.TabIndex = 4;
            // 
            // txt_Tarih
            // 
            this.txt_Tarih.Location = new System.Drawing.Point(99, 177);
            this.txt_Tarih.Mask = "00/00/0000";
            this.txt_Tarih.Name = "txt_Tarih";
            this.txt_Tarih.Size = new System.Drawing.Size(100, 22);
            this.txt_Tarih.TabIndex = 7;
            this.txt_Tarih.ValidatingType = typeof(System.DateTime);
            // 
            // txt_SeferıdSil
            // 
            this.txt_SeferıdSil.Location = new System.Drawing.Point(493, 82);
            this.txt_SeferıdSil.Name = "txt_SeferıdSil";
            this.txt_SeferıdSil.Size = new System.Drawing.Size(100, 22);
            this.txt_SeferıdSil.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(524, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Sefer Sil";
            // 
            // txt_yeni_tarih
            // 
            this.txt_yeni_tarih.Location = new System.Drawing.Point(1181, 114);
            this.txt_yeni_tarih.Mask = "00/00/0000";
            this.txt_yeni_tarih.Name = "txt_yeni_tarih";
            this.txt_yeni_tarih.Size = new System.Drawing.Size(100, 22);
            this.txt_yeni_tarih.TabIndex = 19;
            this.txt_yeni_tarih.ValidatingType = typeof(System.DateTime);
            // 
            // txt_Guncelle_Varıs
            // 
            this.txt_Guncelle_Varıs.Location = new System.Drawing.Point(1181, 70);
            this.txt_Guncelle_Varıs.Name = "txt_Guncelle_Varıs";
            this.txt_Guncelle_Varıs.Size = new System.Drawing.Size(100, 22);
            this.txt_Guncelle_Varıs.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1029, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "Sefer Güncelleme";
            // 
            // txt_GidisGuncelle
            // 
            this.txt_GidisGuncelle.Location = new System.Drawing.Point(949, 133);
            this.txt_GidisGuncelle.Name = "txt_GidisGuncelle";
            this.txt_GidisGuncelle.Size = new System.Drawing.Size(100, 22);
            this.txt_GidisGuncelle.TabIndex = 13;
            // 
            // txt_seferIdGuncelle
            // 
            this.txt_seferIdGuncelle.Location = new System.Drawing.Point(949, 75);
            this.txt_seferIdGuncelle.Name = "txt_seferIdGuncelle";
            this.txt_seferIdGuncelle.Size = new System.Drawing.Size(100, 22);
            this.txt_seferIdGuncelle.TabIndex = 22;
            // 
            // txt_Ucret
            // 
            this.txt_Ucret.Location = new System.Drawing.Point(99, 225);
            this.txt_Ucret.Name = "txt_Ucret";
            this.txt_Ucret.Size = new System.Drawing.Size(100, 22);
            this.txt_Ucret.TabIndex = 25;
            // 
            // Txt_Sefer_Muavin
            // 
            this.Txt_Sefer_Muavin.Location = new System.Drawing.Point(99, 292);
            this.Txt_Sefer_Muavin.Name = "Txt_Sefer_Muavin";
            this.Txt_Sefer_Muavin.Size = new System.Drawing.Size(100, 22);
            this.Txt_Sefer_Muavin.TabIndex = 29;
            // 
            // txt_Sefer_sofor
            // 
            this.txt_Sefer_sofor.Location = new System.Drawing.Point(99, 256);
            this.txt_Sefer_sofor.Name = "txt_Sefer_sofor";
            this.txt_Sefer_sofor.Size = new System.Drawing.Size(100, 22);
            this.txt_Sefer_sofor.TabIndex = 27;
            // 
            // txt_YeniUcret
            // 
            this.txt_YeniUcret.Location = new System.Drawing.Point(1181, 148);
            this.txt_YeniUcret.Name = "txt_YeniUcret";
            this.txt_YeniUcret.Size = new System.Drawing.Size(100, 22);
            this.txt_YeniUcret.TabIndex = 31;
            // 
            // txt_YeniMuavin
            // 
            this.txt_YeniMuavin.Location = new System.Drawing.Point(1181, 193);
            this.txt_YeniMuavin.Name = "txt_YeniMuavin";
            this.txt_YeniMuavin.Size = new System.Drawing.Size(100, 22);
            this.txt_YeniMuavin.TabIndex = 35;
            // 
            // txt_YeniSofor
            // 
            this.txt_YeniSofor.Location = new System.Drawing.Point(949, 182);
            this.txt_YeniSofor.Name = "txt_YeniSofor";
            this.txt_YeniSofor.Size = new System.Drawing.Size(100, 22);
            this.txt_YeniSofor.TabIndex = 33;
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btn_GunaGuncelle
            // 
            this.btn_GunaGuncelle.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_GunaGuncelle.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_GunaGuncelle.Image = global::GeçtimTurizim.Properties.Resources._9110400_refresh_reverse_icon;
            this.btn_GunaGuncelle.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_GunaGuncelle.ImageRotate = 0F;
            this.btn_GunaGuncelle.Location = new System.Drawing.Point(980, 244);
            this.btn_GunaGuncelle.Name = "btn_GunaGuncelle";
            this.btn_GunaGuncelle.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_GunaGuncelle.Size = new System.Drawing.Size(266, 86);
            this.btn_GunaGuncelle.TabIndex = 40;
            this.btn_GunaGuncelle.Click += new System.EventHandler(this.btn_GunaGuncelle_Click);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Image = global::GeçtimTurizim.Properties.Resources._6217199_bus_coronavirus_prohibited_travel_icon;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.Location = new System.Drawing.Point(441, 110);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Size = new System.Drawing.Size(214, 78);
            this.guna2ImageButton1.TabIndex = 39;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // Btn_GunaSeferEkle
            // 
            this.Btn_GunaSeferEkle.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.Btn_GunaSeferEkle.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.Btn_GunaSeferEkle.Image = global::GeçtimTurizim.Properties.Resources._134144_bus_transportation_icon;
            this.Btn_GunaSeferEkle.ImageOffset = new System.Drawing.Point(0, 0);
            this.Btn_GunaSeferEkle.ImageRotate = 0F;
            this.Btn_GunaSeferEkle.Location = new System.Drawing.Point(50, 342);
            this.Btn_GunaSeferEkle.Name = "Btn_GunaSeferEkle";
            this.Btn_GunaSeferEkle.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.Btn_GunaSeferEkle.Size = new System.Drawing.Size(179, 65);
            this.Btn_GunaSeferEkle.TabIndex = 38;
            this.Btn_GunaSeferEkle.Click += new System.EventHandler(this.Btn_GunaSeferEkle_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Rockwell", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(10, 255);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 23);
            this.label17.TabIndex = 42;
            this.label17.Text = "Söför";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Rockwell", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(10, 291);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(75, 23);
            this.label18.TabIndex = 43;
            this.label18.Text = "Muvain";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Rockwell", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(12, 121);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(55, 23);
            this.label19.TabIndex = 44;
            this.label19.Text = "Varış";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Rockwell", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(10, 225);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 23);
            this.label16.TabIndex = 45;
            this.label16.Text = "Ücret";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Rockwell", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(12, 181);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(57, 23);
            this.label20.TabIndex = 46;
            this.label20.Text = "Tarih";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(358, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 23);
            this.label2.TabIndex = 47;
            this.label2.Text = "SEFERID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(841, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 23);
            this.label3.TabIndex = 48;
            this.label3.Text = "SEFERID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1099, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 23);
            this.label4.TabIndex = 54;
            this.label4.Text = "Tarih";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Rockwell", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1099, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 23);
            this.label10.TabIndex = 53;
            this.label10.Text = "Ücret";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Rockwell", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1101, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 23);
            this.label11.TabIndex = 52;
            this.label11.Text = "Varış";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Rockwell", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1081, 192);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 23);
            this.label12.TabIndex = 51;
            this.label12.Text = "Muvain";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Rockwell", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(874, 182);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(53, 23);
            this.label21.TabIndex = 50;
            this.label21.Text = "Söför";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Rockwell", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(860, 133);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(57, 23);
            this.label22.TabIndex = 49;
            this.label22.Text = "Gidiş";
            // 
            // SeferIslemlerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1415, 533);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btn_GunaGuncelle);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.Btn_GunaSeferEkle);
            this.Controls.Add(this.txt_YeniMuavin);
            this.Controls.Add(this.txt_YeniSofor);
            this.Controls.Add(this.txt_YeniUcret);
            this.Controls.Add(this.Txt_Sefer_Muavin);
            this.Controls.Add(this.txt_Sefer_sofor);
            this.Controls.Add(this.txt_Ucret);
            this.Controls.Add(this.txt_seferIdGuncelle);
            this.Controls.Add(this.txt_yeni_tarih);
            this.Controls.Add(this.txt_Guncelle_Varıs);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_GidisGuncelle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_SeferıdSil);
            this.Controls.Add(this.txt_Tarih);
            this.Controls.Add(this.txt_Varis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelsefer);
            this.Controls.Add(this.txt_Kalkis);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SeferIslemlerForm";
            this.Text = "SeferIslemlerForm";
            this.Load += new System.EventHandler(this.SeferIslemlerForm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Kalkis;
        private System.Windows.Forms.Label labelsefer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Varis;
        private System.Windows.Forms.MaskedTextBox txt_Tarih;
        private System.Windows.Forms.TextBox txt_SeferıdSil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txt_yeni_tarih;
        private System.Windows.Forms.TextBox txt_Guncelle_Varıs;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_GidisGuncelle;
        private System.Windows.Forms.TextBox txt_seferIdGuncelle;
        private System.Windows.Forms.TextBox txt_Ucret;
        private System.Windows.Forms.TextBox Txt_Sefer_Muavin;
        private System.Windows.Forms.TextBox txt_Sefer_sofor;
        private System.Windows.Forms.TextBox txt_YeniUcret;
        private System.Windows.Forms.TextBox txt_YeniMuavin;
        private System.Windows.Forms.TextBox txt_YeniSofor;
        private System.Diagnostics.PerformanceCounter performanceCounter1;
        private EventHandler btn_SeferSil_Click;
        private EventHandler btn_SeferGuncelle_Click;
        private EventHandler SeferIslemlerForm_Load;
        private readonly EventHandler label13_Click;
        private System.Windows.Forms.ImageList ımageList1;
        private Guna.UI2.WinForms.Guna2ImageButton Btn_GunaSeferEkle;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2ImageButton btn_GunaGuncelle;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
    }
}
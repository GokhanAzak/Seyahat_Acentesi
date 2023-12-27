
namespace GeçtimTurizim
{
    partial class PersonelKayıt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelKayıt));
            this.btn_personelKayıt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_personelKayıtGorev = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_personelKayıtİsim = new System.Windows.Forms.TextBox();
            this.txt_personelkayıtSoyisim = new System.Windows.Forms.TextBox();
            this.txt_personelgorev = new System.Windows.Forms.TextBox();
            this.text_personelKayıtSifre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_personelKayıt
            // 
            this.btn_personelKayıt.Location = new System.Drawing.Point(196, 255);
            this.btn_personelKayıt.Name = "btn_personelKayıt";
            this.btn_personelKayıt.Size = new System.Drawing.Size(79, 28);
            this.btn_personelKayıt.TabIndex = 0;
            this.btn_personelKayıt.Text = "Kayıt";
            this.btn_personelKayıt.UseVisualStyleBackColor = true;
            this.btn_personelKayıt.Click += new System.EventHandler(this.btn_personelKayıt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "İSİM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "SOYİSİM";
            // 
            // txt_personelKayıtGorev
            // 
            this.txt_personelKayıtGorev.AutoSize = true;
            this.txt_personelKayıtGorev.Location = new System.Drawing.Point(101, 165);
            this.txt_personelKayıtGorev.Name = "txt_personelKayıtGorev";
            this.txt_personelKayıtGorev.Size = new System.Drawing.Size(55, 16);
            this.txt_personelKayıtGorev.TabIndex = 3;
            this.txt_personelKayıtGorev.Text = "GÖREV";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Şifre";
            // 
            // txt_personelKayıtİsim
            // 
            this.txt_personelKayıtİsim.Location = new System.Drawing.Point(196, 71);
            this.txt_personelKayıtİsim.Name = "txt_personelKayıtİsim";
            this.txt_personelKayıtİsim.Size = new System.Drawing.Size(100, 22);
            this.txt_personelKayıtİsim.TabIndex = 5;
            // 
            // txt_personelkayıtSoyisim
            // 
            this.txt_personelkayıtSoyisim.Location = new System.Drawing.Point(196, 121);
            this.txt_personelkayıtSoyisim.Name = "txt_personelkayıtSoyisim";
            this.txt_personelkayıtSoyisim.Size = new System.Drawing.Size(100, 22);
            this.txt_personelkayıtSoyisim.TabIndex = 6;
            // 
            // txt_personelgorev
            // 
            this.txt_personelgorev.Location = new System.Drawing.Point(196, 165);
            this.txt_personelgorev.Name = "txt_personelgorev";
            this.txt_personelgorev.Size = new System.Drawing.Size(100, 22);
            this.txt_personelgorev.TabIndex = 7;
            // 
            // text_personelKayıtSifre
            // 
            this.text_personelKayıtSifre.Location = new System.Drawing.Point(196, 210);
            this.text_personelKayıtSifre.Name = "text_personelKayıtSifre";
            this.text_personelKayıtSifre.Size = new System.Drawing.Size(100, 22);
            this.text_personelKayıtSifre.TabIndex = 8;
            // 
            // PersonelKayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(484, 356);
            this.Controls.Add(this.text_personelKayıtSifre);
            this.Controls.Add(this.txt_personelgorev);
            this.Controls.Add(this.txt_personelkayıtSoyisim);
            this.Controls.Add(this.txt_personelKayıtİsim);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_personelKayıtGorev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_personelKayıt);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PersonelKayıt";
            this.Text = "PersonelKayıt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_personelKayıt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txt_personelKayıtGorev;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_personelKayıtİsim;
        private System.Windows.Forms.TextBox txt_personelkayıtSoyisim;
        private System.Windows.Forms.TextBox txt_personelgorev;
        private System.Windows.Forms.TextBox text_personelKayıtSifre;
    }
}
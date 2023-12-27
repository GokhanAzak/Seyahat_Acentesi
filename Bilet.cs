using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GeçtimTurizim
{
    public partial class Btn_BiletAra : Form
    {
        private Panel panelKoltuklar;

        public Btn_BiletAra()
        {
            InitializeComponent();
            KoltukGorseliOlustur();
            VerileriComboBoxaEkle();
        }

        private void VerileriComboBoxaEkle()
        {
            // Örnek bir dizi
            string[] sehirler = {
                   "Adana", "Adıyaman", "Afyonkarahisar", "Ağrı", "Amasya", "Ankara", "Antalya",
                   "Artvin", "Aydın", "Balıkesir", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur",
                   "Bursa", "Çanakkale", "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Edirne", "Elazığ",
                   "Erzincan", "Erzurum", "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane", "Hakkâri", "Hatay",
                   "Isparta", "Mersin", "İstanbul", "İzmir", "Kars", "Kastamonu", "Kayseri", "Kırklareli",
                   "Kırşehir", "Kocaeli", "Konya", "Kütahya", "Malatya", "Manisa", "Kahramanmaraş", "Mardin",
                   "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Rize", "Sakarya", "Samsun", "Siirt",
                   "Sinop", "Sivas", "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Şanlıurfa", "Uşak", "Van",
                   "Yozgat", "Zonguldak", "Aksaray", "Bayburt", "Karaman", "Kırıkkale", "Batman", "Şırnak",
                   "Bartın", "Ardahan", "Iğdır", "Yalova", "Karabük", "Kilis", "Osmaniye", "Düzce"

                };


            // ComboBox'a dizi elemanlarını ekleme
            cmb_kalkıs.Items.AddRange(sehirler);
            cmb_varis.Items.AddRange(sehirler);
        }

        private void KoltukGorseliOlustur()
        {
          
            panelKoltuklar = new Panel();
            panelKoltuklar.Name = "panelKoltuklar";
            panelKoltuklar.Size = new System.Drawing.Size(400, 300); 
            panelKoltuklar.Location = new System.Drawing.Point(10, 10); 

            Controls.Add(panelKoltuklar); 

            int koltukSayisi = 16;
            int koltukAraligi = 9;
            int koltukGenisligi = (panelKoltuklar.Width - (koltukSayisi - 1) * koltukAraligi) / koltukSayisi;
            int koltukYuksekligi = 50;

            for (int i = 0; i < koltukSayisi; i++)
            {
                Button koltukButton = new Button();
                koltukButton.Name = $"btnKoltuk{i + 1}";
                koltukButton.Text = $"{i + 1}";
                koltukButton.Width = koltukGenisligi;
                koltukButton.Height = koltukYuksekligi;

                int sira = i / 2;
                int koltukSirasi = i % 3;

                
                koltukButton.Left = (koltukSirasi * 2 + sira * 2) * (koltukGenisligi + koltukAraligi);
                koltukButton.Top = koltukSirasi * (koltukYuksekligi + koltukAraligi);

                koltukButton.Click += new EventHandler(KoltukButtonClick);

                panelKoltuklar.Controls.Add(koltukButton);
            }
        }

        private void KoltukButtonClick(object sender, EventArgs e)
        {
           BiletAl biletAl = new BiletAl();

            biletAl.Show();
        }

        private void Ara_Click(object sender, EventArgs e)
        {
            string kalkisSehri = cmb_kalkıs.SelectedItem?.ToString();
            string varisSehri = cmb_varis.SelectedItem?.ToString();


            if (string.IsNullOrEmpty(kalkisSehri) || string.IsNullOrEmpty(varisSehri))
            {
                MessageBox.Show("Lütfen kalkış ve varış şehirlerini seçiniz.", "Uyarı");
                return;
            }
            string connectionString = "Data Source=Gokhan; Initial Catalog=Proje; User ID=sa; Password=1";
            string sorgu = "SELECT COUNT(*) FROM Table_Sefer_Bilgi_Giris WHERE Gidis = @Kalkis AND Varis = @Varis"; //( And tarih=@tarih)

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(sorgu, connection))
            {

                command.Parameters.AddWithValue("@Kalkis", kalkisSehri);
                command.Parameters.AddWithValue("@Varis", varisSehri);
                // command.Parameters.AddWithValue("@tarih", tarih);

                try
                {
                    connection.Open();
                    int seferSayisi = (int)command.ExecuteScalar();

                    // sefer varmı yomu kontrol et
                    if (seferSayisi > 0)
                    {

                        MessageBox.Show("Sefer bulundu!", "Bilgi");
                    }
                    else
                    {

                        MessageBox.Show("Sefer bulunamadı.", "Uyarı");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Hata oluştu: " + ex.Message, "Hata");
                }
            }
            }

        private void Btn_BiletAra_Load(object sender, EventArgs e)
        {
        }

        private void txt_Kalkis_Bilet_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_BiletAl_Kalkis_Click(object sender, EventArgs e)
        {

        }

        private void biletlerLabel_Click(object sender, EventArgs e)
        {

        }

        private void tarihlabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Varıs_Bilet_TextChanged(object sender, EventArgs e)
        {

        }

        private void Varış_Click(object sender, EventArgs e)
        {

        }
    }
}

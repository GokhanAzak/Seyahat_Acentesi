using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeçtimTurizim
{
    public partial class SeferIslemlerForm : Form
    {
        public SeferIslemlerForm()
        {
            InitializeComponent();
        }

        private void btn_SeferEkle_Click(object sender, EventArgs e)
        {
           
        }
        private void Btn_SeferSil_Click(object sender, EventArgs e)
        {
            
        }

        private void Btn_SeferGuncelle_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_SeferGuncelle_Click_1(object sender, EventArgs e)
        {

        }

        private void SeferIslemlerForm_Load_1(object sender, EventArgs e)
        {

        }

        private void btn_SeferSil_Click_1(object sender, EventArgs e)
        {
           

        }

        private void Btn_GunaSeferEkle_Click(object sender, EventArgs e)
        {

            string connString = "Data Source=Gokhan;Initial Catalog=Proje;User ID=sa;Password=1";

            using (SqlConnection connection = new SqlConnection(connString))
            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();

                        string SeferIslemler = "INSERT INTO Table_Sefer_Bilgi_Giris (Gidis, Varis,Tarih,Ucret,Sofor,Muavin)" + "VALUES (@Gidis,@Varis,@Tarih,@Ucret,@Sofor,@Muavin)" +
                                   "SELECT SCOPE_IDENTITY();";//AHADA BU EKLIYOR HEMEN


                        SqlCommand command = new SqlCommand(SeferIslemler, connection);
                        command.Parameters.AddWithValue("@Gidis", txt_Kalkis.Text);
                        command.Parameters.AddWithValue("@Varis", txt_Varis.Text);
                        command.Parameters.AddWithValue("@tarih", txt_Tarih.Text);
                        command.Parameters.AddWithValue("@Ucret", txt_Ucret.Text);
                        command.Parameters.AddWithValue("@sofor", txt_Sefer_sofor.Text);
                        command.Parameters.AddWithValue("@Muavin", Txt_Sefer_Muavin.Text);


                        int seferID = Convert.ToInt32(command.ExecuteScalar());//KOLTUKLAR TABLSOU 


                        for (int koltukNo = 1; koltukNo <= 12; koltukNo++)
                        {
                            string koltukEkleSorgusu = "INSERT INTO Table_Koltuklar (SeferID, KoltukNo, Durum) VALUES (@SeferID, @KoltukNo, @Durum);";

                            using (SqlCommand koltukCommand = new SqlCommand(koltukEkleSorgusu, connection))
                            {
                                koltukCommand.Parameters.AddWithValue("@SeferID", seferID);
                                koltukCommand.Parameters.AddWithValue("@KoltukNo", koltukNo);
                                koltukCommand.Parameters.AddWithValue("@Durum", "Boş");

                                koltukCommand.ExecuteNonQuery();
                            }
                        }


                        command.ExecuteNonQuery();

                        MessageBox.Show("BAŞARILI", "SEFER EKLENDİ");
                    }

                }
                catch (Exception)
                {

                    MessageBox.Show("hata");
                    throw;
                }
            }
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            int seferId;


            if (!int.TryParse(txt_SeferıdSil.Text, out seferId))
            {
                MessageBox.Show("Geçerli bir Sefer ID giriniz.");
                return;
            }

            string connString = "Data Source=Gokhan;Initial Catalog=Proje;User ID=sa;Password=1";

            using (SqlConnection baglanti = new SqlConnection(connString))
            {
                try
                {
                    baglanti.Open();


                    string seferSilSorgusu = "DELETE FROM Table_Sefer_Bilgi_Giris WHERE SeferID = @SeferID";

                    using (SqlCommand komut = new SqlCommand(seferSilSorgusu, baglanti))
                    {

                        komut.Parameters.AddWithValue("@SeferID", seferId);

                        int etkilenenSatirSayisi = komut.ExecuteNonQuery();

                        if (etkilenenSatirSayisi > 0)
                        {
                            MessageBox.Show("Sefer silindi.");
                        }
                        else
                        {
                            MessageBox.Show("Belirtilen Sefer ID bulunamadı.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }

        }

        private void btn_GunaGuncelle_Click(object sender, EventArgs e)
        {
            int seferId;

            if (!int.TryParse(txt_seferIdGuncelle.Text, out seferId))
            {
                MessageBox.Show("Geçerli bir Sefer ID giriniz.");
                return;
            }

            string connString = "Data Source=Gokhan;Initial Catalog=Proje;User ID=sa;Password=1";

            using (SqlConnection baglanti = new SqlConnection(connString))
            {
                try
                {
                    baglanti.Open();

                    // SQL UPDATE sorgususs
                    string seferGuncelleSorgusu = "UPDATE Table_Sefer_Bilgi_Giris SET Gidis = @Gidis, Varis = @Varis, Tarih = @Tarih, Ucret = @Ucret, Sofor = @Sofor, Muavin = @Muavin WHERE SeferID = @SeferID";

                    using (SqlCommand komut = new SqlCommand(seferGuncelleSorgusu, baglanti))
                    {
                        
                        komut.Parameters.AddWithValue("@Gidis", txt_GidisGuncelle.Text);
                        komut.Parameters.AddWithValue("@Varis", txt_Guncelle_Varıs.Text);
                        komut.Parameters.AddWithValue("@Tarih", txt_yeni_tarih.Text);
                        komut.Parameters.AddWithValue("@Ucret", txt_YeniUcret.Text);
                        komut.Parameters.AddWithValue("@Sofor", txt_YeniSofor.Text);
                        komut.Parameters.AddWithValue("@Muavin", txt_YeniMuavin.Text);
                        komut.Parameters.AddWithValue("@SeferID", seferId);

                        // UPDATE işlemini gerçekleştirin
                        int etkilenenSatirSayisi = komut.ExecuteNonQuery();

                        if (etkilenenSatirSayisi > 0)
                        {
                            MessageBox.Show("Sefer bilgileri güncellendi.");
                        }
                        else
                        {
                            MessageBox.Show("Belirtilen Sefer ID bulunamadı.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }

        }
    }
}
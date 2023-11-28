using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GeçtimTurizim
{
    public partial class Musteri : Form
    {
        public Musteri()
        {
            InitializeComponent();
        }


        private void btn_Musteri_Kayit_Click(object sender, EventArgs e)
        {


            string baglanti = "Data Source=Gokhan;Initial Catalog=Proje;User ID=sa;Password=1";
            using (SqlConnection connection = new SqlConnection(baglanti))
            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();

                        string Musteri = "INSERT INTO Table_Musteri (Musteri_isim, Musteri_soyad, Musteri_cinsiyet, Musteri_tel) VALUES (@Musteri_isim, @Musteri_soyad, @Musteri_cinsiyet, @Musteri_tel)";

                        SqlCommand cmd = new SqlCommand(Musteri, connection);

                        cmd.Parameters.AddWithValue("@Musteri_isim", txt_Musteri_isim.Text);
                        cmd.Parameters.AddWithValue("@Musteri_soyad", txt_Musteri_soyad.Text);
                        cmd.Parameters.AddWithValue("@Musteri_cinsiyet", txt_Musteri_cinsiyet.Text);
                        cmd.Parameters.AddWithValue("@Musteri_tel", txt_Musteri_telefon.Text);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("MÜŞTERİ EKLENDİ");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("HATA: " + ex.Message);
                }
            }
        }


    }
}


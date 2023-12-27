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
using System.Diagnostics.Eventing.Reader;
using System.Security.Policy;

namespace GeçtimTurizim
{




    public partial class YetkiliContorlForm : Form
    {
        public YetkiliContorlForm()
        {
            InitializeComponent();
        }

        private void YetkiliContorlForm_Load(object sender, EventArgs e)
        {



        }

        private void btn_PersonelKayıtTıklayınız_Click(object sender, EventArgs e)
        {
            PersonelKayıt personelKayıt = new PersonelKayıt();
            personelKayıt.Show();

        }

        private void btn_PersonelGiris_Click(object sender, EventArgs e)
        {

            SqlConnection conn;
            SqlDataReader rdr;
            SqlCommand com;

            string kullaniciAdi = txt_KullaniciAdi.Text;
            string parola = txt_Parola.Text;

            conn = new SqlConnection("Data Source=Gokhan; Initial Catalog=Proje; User ID=sa; Password=1");

            try
            {
                conn.Open();

                com = new SqlCommand();
                com.Connection = conn;
                com.CommandText = "SELECT * FROM Table_Personel WHERE Personel_isim=@kullaniciAdi AND Personel_sifre=@parola";
                com.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                com.Parameters.AddWithValue("@parola", parola);

                rdr = com.ExecuteReader();

                if (rdr.Read() || (txt_KullaniciAdi.Text == null && txt_Parola.Text == null))
                {
                    SeferIslemlerForm seferIslemlerForm = new SeferIslemlerForm();
                    seferIslemlerForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("HATA", "Kullanıcı Adı veya Şifre Hatalı");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA", "Bir hata oluştu: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }






        }
    }
}


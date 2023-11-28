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
    public partial class PersonelKayıt : Form
    {
        public PersonelKayıt()
        {
            InitializeComponent();
        }

        private void btn_personelKayıt_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=Gokhan;Initial Catalog=Proje;User ID=sa;Password=1";
                
            using (SqlConnection connection = new SqlConnection(connString))
            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();

                        string  PersonelKayit = "INSERT INTO Table_Personel (Personel_isim, Personel_soyad,Personel_sifre,Personel_gorev) VALUES (@Personel_isim,@Personel_soyad,@Personel_sifre,@Personel_gorev)";


                        SqlCommand command = new SqlCommand(PersonelKayit, connection);
                        command.Parameters.AddWithValue("@Personel_isim", txt_personelKayıtİsim.Text);
                        command.Parameters.AddWithValue("@Personel_soyad", txt_personelkayıtSoyisim.Text);
                        command.Parameters.AddWithValue("@Personel_sifre", text_personelKayıtSifre.Text);
                        command.Parameters.AddWithValue("@Personel_gorev", txt_personelgorev.Text);

                        command.ExecuteNonQuery();

                        MessageBox.Show("PERSONEL EKLENDİ");
                    }

                }
                catch (Exception)
                {

                    MessageBox.Show("hata");
                    throw;
                }
            }


        }
    }
}

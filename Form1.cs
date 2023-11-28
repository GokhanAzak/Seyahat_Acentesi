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

    public partial class AnaSayfaForm : Form
    {
        public AnaSayfaForm()
        {
            InitializeComponent();
        }

       

        private void btn_YetkiliGirişTıkla_Click(object sender, EventArgs e)
        {
            YetkiliContorlForm yetkiliContorlForm = new YetkiliContorlForm();

            yetkiliContorlForm.Show();
        }

        private void btn_BiletAlTıklama_Click(object sender, EventArgs e)
        {
            Btn_BiletAra bilet = new Btn_BiletAra();
            bilet.Show();
        }

        private void btn_MusteriIslemTıklama_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri();
            musteri.Show();
        }

        private void AnaSayfaForm_Load(object sender, EventArgs e)
        {

        }
    }
}

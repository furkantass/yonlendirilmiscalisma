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

namespace WindowsFormsApp6
{
    public partial class Kayıtol : Form
    {
        public Kayıtol()
        {
            InitializeComponent();
        }
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataReader dr;
     
        public void vtbaglan()
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-J56BCET\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
            baglanti.Open();
        }
        public void vtkapat()
        {
            baglanti.Close();
        }

        private void buttongırıs_Click(object sender, EventArgs e)
        {
            Giriş giriş = new Giriş();
            giriş.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
       

        private void Buttonkayıtol_Click(object sender, EventArgs e)
        {

            try
            {
                if(txtTc.Text=="" && TxtKullanici.Text== "" && TxtEmail.Text == "")
                {
                    MessageBox.Show("Bilgileri Eksik Girdiniz.");
                }
                    else if (TxtEhliyet.Text == "" && TxtSifre.Text=="")
                {
                    MessageBox.Show("Bilgileri Eksik Girdiniz.");
                }
                    vtbaglan();
                string kayit = "insert into müsteriler(Tc_kimlik,Kullanici_Adi,Sifre,E_Mail,ehliyet_no) values (@tc,@kAdi,@sifre,@mail,@ehliyetno)";
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                komut.Parameters.AddWithValue("@tc", txtTc.Text);
                komut.Parameters.AddWithValue("@kAdi", TxtKullanici.Text);
                komut.Parameters.AddWithValue("@sifre", TxtSifre.Text);
                komut.Parameters.AddWithValue("@mail", TxtEmail.Text);
                komut.Parameters.AddWithValue("@ehliyetno", TxtEhliyet.Text);

                komut.ExecuteNonQuery();
                vtkapat();
                MessageBox.Show("Kullanici Kayıt İşlemi Gerçekleşti.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace WindowsFormsApp6
{
    public partial class FrmMüsteriListele : Form
    {
        public FrmMüsteriListele()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-J56BCET\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
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

        private void FrmMüsteriListele_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            {

                try
                {
                    if (txtTc.Text == "" && TxtKullanici.Text == "" && TxtEmail.Text == "")
                    {
                        MessageBox.Show("Bilgileri Eksik Girdiniz.");
                    }
                    else if (TxtEhliyet.Text == "" && TxtSifre.Text == "")
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

        private void ButtonVeriyiCek_Click(object sender, EventArgs e)
        {
            con.Open();
            string Select = "Select * from müsteriler";
            SqlDataAdapter da = new SqlDataAdapter(Select, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void Buttongırıs_Click(object sender, EventArgs e)
        {
            AdminSayfası adminSayfası = new AdminSayfası();
            adminSayfası.Show();
        }

        private void ButtonSil_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE from [müsteriler] where Tc_kimlik=@tc", con);
            cmd.Parameters.AddWithValue("@tc", dataGridView1.CurrentRow.Cells[0].Value);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ButtonYöneticiyap_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtKullanici.Text == "" && TxtSifre.Text == "")
                {
                    MessageBox.Show("Bilgileri Eksik Girdiniz.");
                }
                vtbaglan();
                string kayit = "insert into Yönetici(Kullanıcı_adı,Sifre) values (@kAdi,@sifre)";
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                komut.Parameters.AddWithValue("@kAdi", TxtKullanici.Text);
                komut.Parameters.AddWithValue("@sifre", TxtSifre.Text);

                komut.ExecuteNonQuery();
                vtkapat();
                MessageBox.Show("Yönetici Kayıt İşlemi Gerçekleşti.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }

        }
    }

}
    


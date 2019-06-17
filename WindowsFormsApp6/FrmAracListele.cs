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
    public partial class FrmAracListele : Form
    {
        public FrmAracListele()
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


        private void ButtonVeriyiCek_Click(object sender, EventArgs e)
        {
            con.Open();
            string Select = "Select * from arac_bilgileri";
            SqlDataAdapter da = new SqlDataAdapter(Select, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewArac.DataSource = dt;
            con.Close();

        }

        private void ButtonAracKayıt_Click(object sender, EventArgs e)
        {

            {

                try
                {
                    if (txtPlaka.Text == "" && txtMarka.Text == "" && txtModel.Text == "")
                    {
                        MessageBox.Show("Bilgileri Eksik Girdiniz.");
                    }
                    else if (txtYılı.Text == "" && txtRenk.Text == "" && txtKiraÜcreti.Text == "" && buttonResimekle.Text == "")
                    {
                        MessageBox.Show("Bilgileri Eksik Girdiniz.");
                    }
                    vtbaglan();
                    string kayit = "insert into arac_bilgileri(Plaka,Marka,Model,Yılı,Resim,Renk,KiraÜcreti) values (@Plaka,@Marka,@Model,@Yılı,@Resim,@Renk,@KiraÜcreti)";
                    SqlCommand komut = new SqlCommand(kayit, baglanti);
                    komut.Parameters.AddWithValue("@Plaka", txtPlaka.Text);
                    komut.Parameters.AddWithValue("@Marka", txtMarka.Text);
                    komut.Parameters.AddWithValue("@Model", txtModel.Text);
                    komut.Parameters.AddWithValue("@Yılı", txtYılı.Text);
                    komut.Parameters.AddWithValue("@Resim", buttonResimekle.Text);
                    komut.Parameters.AddWithValue("@Renk", txtRenk.Text);
                    komut.Parameters.AddWithValue("@KiraÜcreti", txtKiraÜcreti.Text);

                    komut.ExecuteNonQuery();
                    vtkapat();
                    MessageBox.Show("Araç Kayıt İşlemi Gerçekleşti.");
                }
                catch (Exception hata)
                {
                    MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
                }

            }
        }

        private void Buttongırıs_Click(object sender, EventArgs e)
        {
            AdminSayfası adminSayfası = new AdminSayfası();
            adminSayfası.Show();
        }

        private void ButtonSil_Click(object sender, EventArgs e)
        {
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE from [arac_bilgileri] where Plaka=@Plaka", con);
                cmd.Parameters.AddWithValue("@Plaka", dataGridViewArac.CurrentRow.Cells[0].Value);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void ButtonResimekle_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;

        }

        private void DataGridViewArac_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}

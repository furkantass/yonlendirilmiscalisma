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
using System.Net.Mail;


namespace WindowsFormsApp6
{

    public partial class Giriş : Form
    {
         string user;
        public string pass;
        public Giriş()
        {
            InitializeComponent();
        }

        
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter sda;
        DataTable dt;
        public void vtbaglan()
        {
            con = new SqlConnection("Data Source=DESKTOP-J56BCET\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
            con.Open();
        }

        public void vtkapat()
        {
            con.Close();
        }
        private void buttongırıs_Click(object sender, EventArgs e)
        {

             user = txtUser.Text;
             pass = txtPass.Text;
            vtbaglan();
            string sql = "SELECT * FROM müsteriler WHERE Kullanici_adi='" + user + "' AND Sifre='" + pass + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            dt = new DataTable();
            sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            

            if (dt.Rows.Count > 0)
            {
                AnaSayfa anasayfa = new AnaSayfa();
                anasayfa.user = this.user;
                anasayfa.pass = this.pass;
                anasayfa.Show();
            }

            else
            {
                MessageBox.Show("Yanlış Kullanıcı ve ya şifre.");
            }

        }

        private void buttonkayıtol_Click(object sender, EventArgs e)
        {
            Kayıtol kayıtol = new Kayıtol();
            kayıtol.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
          

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
        

                string user = txtUser.Text;
                string pass = txtPass.Text;
                vtbaglan();
                string sql = "SELECT * FROM Yönetici WHERE Kullanıcı_adı='" + user + "' AND Sifre='" + pass + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);


                if (dt.Rows.Count > 0)
                {
                    AdminSayfası adminSayfası = new AdminSayfası();
                    adminSayfası.Show();
                }

                else
                {
                    MessageBox.Show("Lütfen yetkili girişinden girmeyiniz.");
                }

        


        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}

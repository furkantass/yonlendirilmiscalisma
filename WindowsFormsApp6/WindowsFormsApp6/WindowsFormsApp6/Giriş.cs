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
    public partial class Giriş : Form
    {
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
            con = new SqlConnection("Data Source=DAMLA\\SQLSERVER;Initial Catalog=arac_kiralama;Integrated Security=True");
            con.Open();
        }

        public void vtkapat()
        {
            con.Close();
        }
        private void buttongırıs_Click(object sender, EventArgs e)
        {

            string user = txtUser.Text;
            string pass = txtPass.Text;
            vtbaglan();
            string sql = "SELECT * FROM müsteriler WHERE Kullanici_adi='" + user + "' AND Sifre='" + pass + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            dt = new DataTable();
            sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            

            if (dt.Rows.Count > 0)
            {
                AnaSayfa anasayfa = new AnaSayfa();
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
    }
}

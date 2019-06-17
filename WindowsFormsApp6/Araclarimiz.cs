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
    public partial class Araclarimiz : Form
    {
        Arac_Kiralama arackiralama = new Arac_Kiralama();
        public string user;
        public string pass;
        public Araclarimiz()
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


        private void DataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            txtPlaka.Text = satır.Cells["Plaka"].Value.ToString();
           txtMarka.Text = satır.Cells["Marka"].Value.ToString();
            txtModel.Text = satır.Cells["Model"].Value.ToString();
            txtYılı.Text = satır.Cells["Yılı"].Value.ToString();
            txtRenk.Text = satır.Cells["Renk"].Value.ToString();
            txtKiraÜcreti.Text = satır.Cells["KiraÜcreti"].Value.ToString();
            pictureBox2.ImageLocation = satır.Cells["Resim"].Value.ToString();

        }

        private void Araclarimiz_Load(object sender, EventArgs e)
        {
            YenileAraclarListesi();
            
        }

        private void YenileAraclarListesi()
        {
            string cümle = "select * from arac_bilgileri";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource=arackiralama.listele(adtr2, cümle);

        }

        private void ButtonVeriyiCek_Click(object sender, EventArgs e)
        {
            con.Open();
            string Select = "Select * from arac_bilgileri";
            SqlDataAdapter da = new SqlDataAdapter(Select, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void ButtonResimekle_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox2.ImageLocation = openFileDialog1.FileName;
        }

        private void ButtonAnasayfa_Click(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa = new AnaSayfa();
            anaSayfa.Show();
            this.Hide();
        }

        private void Button_Araclarımız_Click(object sender, EventArgs e)
        {
            Araclarimiz araclarimiz = new Araclarimiz();
            araclarimiz.Show();
            this.Hide();
        }

        private void Button_KİRALAMAKOŞ_Click(object sender, EventArgs e)
        {
            KiralamaKosulları kiralamaKosulları = new KiralamaKosulları();
            kiralamaKosulları.Show();
            this.Hide();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            İletisim iletisim = new İletisim();
            iletisim.Show();
            this.Hide();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ButtonKirala_Click(object sender, EventArgs e)
        {

            DialogResult secenek = MessageBox.Show("Aracı kiralamak istiyor musunuz ?", "Furkan Rent A Car ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {
                vtbaglan();

                string kayit = "insert into Kiralama (AracPlakaNo,Kullanici_Adi) values('" + txtPlaka.Text + "','" + this.user + "')";
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                komut.ExecuteNonQuery();
                vtkapat();
                MessageBox.Show("Araç kiralama isteği gönderildi.");
            }
        
            else if (secenek == DialogResult.No)
            {
                //Hayır seçeneğine tıklandığında çalıştırılacak kodlar
            }

        }
    }
}

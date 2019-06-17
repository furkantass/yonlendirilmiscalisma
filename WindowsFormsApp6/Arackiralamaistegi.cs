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
    public partial class Arackiralamaistegi : Form
    {
        public Arackiralamaistegi()
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

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ButtonVeriyiCek_Click(object sender, EventArgs e)
        {
            con.Open();
            string Select = "Select * from Kiralama";
            SqlDataAdapter da = new SqlDataAdapter(Select, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewKiralama.DataSource = dt;
            con.Close();
        }

        private void ButtonRed_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE from [Kiralama] where AracPlakaNo=@AracPlakaNo", con);
            cmd.Parameters.AddWithValue("@AracPlakaNo", dataGridViewKiralama.CurrentRow.Cells[0].Value);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void ButtonONAYLA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aracı kiralama isteği onaylandı.", "Furkan Rent A Car");
        }
    }
}

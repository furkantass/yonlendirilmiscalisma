using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class AnaSayfa : Form
    {
        public string user;
        public string pass;
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ButtonAnasayfa_Click(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa = new AnaSayfa();
            anaSayfa.Show();
            this.Hide();
        }

        private void button_Hakkımızda_Click(object sender, EventArgs e)
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

        private void Button_Araclarimiz_Click(object sender, EventArgs e)
        {
            Araclarimiz araclarimiz = new Araclarimiz();
            araclarimiz.user = this.user;
            araclarimiz.pass = this.pass;
            araclarimiz.Show();
            this.Hide();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ButtonARACYONLENDIR_Click(object sender, EventArgs e)
        {
            Araclarimiz araclarimiz = new Araclarimiz();
            araclarimiz.Show();
            this.Hide();
        }
    }
}

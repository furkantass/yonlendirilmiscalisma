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
    public partial class AdminSayfası : Form
    {
        public AdminSayfası()
        {
            InitializeComponent();
        }

        private void ButtonMusteriListele_Click(object sender, EventArgs e)
        {
            FrmMüsteriListele listele = new FrmMüsteriListele();
            listele.ShowDialog();
        }

        private void ButtonAracListele_Click(object sender, EventArgs e)
        {
            FrmAracListele araclistele = new FrmAracListele();
            araclistele.ShowDialog();

        }

        private void AdminSayfası_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Arackiralamaistegi arackiralamaistegi = new Arackiralamaistegi();
            arackiralamaistegi.ShowDialog();


        }
    }
}

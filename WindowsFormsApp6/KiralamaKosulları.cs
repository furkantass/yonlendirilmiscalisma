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
    public partial class KiralamaKosulları : Form
    {
        public KiralamaKosulları()
        {
            InitializeComponent();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            İletisim iletisim = new İletisim();
            iletisim.Show();
            this.Hide();
        }
    }
}

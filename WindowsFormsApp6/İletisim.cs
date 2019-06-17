using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace WindowsFormsApp6
{
    public partial class İletisim : Form
    {
        public İletisim()
        {
            InitializeComponent();
        }

        private void ButtonGonder_Click(object sender, EventArgs e)
        {
            {

                if (txtAdSoyad.Text !="" &txtMail.Text != "" &txtMesaj.Text != "")
{
                    string mesaj = "";
                    mesaj += " Kişisel site ziyaretçimden mail geldi !";
                    mesaj += " Ad Soyadı:  " +txtAdSoyad.Text + "";
                    mesaj += " Mail : " +txtMail.Text + "";
                    mesaj += " Mesaj :  " +txtMesaj.Text + "";

                    MailMessage msg = new MailMessage(); // Yeni mail nesnesi oluşturduk.
                    msg.IsBodyHtml = true; // html kodları yazıldığında sorun çıkmaması için.
                    msg.To.Add("furkan.rentacarr@gmail.com");
                    msg.From = new MailAddress("furkan.rentacarr@gmail.com", "Furkan", System.Text.Encoding.UTF8);
                    msg.Body = mesaj; // mailin içeriği.

                    SmtpClient smtp = new SmtpClient(); // gmail için yeni smtp nesnesi oluşturduk.
                    smtp.EnableSsl = true; // gmail için ssl i aktif yaptık.
                    smtp.Credentials = new NetworkCredential("furkan.rentacarr@gmail.com", "sananelan12");
                    smtp.Port = 587; // portu seçtik.
                    smtp.Host = "smtp.gmail.com";
                    smtp.Send(msg);

                    txtAdSoyad.Text = txtMail.Text = txtMesaj.Text = "";
                    lblMesaj.Text = "Mesajınız gönderilmiştir, ilginiz için teşekkürler.";
                }
                  else
                {
                    lblMesaj.Text = "Boş alan bırakmazsak daha sağlıklı iletişim kurabiliriz:)";
                }

            }
        }

        private void Button_Araclarımız_Click(object sender, EventArgs e)
        {
            Araclarimiz araclarimiz = new Araclarimiz();
            araclarimiz.Show();
            this.Hide();

        }

        private void ButtonAnasayfa_Click(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa = new AnaSayfa();
            anaSayfa.Show();
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
    }
}

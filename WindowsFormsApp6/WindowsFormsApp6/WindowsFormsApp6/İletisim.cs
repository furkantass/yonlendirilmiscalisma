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
                    mesaj += "< b > Kişisel site ziyaretçimden mail geldi ! </ b >< br />";
                    mesaj += "< b > Ad Soyadı: </ b > " +txtAdSoyad.Text + "< br />";
                    mesaj += "< b > Mail : </ b > " +txtMail.Text + "< br />";
                    mesaj += "< b > Mesaj : </ b > " +txtMesaj.Text + "< br />";
                    mesaj += "< b > Tarih : </ b > " +DateTime.Now.ToString();

                    MailMessage msg = new MailMessage(); // Yeni mail nesnesi oluşturduk.
                    msg.IsBodyHtml = true; // html kodları yazıldığında sorun çıkmaması için.
                    msg.To.Add("Mesajın gideceği maili yazın");
                    msg.From = new MailAddress("mesajların gönderileceği sabit mail adresi", "Mailde gözükecek İsim", System.Text.Encoding.UTF8);
                    msg.Body = mesaj; // mailin içeriği.

                    SmtpClient smtp = new SmtpClient(); // gmail için yeni smtp nesnesi oluşturduk.
                    smtp.EnableSsl = true; // gmail için ssl i aktif yaptık.
                    smtp.Credentials = new NetworkCredential("mesajların gönderileceği sabit mail adresi", "mail şifresi");
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
    }
}

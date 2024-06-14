using System;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;

namespace _22520853_Lab5
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            string From = tbFromMail.Text;
            string To = tbToMail.Text;
            string Subject = tbSubject.Text;
            string Body = rtbDisplay.Text;

            try
            {
                // Tạo đối tượng MailMessage
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(From);
                mail.To.Add(To);
                mail.Subject = Subject;
                mail.Body = Body;

                // Cấu hình SMTP client
                SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");
                smtpServer.Port = 587; //Cổng 465 lỗi thay bằng cổng 587
                smtpServer.Credentials = new NetworkCredential("tranthienmanh09@gmail.com", "drnj ickt rarj cevx");
                smtpServer.EnableSsl = true;

                // Gửi email
                smtpServer.Send(mail);
                MessageBox.Show("Email đã được gửi thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gửi email thất bại ! {ex.Message}");
            }
        }
    }
}

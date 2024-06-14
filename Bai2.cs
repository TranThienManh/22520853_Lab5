using System;
using System.Windows.Forms;
using MailKit.Net.Imap;
using MailKit;
using MimeKit;
using System.Threading;

namespace _22520853_Lab5
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void Bai2_Load(object sender, EventArgs e)
        {
            // Thiết lập các cột cho ListView
            listView1.View = View.Details;
            listView1.Columns.Add("Email", 230);
            listView1.Columns.Add("From", 230);
            listView1.Columns.Add("Thời gian", 210);
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string email = tb_Email.Text;
            string password = tb_Password.Text;

            try
            {
                using (var client = new ImapClient())
                {
                    // Kết nối đến máy chủ IMAP
                    client.Connect("imap.gmail.com", 993, true);

                    // Xác thực
                    client.Authenticate(email, password);

                    // Mở hộp thư đến
                    var inbox = client.Inbox;
                    inbox.Open(FolderAccess.ReadOnly);

                    // Xóa các item cũ trong ListView
                    listView1.Items.Clear();

                    // Đếm tổng số email
                    int totalEmails = inbox.Count;

                    // Đếm số email chưa đọc
                    int recentEmails = inbox.Recent;

                    // Cập nhật thông tin số lượng email
                    total.Text = totalEmails.ToString();
                    recent.Text = recentEmails.ToString();

                    // Đọc tối đa 10 email đầu tiên
                    for (int i = 0; i < 10; i++)
                    {
                        var message = inbox.GetMessage(i);
                        var item = new ListViewItem(new[] {
                            message.Subject,
                            message.From.ToString(),
                            message.Date.DateTime.ToString("dd/MM/yyyy HH:mm:ss")
                        });
                        listView1.Items.Add(item);
                    }



                    // Ngắt kết nối
                    client.Disconnect(true);
                }
                MessageBox.Show("Tải email thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đăng nhập thất bại! {ex.Message}");
            }
        }

    }
}

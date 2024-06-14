using System;
using System.Windows.Forms;
using MailKit.Net.Imap;
using MailKit;
using MailKit.Net.Pop3;

namespace _22520853_Lab5
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void Bai3_Load(object sender, EventArgs e)
        {
            // Thiết lập các cột cho ListView
            listView1.View = View.Details;
            listView1.Columns.Add("Email", 250);
            listView1.Columns.Add("From", 150);
            listView1.Columns.Add("Thời gian", 150);
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string email = tb_Email.Text;
            string appPassword = tb_Password.Text; // Sử dụng mật khẩu ứng dụng thay vì mật khẩu email thông thường

            try
            {
                using (var client = new Pop3Client())
                {
                    // Kết nối đến máy chủ Pop
                    client.Connect("pop.gmail.com", 995, true);

                    // Xác thực
                    client.Authenticate(email, appPassword);

                    // Xóa các item cũ trong ListView
                    listView1.Items.Clear();

                    int totalEmails = client.GetMessageCount();

                    // Cập nhật thông tin số lượng email
                    total.Text = totalEmails.ToString();

                    // Đọc tối đa 10 email đầu tiên
                    for (int i = 0; i < 10; i++)
                    {
                        var message = client.GetMessage(i);
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

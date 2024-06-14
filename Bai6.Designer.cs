using Org.BouncyCastle.Asn1.Crmf;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _22520853_Lab5
{
    partial class Bai6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grb_SignIn = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Send = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_SignIn = new System.Windows.Forms.Button();
            this.tbx_password = new System.Windows.Forms.TextBox();
            this.tbx_account = new System.Windows.Forms.TextBox();
            this.grb_Setting = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.domainUpDown2 = new System.Windows.Forms.DomainUpDown();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_IMAP = new System.Windows.Forms.TextBox();
            this.tbx_SMTP = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pn_readmail = new System.Windows.Forms.Panel();
            this.btn_Reply = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Back = new System.Windows.Forms.Button();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.pn_SendMail = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btn_attach = new System.Windows.Forms.Button();
            this.btn_Back2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.rtbBody = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbSubject = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbToMail = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.grb_SignIn.SuspendLayout();
            this.grb_Setting.SuspendLayout();
            this.pn_readmail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pn_SendMail.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_SignIn
            // 
            this.grb_SignIn.Controls.Add(this.label1);
            this.grb_SignIn.Controls.Add(this.btn_Send);
            this.grb_SignIn.Controls.Add(this.btn_Refresh);
            this.grb_SignIn.Controls.Add(this.label2);
            this.grb_SignIn.Controls.Add(this.btn_SignIn);
            this.grb_SignIn.Controls.Add(this.tbx_password);
            this.grb_SignIn.Controls.Add(this.tbx_account);
            this.grb_SignIn.Location = new System.Drawing.Point(21, 14);
            this.grb_SignIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grb_SignIn.Name = "grb_SignIn";
            this.grb_SignIn.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grb_SignIn.Size = new System.Drawing.Size(328, 100);
            this.grb_SignIn.TabIndex = 0;
            this.grb_SignIn.TabStop = false;
            this.grb_SignIn.Text = "Đăng nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tài khoản";
            // 
            // btn_Send
            // 
            this.btn_Send.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Send.Location = new System.Drawing.Point(5, 72);
            this.btn_Send.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(90, 23);
            this.btn_Send.TabIndex = 7;
            this.btn_Send.Text = "Gửi mail";
            this.btn_Send.UseVisualStyleBackColor = false;
            this.btn_Send.Visible = false;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Refresh.Location = new System.Drawing.Point(102, 72);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(74, 23);
            this.btn_Refresh.TabIndex = 6;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mật khẩu";
            // 
            // btn_SignIn
            // 
            this.btn_SignIn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_SignIn.Location = new System.Drawing.Point(182, 72);
            this.btn_SignIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_SignIn.Name = "btn_SignIn";
            this.btn_SignIn.Size = new System.Drawing.Size(130, 23);
            this.btn_SignIn.TabIndex = 2;
            this.btn_SignIn.Tag = "1";
            this.btn_SignIn.Text = "Đăng nhập";
            this.btn_SignIn.UseVisualStyleBackColor = false;
            // 
            // tbx_password
            // 
            this.tbx_password.Location = new System.Drawing.Point(114, 47);
            this.tbx_password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_password.Name = "tbx_password";
            this.tbx_password.Size = new System.Drawing.Size(198, 22);
            this.tbx_password.TabIndex = 1;
            // 
            // tbx_account
            // 
            this.tbx_account.Location = new System.Drawing.Point(114, 21);
            this.tbx_account.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_account.Name = "tbx_account";
            this.tbx_account.Size = new System.Drawing.Size(198, 22);
            this.tbx_account.TabIndex = 0;
            // 
            // grb_Setting
            // 
            this.grb_Setting.Controls.Add(this.label6);
            this.grb_Setting.Controls.Add(this.label5);
            this.grb_Setting.Controls.Add(this.domainUpDown2);
            this.grb_Setting.Controls.Add(this.domainUpDown1);
            this.grb_Setting.Controls.Add(this.label4);
            this.grb_Setting.Controls.Add(this.label3);
            this.grb_Setting.Controls.Add(this.tbx_IMAP);
            this.grb_Setting.Controls.Add(this.tbx_SMTP);
            this.grb_Setting.Location = new System.Drawing.Point(355, 14);
            this.grb_Setting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grb_Setting.Name = "grb_Setting";
            this.grb_Setting.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grb_Setting.Size = new System.Drawing.Size(543, 100);
            this.grb_Setting.TabIndex = 1;
            this.grb_Setting.TabStop = false;
            this.grb_Setting.Text = "Cài đặt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(300, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Port";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Port";
            // 
            // domainUpDown2
            // 
            this.domainUpDown2.Location = new System.Drawing.Point(341, 64);
            this.domainUpDown2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.domainUpDown2.Name = "domainUpDown2";
            this.domainUpDown2.Size = new System.Drawing.Size(184, 22);
            this.domainUpDown2.TabIndex = 8;
            this.domainUpDown2.Text = "0";
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Location = new System.Drawing.Point(67, 64);
            this.domainUpDown1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(184, 22);
            this.domainUpDown1.TabIndex = 7;
            this.domainUpDown1.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "SMTP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "IMAP";
            // 
            // tbx_IMAP
            // 
            this.tbx_IMAP.Location = new System.Drawing.Point(67, 21);
            this.tbx_IMAP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_IMAP.Name = "tbx_IMAP";
            this.tbx_IMAP.Size = new System.Drawing.Size(184, 22);
            this.tbx_IMAP.TabIndex = 3;
            // 
            // tbx_SMTP
            // 
            this.tbx_SMTP.Location = new System.Drawing.Point(341, 21);
            this.tbx_SMTP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_SMTP.Name = "tbx_SMTP";
            this.tbx_SMTP.Size = new System.Drawing.Size(184, 22);
            this.tbx_SMTP.TabIndex = 2;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(21, 130);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(877, 344);
            this.listView1.TabIndex = 2;
            this.listView1.TileSize = new System.Drawing.Size(300, 44);
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "From";
            this.columnHeader2.Width = 250;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Subject";
            this.columnHeader3.Width = 400;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Datetime";
            this.columnHeader4.Width = 170;
            // 
            // pn_readmail
            // 
            this.pn_readmail.Controls.Add(this.btn_Reply);
            this.pn_readmail.Controls.Add(this.richTextBox1);
            this.pn_readmail.Controls.Add(this.pictureBox1);
            this.pn_readmail.Controls.Add(this.btn_Back);
            this.pn_readmail.Controls.Add(this.lblSubject);
            this.pn_readmail.Controls.Add(this.lblTo);
            this.pn_readmail.Controls.Add(this.lblFrom);
            this.pn_readmail.Location = new System.Drawing.Point(21, 128);
            this.pn_readmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pn_readmail.Name = "pn_readmail";
            this.pn_readmail.Size = new System.Drawing.Size(877, 352);
            this.pn_readmail.TabIndex = 3;
            this.pn_readmail.Tag = "";
            this.pn_readmail.Visible = false;
            // 
            // btn_Reply
            // 
            this.btn_Reply.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Reply.Location = new System.Drawing.Point(769, 6);
            this.btn_Reply.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Reply.Name = "btn_Reply";
            this.btn_Reply.Size = new System.Drawing.Size(90, 54);
            this.btn_Reply.TabIndex = 11;
            this.btn_Reply.Text = "Trả lời";
            this.btn_Reply.UseVisualStyleBackColor = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(21, 94);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(838, 242);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(334, 102);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 50);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Back.Location = new System.Drawing.Point(769, 66);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(90, 23);
            this.btn_Back.TabIndex = 9;
            this.btn_Back.Text = "Trở lại";
            this.btn_Back.UseVisualStyleBackColor = false;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.Location = new System.Drawing.Point(24, 50);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(60, 28);
            this.lblSubject.TabIndex = 6;
            this.lblSubject.Text = "Title:";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(25, 31);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(33, 23);
            this.lblTo.TabIndex = 5;
            this.lblTo.Text = "To:";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.Location = new System.Drawing.Point(24, 13);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(52, 23);
            this.lblFrom.TabIndex = 4;
            this.lblFrom.Text = "From";
            // 
            // pn_SendMail
            // 
            this.pn_SendMail.Controls.Add(this.linkLabel1);
            this.pn_SendMail.Controls.Add(this.btn_attach);
            this.pn_SendMail.Controls.Add(this.btn_Back2);
            this.pn_SendMail.Controls.Add(this.button1);
            this.pn_SendMail.Controls.Add(this.rtbBody);
            this.pn_SendMail.Controls.Add(this.label8);
            this.pn_SendMail.Controls.Add(this.tbSubject);
            this.pn_SendMail.Controls.Add(this.label7);
            this.pn_SendMail.Controls.Add(this.tbToMail);
            this.pn_SendMail.Location = new System.Drawing.Point(21, 130);
            this.pn_SendMail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pn_SendMail.Name = "pn_SendMail";
            this.pn_SendMail.Size = new System.Drawing.Size(877, 352);
            this.pn_SendMail.TabIndex = 11;
            this.pn_SendMail.Visible = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(88, 286);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 16);
            this.linkLabel1.TabIndex = 17;
            // 
            // btn_attach
            // 
            this.btn_attach.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_attach.Location = new System.Drawing.Point(736, 282);
            this.btn_attach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_attach.Name = "btn_attach";
            this.btn_attach.Size = new System.Drawing.Size(90, 23);
            this.btn_attach.TabIndex = 16;
            this.btn_attach.Text = "Đính kèm";
            this.btn_attach.UseVisualStyleBackColor = false;
            // 
            // btn_Back2
            // 
            this.btn_Back2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Back2.Location = new System.Drawing.Point(745, 11);
            this.btn_Back2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Back2.Name = "btn_Back2";
            this.btn_Back2.Size = new System.Drawing.Size(94, 23);
            this.btn_Back2.TabIndex = 12;
            this.btn_Back2.Text = "Trở lại";
            this.btn_Back2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(745, 39);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "SEND";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // rtbBody
            // 
            this.rtbBody.Location = new System.Drawing.Point(79, 112);
            this.rtbBody.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbBody.Name = "rtbBody";
            this.rtbBody.Size = new System.Drawing.Size(760, 222);
            this.rtbBody.TabIndex = 13;
            this.rtbBody.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 23);
            this.label8.TabIndex = 12;
            this.label8.Text = "Subject";
            // 
            // tbSubject
            // 
            this.tbSubject.Location = new System.Drawing.Point(79, 74);
            this.tbSubject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.Size = new System.Drawing.Size(760, 22);
            this.tbSubject.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(46, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 23);
            this.label7.TabIndex = 10;
            this.label7.Text = "To";
            // 
            // tbToMail
            // 
            this.tbToMail.Location = new System.Drawing.Point(79, 34);
            this.tbToMail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbToMail.Name = "tbToMail";
            this.tbToMail.Size = new System.Drawing.Size(411, 22);
            this.tbToMail.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Bai6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 492);
            this.Controls.Add(this.grb_Setting);
            this.Controls.Add(this.grb_SignIn);
            this.Controls.Add(this.pn_SendMail);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pn_readmail);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Bai6";
            this.Text = "Task5";
            this.grb_SignIn.ResumeLayout(false);
            this.grb_SignIn.PerformLayout();
            this.grb_Setting.ResumeLayout(false);
            this.grb_Setting.PerformLayout();
            this.pn_readmail.ResumeLayout(false);
            this.pn_readmail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pn_SendMail.ResumeLayout(false);
            this.pn_SendMail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grb_SignIn;
        private Button btn_SignIn;
        private TextBox tbx_password;
        private TextBox tbx_account;
        private GroupBox grb_Setting;
        private TextBox tbx_SMTP;
        private TextBox tbx_IMAP;
        private Label label2;
        private Label label6;
        private Label label5;
        private DomainUpDown domainUpDown2;
        private DomainUpDown domainUpDown1;
        private Label label4;
        private Label label3;
        private ListView listView1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button btn_Refresh;
        private Panel pn_readmail;
        private Label lblFrom;
        private Label lblTo;
        private Label lblSubject;
        private RichTextBox richTextBox1;
        private Button btn_Back;
        private PictureBox pictureBox1;
        private Panel pn_SendMail;
        private Label label7;
        private TextBox tbToMail;
        private TextBox tbSubject;
        private Label label8;
        private Button button1;
        private Button btn_Send;
        private Label label1;
        private Button btn_Back2;
        private Button btn_Reply;
        private OpenFileDialog openFileDialog1;
        private Button btn_attach;
        private LinkLabel linkLabel1;
        private RichTextBox rtbBody;
    }
}
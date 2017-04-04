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
using OpenPop.Pop3;
using OpenPop.Mime;

namespace lab2_PR
{
    public partial class Form1 : Form
    {
        Pop3Client pop3Client;
        int count;
        public Form1()
        {
            InitializeComponent();
            tbEmail.Text = "aa@aa.aa";
            tbPassword.Text = "aa";
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (tbEmail.Text == "aa@aa.aa" || tbEmail.Text == "bb@bb.bb" || tbEmail.Text=="gubenco.andrei@gmail.com"/*&& tbPassword.Text == "aa"*/)
            {
                panelLogin.Visible = false;
                panelMain.Visible = true;
                tbMainUsername.Text = tbEmail.Text;
                tbMainPassword.Text = tbPassword.Text;
                tbSMTP.Text = "127.0.0.1";
                tbPort.Text = "25";
                tbPop3.Text = "127.0.0.1";
                tbPopPort.Text = "110";
                tbSubject.Text = "Test";
                tbMessage.Text = "Test message.";
                tbFromName.Text = tbEmail.Text;
                if(tbEmail.Text=="aa@aa.aa")tbToName.Text = "bb@bb.bb";
                else if (tbEmail.Text == "bb@bb.bb") tbToName.Text = "aa@aa.aa";

                if (tbToName.Text == "aa@aa.aa") tbPopUsername.Text = tbPopPassword.Text = "aa";
                else if (tbToName.Text == "bb@bb.bb") tbPopUsername.Text = tbPopPassword.Text = "bb";

                if (tbToName.Text == "aa@aa.aa") tbPopPassword.Text = "aa";
                else if (tbToName.Text == "bb@bb.bb") tbPopPassword.Text = "bb";

                if (tbEmail.Text == "gubenco.andrei@gmail.com")
                {
                    tbSMTP.Text = "smtp.gmail.com";
                    tbPort.Text = "587";
                }
            }
            else labelLoginError.Visible = true;
        }

        private void buttonClearMsg_Click(object sender, EventArgs e)
        {
            if (tbMessage.Text != "") tbMessage.Text = "";
            labelSuccess.Visible = false;
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage(tbFromName.Text, tbToName.Text, tbSubject.Text, tbMessage.Text);
                SmtpClient smtp = new SmtpClient(tbSMTP.Text);
                smtp.Port = Convert.ToInt32(tbPort.Text);
                if(tbSMTP.Text!="127.0.0.1")smtp.Credentials = new System.Net.NetworkCredential(tbMainUsername.Text, tbMainPassword.Text);
                if (tbSMTP.Text == "127.0.0.1") smtp.EnableSsl = false;
                else smtp.EnableSsl=true;
                smtp.Send(mail);
                labelSuccess.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void textBoxPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            try
            {
                pop3Client = new Pop3Client();
                pop3Client.Connect(tbPop3.Text, Convert.ToInt32(tbPopPort.Text), false);
                pop3Client.Authenticate(tbPopUsername.Text, tbPopPassword.Text);
                count = pop3Client.GetMessageCount();
                dataGridView.Rows.Clear();
                int counter = 0;
                for (int i = count; i >= 1; i--)
                {
                    OpenPop.Mime.Message message = pop3Client.GetMessage(i);
                    dataGridView.Rows.Add(i, message.Headers.Subject, message.Headers.From, message.Headers.Date);
                    counter++;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenPop.Mime.Message msg=pop3Client.GetMessage(count-dataGridView.CurrentCell.RowIndex);
            OpenPop.Mime.MessagePart msgpart = msg.FindFirstPlainTextVersion();
            MessageBox.Show("From: " + msg.Headers.From + "\nSubject: " + msg.Headers.Subject + "\nMessage: " + msg.MessagePart.BodyEncoding.GetString(msgpart.Body), "Message", MessageBoxButtons.OK);
        }

    }
}
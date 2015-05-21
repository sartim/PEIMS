using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;

namespace PEIMSV3Cs
{
    public partial class frmEmailYahoo : Form
    {
        public frmEmailYahoo()
        {
            InitializeComponent();
        }

        /*****private void SendButton_Click(object sender, EventArgs e)
        {
            SmtpClient smtpServer = new SmtpClient();
        MailMessage mail = new MailMessage();
        smtpServer.Credentials = new Net.NetworkCredential(gmailIDTextBox.Text, "@gmail.com", TextBox2.Text);
        smtpServer.Port = 587;
        smtpServer.Host = "smtp.gmail.com";
        smtpServer.EnableSsl = true;
        mail.From = new MailAddress(gmailIDTextBox.Text,"@gmail.com");
        
            if (RadioButton1.Checked == true)
            {
            mail.To.Add("91",TextBox3.Text, "@m3m.in");
            }
            else if{ 
                RadioButton2.Checked = true;
            mail.To.Add(TextBox3.Text);
        }
        mail.Subject = TextBox4.Text;
        mail.Body = TextBox5.Text;
        smtpServer.Send(mail);
        MessageBox.Show("mail is sent");
        }
         * ***/
    }
}

/***
 * 
 * SMS Client Application Form
 * ******/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SmsClient;

namespace PEIMSV3Cs
{
    public partial class frmSms : Form
    {
        public frmSms()
        {
            InitializeComponent();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            try
            {
                SendSms ss = new SendSms();
                String str = ss.send("XXXX", "XXXX", "Test from VS2010", "XXXXX");

                if (str == "1")
                {
                    MessageBox.Show("Message Send");
                }
                else if (str == "2")
                {
                    MessageBox.Show("No Internet Connection");
                }
                else
                {
                    MessageBox.Show("Invalid Login Or No Internet Connection");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtPassword.Text = "";
            txtBody.Text = "";
            txtReceiveNo.Text = "";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}



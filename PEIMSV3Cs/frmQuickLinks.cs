using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PEIMSV3Cs
{
    public partial class frmQuickLinks : Form
    {
        public frmQuickLinks()
        {
            InitializeComponent();
        }
        private void SmsServiceButton_Click(object sender, EventArgs e)
        {
            frmSms fs = new frmSms();
            fs.Show();
        }

        private void EmailYahooButton_Click(object sender, EventArgs e)
        {
            frmEmailYahoo fey = new frmEmailYahoo();
            fey.Show();
        }

        private void EmailGmailButton_Click(object sender, EventArgs e)
        {
            frmEmailGmail feg = new frmEmailGmail();
            feg.Show();
        }

        private void EmailHotmailButton_Click(object sender, EventArgs e)
        {
            frmEmailHotmail feh = new frmEmailHotmail();
            feh.Show();
        }

        private void emrDbaseButton_Click(object sender, EventArgs e)
        {
            frmPharmacyPrescriptionDatabase fppd = new frmPharmacyPrescriptionDatabase();
            fppd.Show();
        }

        private void NextButton1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
        }

        private void RepeatButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }

        private void PreviousButton1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }
    }
}

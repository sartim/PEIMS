using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PEIMSV3Cs
{
    public partial class frmUALogin1 : Form
    {
        public frmUALogin1()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                string myConnection = "datasource=localhost;port=3306;database=pharma;username=root;password=";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlCommand SelectCommand = new MySqlCommand("SELECT * FROM pharma.users WHERE username='" + this.userNameTextBox.Text + "' and password='" + passwordTextBox.Text + "' ; ", myConn);

                MySqlDataReader myReader;
                myConn.Open();
                myReader = SelectCommand.ExecuteReader();

                int count = 0;
                while (myReader.Read())
                {
                    count = count + 1;
                }
                if (count == 1)
                {
                    MessageBox.Show("User name and Password is correct");
                    this.Hide();
                    frmUsers f = new frmUsers();
                    f.ShowDialog();
                }
                else if (count > 1)
                {
                    MessageBox.Show("Duplicate User Name and Password ...Access Denied");
                }
                else
                    MessageBox.Show("User Name and Password is Not Correct ..Please Try Again");
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
            private void userNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = false;
            if (string.IsNullOrEmpty(userNameTextBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(userNameTextBox, "The field userName is required");
            }
            if (!e.Cancel) { errorProvider1.SetError(userNameTextBox, ""); }
        }

        private void passwordTextBox_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = false;
            if (string.IsNullOrEmpty(passwordTextBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(passwordTextBox, "The field password is required");
            }
            if (!e.Cancel) { errorProvider1.SetError(passwordTextBox, ""); }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        }
    }


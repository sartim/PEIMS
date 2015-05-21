/*
* ++++++++++++++++++++++++++++++++++++++++++++++++++
* Users Form
* ++++++++++++++++++++++++++++++++++++++++++++++++++
* */

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
	public partial class frmUsers : Form
	{
		private MySqlDataAdapter ad;
		
		public frmUsers()
		{
			InitializeComponent();
		}
		
		private void frmusers_Load(object sender, EventArgs e)
		{
			string strConn = "server=localhost;user id=root;database=pharma;password=;";
			ad = new MySqlDataAdapter("select * from `users`", strConn);
			MySqlCommandBuilder builder = new MySqlCommandBuilder(ad);
            ad.Fill(this.newDataSet.users);
			ad.DeleteCommand = builder.GetDeleteCommand();
			ad.UpdateCommand = builder.GetUpdateCommand();
			ad.InsertCommand = builder.GetInsertCommand();
			MySqlDataAdapter ad3;
			
		}
		
		private void Save_Click(object sender, EventArgs e)
		{
			if (!this.Validate()) return;
			usersBindingSource.EndEdit();
            ad.Update(this.newDataSet.users);
            MessageBox.Show("Record saved successfully");
			
		}
		
		private void frmusers_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = false;
		}
		
		private void idTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( idTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( idTextBox, "The field id is required" ); 
			}
			int v;
			string s = idTextBox.Text;
			if( !int.TryParse( s, out v ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( idTextBox, "The field id must be int." );
			}
			if( !e.Cancel ) { errorProvider1.SetError( idTextBox, "" ); } 
		}
		
		private void usernameTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( usernameTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( usernameTextBox, "The field username is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( usernameTextBox, "" ); } 
		}
		
		private void passwordTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( passwordTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( passwordTextBox, "The field password is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( passwordTextBox, "" ); } 
		}
		
		private void firstnameTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( firstnameTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( firstnameTextBox, "The field firstname is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( firstnameTextBox, "" ); } 
		}
		
		private void lastnameTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( lastnameTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( lastnameTextBox, "The field lastname is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( lastnameTextBox, "" ); } 
		}
		
		private void emailTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( emailTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( emailTextBox, "The field email is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( emailTextBox, "" ); } 
		}
		
		private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
		{
			usersBindingSource.AddNew();
		}

        private void AddButton_Click(object sender, EventArgs e)
        {
            usersBindingSource.AddNew();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            usersBindingSource.AddNew();
            MessageBox.Show("Please save the changes");
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!this.Validate()) return;
            usersBindingSource.EndEdit();
            ad.Update(this.newDataSet.users);
            MessageBox.Show("Record saved successfully");
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (!this.Validate()) return;
            usersBindingSource.EndEdit();
            ad.Update(this.newDataSet.users);
            MessageBox.Show("Record saved successfully");
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
	}
}

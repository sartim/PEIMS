/*
* ++++++++++++++++++++++++++++++++++++++++++++++++++
* Customer Form
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
	public partial class frmCustomer : Form
	{
		private MySqlDataAdapter ad;
		
		public frmCustomer()
		{
			InitializeComponent();
		}
		
		private void frmcustomer_Load(object sender, EventArgs e)
		{
			string strConn = "server=localhost;user id=root;database=pharma;password=;";
			ad = new MySqlDataAdapter("select * from `customer`", strConn);
			MySqlCommandBuilder builder = new MySqlCommandBuilder(ad);
			ad.Fill(this.newDataSet.customer);
			ad.DeleteCommand = builder.GetDeleteCommand();
			ad.UpdateCommand = builder.GetUpdateCommand();
			ad.InsertCommand = builder.GetInsertCommand();
			MySqlDataAdapter ad3;
			
		}
		
		private void Save_Click(object sender, EventArgs e)
		{
			if (!this.Validate()) return;
			customerBindingSource.EndEdit();
			ad.Update(this.newDataSet.customer);
            MessageBox.Show("Record Saved");
			
		}
		
		private void frmcustomer_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = false;
		}
		
		private void customerIDTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( customerIDTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( customerIDTextBox, "The field customerID is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( customerIDTextBox, "" ); } 
		}
		
		private void categoryIDTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( categoryIDTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( categoryIDTextBox, "The field categoryID is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( categoryIDTextBox, "" ); } 
		}
		
		private void locationIDTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( locationIDTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( locationIDTextBox, "The field locationID is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( locationIDTextBox, "" ); } 
		}
		
		private void customerNameTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( customerNameTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( customerNameTextBox, "The field customerName is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( customerNameTextBox, "" ); } 
		}
		
		private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
		{
			customerBindingSource.AddNew();
		}

        private void AddButton_Click(object sender, EventArgs e)
        {
            customerBindingSource.AddNew();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            customerBindingSource.RemoveCurrent();
            MessageBox.Show("Save the changes!");
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (!this.Validate()) return;
            customerBindingSource.EndEdit();
            ad.Update(this.newDataSet.customer);
            MessageBox.Show("Record updated");
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!this.Validate()) return;
            customerBindingSource.EndEdit();
            ad.Update(this.newDataSet.customer);
            MessageBox.Show("Record saved");
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
	}
}

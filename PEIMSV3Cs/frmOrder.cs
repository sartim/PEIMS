/*
* ++++++++++++++++++++++++++++++++++++++++++++++++++
* Order Form
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
	public partial class frmOrder : Form
	{
		private MySqlDataAdapter ad;
		
		public frmOrder()
		{
			InitializeComponent();
		}
		
		private void frmorder_Load(object sender, EventArgs e)
		{
			string strConn = "server=localhost;user id=root;database=pharma;password=;";
			ad = new MySqlDataAdapter("select * from `order`", strConn);
			MySqlCommandBuilder builder = new MySqlCommandBuilder(ad);
			ad.Fill(this.newDataSet.order);
			ad.DeleteCommand = builder.GetDeleteCommand();
			ad.UpdateCommand = builder.GetUpdateCommand();
			ad.InsertCommand = builder.GetInsertCommand();
			MySqlDataAdapter ad3;
			
		}
		
		private void Save_Click(object sender, EventArgs e)
		{
			if (!this.Validate()) return;
			if( (( DataRowView )orderBindingSource.Current )[ "orderDate" ] is DBNull )
			{
				((DataRowView)orderBindingSource.Current)["orderDate"] = orderDate_dateTimePicker.Value;
			}
			orderBindingSource.EndEdit();
			ad.Update(this.newDataSet.order);
			
		}
		
		private void frmorder_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = false;
		}
		
		private void orderIDTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( orderIDTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( orderIDTextBox, "The field orderID is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( orderIDTextBox, "" ); } 
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
		
		private void productNameTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( productNameTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( productNameTextBox, "The field productName is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( productNameTextBox, "" ); } 
		}
		
		private void amountTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( amountTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( amountTextBox, "The field amount is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( amountTextBox, "" ); } 
		}
		
		private void costTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( costTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( costTextBox, "The field cost is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( costTextBox, "" ); } 
		}
		
		private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
		{
			orderBindingSource.AddNew();
		}

        private void AddButton_Click(object sender, EventArgs e)
        {
            orderBindingSource.AddNew();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            orderBindingSource.RemoveCurrent();
            MessageBox.Show("Save the changes!");
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (!this.Validate()) return;
            if (((DataRowView)orderBindingSource.Current)["orderDate"] is DBNull)
            {
                ((DataRowView)orderBindingSource.Current)["orderDate"] = orderDate_dateTimePicker.Value;
            }
            orderBindingSource.EndEdit();
            ad.Update(this.newDataSet.order);
            MessageBox.Show("Record Saved Successfully");
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!this.Validate()) return;
            if (((DataRowView)orderBindingSource.Current)["orderDate"] is DBNull)
            {
                ((DataRowView)orderBindingSource.Current)["orderDate"] = orderDate_dateTimePicker.Value;
            }
            orderBindingSource.EndEdit();
            ad.Update(this.newDataSet.order);
            MessageBox.Show("Record Saved Successfully");
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
	}
}

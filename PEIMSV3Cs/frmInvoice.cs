/*
* ++++++++++++++++++++++++++++++++++++++++++++++++++
* Invoice Form
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
	public partial class frmInvoice : Form
	{
		private MySqlDataAdapter ad;
		
		public frmInvoice()
		{
			InitializeComponent();
		}
		
		private void frminvoice_Load(object sender, EventArgs e)
		{
			string strConn = "server=localhost;user id=root;database=pharma;password=;";
			ad = new MySqlDataAdapter("select * from `invoice`", strConn);
			MySqlCommandBuilder builder = new MySqlCommandBuilder(ad);
			ad.Fill(this.newDataSet.invoice);
			ad.DeleteCommand = builder.GetDeleteCommand();
			ad.UpdateCommand = builder.GetUpdateCommand();
			ad.InsertCommand = builder.GetInsertCommand();
			MySqlDataAdapter ad3;
			
		}
		
		private void Save_Click(object sender, EventArgs e)
		{
			if (!this.Validate()) return;
			if( (( DataRowView )invoiceBindingSource.Current )[ "date" ] is DBNull )
			{
				((DataRowView)invoiceBindingSource.Current)["date"] = date_dateTimePicker.Value;
			}
			invoiceBindingSource.EndEdit();
			ad.Update(this.newDataSet.invoice);
			
		}
		
		private void frminvoice_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = false;
		}
		
		private void invoiceIDTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( invoiceIDTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( invoiceIDTextBox, "The field invoiceID is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( invoiceIDTextBox, "" ); } 
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
		
		private void managerIDTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( managerIDTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( managerIDTextBox, "The field managerID is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( managerIDTextBox, "" ); } 
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
		
		
		
		
		private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
		{
			invoiceBindingSource.AddNew();
		}

        private void AddButton_Click(object sender, EventArgs e)
        {
            invoiceBindingSource.AddNew();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            invoiceBindingSource.RemoveCurrent();
            MessageBox.Show("Please save the changes");
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (!this.Validate()) return;
            if (((DataRowView)invoiceBindingSource.Current)["date"] is DBNull)
            {
                ((DataRowView)invoiceBindingSource.Current)["date"] = date_dateTimePicker.Value;
            }
            invoiceBindingSource.EndEdit();
            ad.Update(this.newDataSet.invoice);
            MessageBox.Show(" RecordUpdated");
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!this.Validate()) return;
            if (((DataRowView)invoiceBindingSource.Current)["date"] is DBNull)
            {
                ((DataRowView)invoiceBindingSource.Current)["date"] = date_dateTimePicker.Value;
            }
            invoiceBindingSource.EndEdit();
            ad.Update(this.newDataSet.invoice);
            MessageBox.Show("Record Saved");
        }
	}
}

/*
* ++++++++++++++++++++++++++++++++++++++++++++++++++
* Product Details
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
	public partial class frmPayrollDetails : Form
	{
		private MySqlDataAdapter ad;
		
		public frmPayrollDetails()
		{
			InitializeComponent();
		}
		
		private void frmpayrolldetails_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'newDataSet.payrolldetails' table. You can move, or remove it, as needed.
            this.payrolldetailsTableAdapter.Fill(this.newDataSet.payrolldetails);
			string strConn = "server=localhost;user id=root;database=pharma;password=;";
			ad = new MySqlDataAdapter("select * from `payrolldetails`", strConn);
			MySqlCommandBuilder builder = new MySqlCommandBuilder(ad);
			ad.Fill(this.newDataSet.payrolldetails);
			ad.DeleteCommand = builder.GetDeleteCommand();
			ad.UpdateCommand = builder.GetUpdateCommand();
			ad.InsertCommand = builder.GetInsertCommand();
			MySqlDataAdapter ad3;
			
		}
		
		private void Save_Click(object sender, EventArgs e)
		{
			if (!this.Validate()) return;
			payrolldetailsBindingSource.EndEdit();
			ad.Update(this.newDataSet.payrolldetails);
            MessageBox.Show("Record saved");
			
		}
		
		private void frmpayrolldetails_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = false;
		}
		
		private void employeeIDTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( employeeIDTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( employeeIDTextBox, "The field employeeID is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( employeeIDTextBox, "" ); } 
		}
		
		private void employeeNameTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( employeeNameTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( employeeNameTextBox, "The field employeeName is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( employeeNameTextBox, "" ); } 
		}
		
		private void salaryTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( salaryTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( salaryTextBox, "The field salary is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( salaryTextBox, "" ); } 
		}
		
		private void AccountNoTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
            if (string.IsNullOrEmpty(accountNoTextBox.Text))
			{
				e.Cancel = true;
				errorProvider1.SetError( accountNoTextBox, "The field AccountNo is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( accountNoTextBox, "" ); } 
		}
		
		private void departmentIDTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( departmentIDTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( departmentIDTextBox, "The field departmentID is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( departmentIDTextBox, "" ); } 
		}
		
		
		
		
		private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
		{
			payrolldetailsBindingSource.AddNew();
		}

        private void payrolldetailsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.payrolldetailsBindingSource.EndEdit();
            this.payrolldetailsTableAdapter.Update(this.newDataSet.payrolldetails);

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            payrolldetailsBindingSource.AddNew();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.payrolldetailsBindingSource.EndEdit();
            this.payrolldetailsTableAdapter.Update(this.newDataSet.payrolldetails);
            MessageBox.Show("Record updated");
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.payrolldetailsBindingSource.EndEdit();
            this.payrolldetailsTableAdapter.Update(this.newDataSet.payrolldetails);
            MessageBox.Show("Record Saved");
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            payrolldetailsBindingSource.RemoveCurrent();
            MessageBox.Show("Save the changes!");
        }
	}
}

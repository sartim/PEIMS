/*
* ++++++++++++++++++++++++++++++++++++++++++++++++++
* Department Form
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
	public partial class frmDepartment : Form
	{
		private MySqlDataAdapter ad;
		
		public frmDepartment()
		{
			InitializeComponent();
		}
		
		private void frmdepartment_Load(object sender, EventArgs e)
		{
			string strConn = "server=localhost;user id=root;database=pharma;password=;";
			ad = new MySqlDataAdapter("select * from `department`", strConn);
			MySqlCommandBuilder builder = new MySqlCommandBuilder(ad);
			ad.Fill(this.newDataSet.department);
			ad.DeleteCommand = builder.GetDeleteCommand();
			ad.UpdateCommand = builder.GetUpdateCommand();
			ad.InsertCommand = builder.GetInsertCommand();
			MySqlDataAdapter ad3;
			
		}
		
		private void Save_Click(object sender, EventArgs e)
		{
			if (!this.Validate()) return;
			departmentBindingSource.EndEdit();
			ad.Update(this.newDataSet.department);
			
		}
		
		private void frmdepartment_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = false;
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
		
		private void nameTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( nameTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( nameTextBox, "The field name is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( nameTextBox, "" ); } 
		}
		
		private void noOfEmployeesTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( noOfEmployeesTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( noOfEmployeesTextBox, "The field noOfEmployees is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( noOfEmployeesTextBox, "" ); } 
		}
		
		private void descriptionTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( descriptionTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( descriptionTextBox, "The field description is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( descriptionTextBox, "" ); } 
		}
		
		
		
		
		private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
		{
			departmentBindingSource.AddNew();
		}

        private void AddButton_Click(object sender, EventArgs e)
        {
            departmentBindingSource.AddNew();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            departmentBindingSource.RemoveCurrent();
            MessageBox.Show("Please Save the Changes");
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (!this.Validate()) return;
            departmentBindingSource.EndEdit();
            ad.Update(this.newDataSet.department);
            MessageBox.Show("Record Updated Successfully");
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!this.Validate()) return;
            departmentBindingSource.EndEdit();
            ad.Update(this.newDataSet.department);
            MessageBox.Show("Record Saved Successfully");
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

	}
}

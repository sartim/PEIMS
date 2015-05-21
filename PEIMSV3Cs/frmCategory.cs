/*
* ++++++++++++++++++++++++++++++++++++++++++++++++++
* Categroy Form
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
	public partial class frmCategory : Form
	{
		private MySqlDataAdapter ad;
		
		public frmCategory()
		{
			InitializeComponent();
		}
		
		private void frmcategory_Load(object sender, EventArgs e)
		{
			string strConn = "server=localhost;user id=root;database=pharma;password=;";
			ad = new MySqlDataAdapter("select * from `category`", strConn);
			MySqlCommandBuilder builder = new MySqlCommandBuilder(ad);
			ad.Fill(this.newDataSet.category);
			ad.DeleteCommand = builder.GetDeleteCommand();
			ad.UpdateCommand = builder.GetUpdateCommand();
			ad.InsertCommand = builder.GetInsertCommand();
			MySqlDataAdapter ad3;
			
		}
		
		private void Save_Click(object sender, EventArgs e)
		{
			if (!this.Validate()) return;
			categoryBindingSource.EndEdit();
			ad.Update(this.newDataSet.category);
            MessageBox.Show("Record Saved");
		}
		
		private void frmcategory_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = false;
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
		
		private void categoryNameTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( categoryNameTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( categoryNameTextBox, "The field categoryName is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( categoryNameTextBox, "" ); } 
		}
		
		private void categoryDescriptionTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( categoryDescriptionTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( categoryDescriptionTextBox, "The field categoryDescription is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( categoryDescriptionTextBox, "" ); } 
		}
		
		private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
		{
			categoryBindingSource.AddNew();
		}

        private void AddButton_Click(object sender, EventArgs e)
        {
            categoryBindingSource.AddNew();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            categoryBindingSource.RemoveCurrent();
            MessageBox.Show("Save the changes!");
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (!this.Validate()) return;
            categoryBindingSource.EndEdit();
            ad.Update(this.newDataSet.category);
            MessageBox.Show("Record Updated");
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!this.Validate()) return;
            categoryBindingSource.EndEdit();
            ad.Update(this.newDataSet.category);
            MessageBox.Show("Record Saved");
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
	}
}

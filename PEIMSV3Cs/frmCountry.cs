/*
* ++++++++++++++++++++++++++++++++++++++++++++++++++
* Country Form
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
	public partial class frmCountry : Form
	{
		private MySqlDataAdapter ad;
		
		public frmCountry()
		{
			InitializeComponent();
		}
		
		private void frmcountry_Load(object sender, EventArgs e)
		{
			string strConn = "server=localhost;user id=root;database=pharma;password=;";
			ad = new MySqlDataAdapter("select * from `country`", strConn);
			MySqlCommandBuilder builder = new MySqlCommandBuilder(ad);
			ad.Fill(this.newDataSet.country);
			ad.DeleteCommand = builder.GetDeleteCommand();
			ad.UpdateCommand = builder.GetUpdateCommand();
			ad.InsertCommand = builder.GetInsertCommand();
			MySqlDataAdapter ad3;
			
		}
		
		private void Save_Click(object sender, EventArgs e)
		{
			if (!this.Validate()) return;
			countryBindingSource.EndEdit();
			ad.Update(this.newDataSet.country);
            MessageBox.Show("Record Saved");
		}
		
		private void frmcountry_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = false;
		}
		
		private void countryIDTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( countryIDTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( countryIDTextBox, "The field countryID is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( countryIDTextBox, "" ); } 
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
		
		private void populationTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( populationTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( populationTextBox, "The field population is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( populationTextBox, "" ); } 
		}
		
		private void percAgeOf_MenTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( percAgeOf_MenTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( percAgeOf_MenTextBox, "The field percAgeOf Men is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( percAgeOf_MenTextBox, "" ); } 
		}
		
		private void percAgeOf_WomenTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( percAgeOf_WomenTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( percAgeOf_WomenTextBox, "The field percAgeOf Women is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( percAgeOf_WomenTextBox, "" ); } 
		}
		
		private void percAgeOfChildrenTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( percAgeOfChildrenTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( percAgeOfChildrenTextBox, "The field percAgeOfChildren is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( percAgeOfChildrenTextBox, "" ); } 
		}
		
		private void perCapitalAnnualIncomeTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( perCapitalAnnualIncomeTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( perCapitalAnnualIncomeTextBox, "The field perCapitalAnnualIncome is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( perCapitalAnnualIncomeTextBox, "" ); } 
		}
		
		private void areaTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( areaTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( areaTextBox, "The field area is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( areaTextBox, "" ); } 
		}
		
		private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
		{
			countryBindingSource.AddNew();
		}

        private void AddButton_Click(object sender, EventArgs e)
        {
            countryBindingSource.AddNew();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            countryBindingSource.RemoveCurrent();
            MessageBox.Show("Save the changes!");
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (!this.Validate()) return;
            countryBindingSource.EndEdit();
            ad.Update(this.newDataSet.country);
            MessageBox.Show("Record Updated");
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!this.Validate()) return;
            countryBindingSource.EndEdit();
            ad.Update(this.newDataSet.country);
            MessageBox.Show("Record Saved");
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
	}
}

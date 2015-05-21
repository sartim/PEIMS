/*
* ++++++++++++++++++++++++++++++++++++++++++++++++++
* Cases Form
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
	public partial class frmCases : Form
	{
        MySqlConnection mcon = new MySqlConnection("server=localhost;database=pharma;uid=root;passwrord=");
        MySqlCommand mcd;
        MySqlDataReader mdr;
        string s;
		private MySqlDataAdapter ad;
		
		public frmCases()
		{
			InitializeComponent();
		}
		
		private void frmcases_Load(object sender, EventArgs e)
		{
			string strConn = "server=localhost;user id=root;database=pharma;password=;";
			ad = new MySqlDataAdapter("select * from `cases`", strConn);
			MySqlCommandBuilder builder = new MySqlCommandBuilder(ad);
			ad.Fill(this.newDataSet.cases);
			ad.DeleteCommand = builder.GetDeleteCommand();
			ad.UpdateCommand = builder.GetUpdateCommand();
			ad.InsertCommand = builder.GetInsertCommand();
			MySqlDataAdapter ad3;
			
		}
		
		private void Save_Click(object sender, EventArgs e)
		{
			if (!this.Validate()) return;
			if( (( DataRowView )casesBindingSource.Current )[ "date" ] is DBNull )
			{
				((DataRowView)casesBindingSource.Current)["date"] = date_dateTimePicker.Value;
			}
			casesBindingSource.EndEdit();
			ad.Update(this.newDataSet.cases);
            MessageBox.Show("Record Saved");
			
		}
		
		private void frmcases_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = false;
		}
		
		private void caseIDTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( caseIDTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( caseIDTextBox, "The field caseID is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( caseIDTextBox, "" ); } 
		}
		
		private void diseaseIDTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( diseaseIDTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( diseaseIDTextBox, "The field diseaseID is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( diseaseIDTextBox, "" ); } 
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
		
		private void causeTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( causeTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( causeTextBox, "The field cause is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( causeTextBox, "" ); } 
		}
		
		private void noOfCasualtiesTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( noOfCasualtiesTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( noOfCasualtiesTextBox, "The field noOfCasualties is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( noOfCasualtiesTextBox, "" ); } 
		}
		private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
		{
			casesBindingSource.AddNew();
		}

        private void AddButton_Click(object sender, EventArgs e)
        {
            casesBindingSource.AddNew();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            casesBindingSource.RemoveCurrent();
            MessageBox.Show("Save the changes!");
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (!this.Validate()) return;
            if (((DataRowView)casesBindingSource.Current)["date"] is DBNull)
            {
                ((DataRowView)casesBindingSource.Current)["date"] = date_dateTimePicker.Value;
            }
            casesBindingSource.EndEdit();
            ad.Update(this.newDataSet.cases);
            MessageBox.Show("Record Updated");
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!this.Validate()) return;
            if (((DataRowView)casesBindingSource.Current)["date"] is DBNull)
            {
                ((DataRowView)casesBindingSource.Current)["date"] = date_dateTimePicker.Value;
            }
            casesBindingSource.EndEdit();
            ad.Update(this.newDataSet.cases);
            MessageBox.Show("Record Saved");
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void SearchIDButton_Click(object sender, EventArgs e)
        {
            try
            {
                mcon.Open();
                s = "select * from pharma.cases where (caseID = '" + caseIDTextBox.Text + "') OR (diseaseID = '" + diseaseIDTextBox.Text + "')";
                mcd = new MySqlCommand(s, mcon);
                mdr = mcd.ExecuteReader();
                if (mdr.Read())
                {
                    diseaseIDTextBox.Text = mdr.GetString("diseaseID");
                    diseaseIDTextBox.Text = mdr.GetString("locationID");
                    diseaseIDTextBox.Text = mdr.GetString("date");
                    diseaseIDTextBox.Text = mdr.GetString("cause");
                    diseaseIDTextBox.Text = mdr.GetString("noOfCasualties");
                }
                else
                {
                    MessageBox.Show("Record Not Found!");
                }
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            {
                mdr.Close();
                mcon.Close();
            }
        }
	}
}

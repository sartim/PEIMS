/*
 * ++++++++++++++++++++++++++++++++++++++++++++++++++
 * Main Form.
 * ++++++++++++++++++++++++++++++++++++++++++++++++++
 * */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PEIMSV3Cs
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

    private void frmMain_Load(object sender, EventArgs e)
    {

    }
        private void quickLinksToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmQuickLinks f = new frmQuickLinks();
            f.MdiParent = this;
            f.Show();
        }

        private void orderFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrder f = new frmOrder();
            f.MdiParent = this;
            f.Show();
        }

        private void orderReportToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmOrderReport r = new frmOrderReport();
            r.MdiParent = this;
            r.Show();
        }

        private void invoiceFormToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmInvoice f = new frmInvoice();
            f.MdiParent = this;
            f.Show();
        }

        private void invoiceReportToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmInvoiceReport r = new frmInvoiceReport();
            r.MdiParent = this;
            r.Show();
        }

        private void customerFormToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmCustomer f = new frmCustomer();
            f.MdiParent = this;
            f.Show();
        }

        private void productFormToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmProduct f =new frmProduct();
            f.MdiParent = this;
            f.Show();
        }

        private void productReportToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmProductReport r = new frmProductReport();
            r.MdiParent = this;
            r.Show();
        }

        private void inventoryItemFormToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmInventoryItem f = new frmInventoryItem();
            f.MdiParent = this;
            f.Show();
        }

        private void inventoryItemReportToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmInventoryItemReport r = new frmInventoryItemReport();
            r.MdiParent = this;
            r.Show();
        }

        private void rFIDTagFormToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmRfid f = new frmRfid();
            f.MdiParent = this;
            f.Show();
        }

        private void rFIDTagReportToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmRfidReport r = new frmRfidReport();
            r.MdiParent = this;
            r.Show();
        }

        private void shippingFormToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            frmShipping f = new frmShipping();
            f.MdiParent = this;
            f.Show();
        }

        private void shippingReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShippingReport r = new frmShippingReport();
            r.MdiParent = this;
            r.Show();
        }

        private void locationFormToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmLocation f = new frmLocation();
            f.MdiParent = this;
            f.Show();
        }

        private void locationReportToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmLocationReport r = new frmLocationReport();
            r.MdiParent = this;
            r.Show();
        }

        private void productConsumptionFormToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmproductconsumption f = new frmproductconsumption();
            f.MdiParent = this;
            f.Show();
        }

        private void productConsumptionReportToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmProductConsumptionReport r = new frmProductConsumptionReport();
            r.MdiParent = this;
            r.Show();
        }

        private void diseaseFormToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmDisease f = new frmDisease();
            f.MdiParent = this;
            f.Show();
        }

        private void diseaseReportToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmDiseaseReport r = new frmDiseaseReport();
            r.MdiParent = this;
            r.Show();
        }

        private void countryFormToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmCountry f = new frmCountry();
            f.MdiParent = this;
            f.Show();
        }

        private void contryReportToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmCountryReport r = new frmCountryReport();
            r.MdiParent = this;
            r.Show();
        }

        private void casesFormToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmCases f = new frmCases();
            f.MdiParent = this;
            f.Show();
        }

        private void casesReportToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmCasesReport r = new frmCasesReport();
            r.MdiParent = this;
            r.Show();
        }

        private void categoryFormToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmCategory f = new frmCategory();
            f.MdiParent = this;
            f.Show();
        }

        private void categoryReportToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmCategoryReport r = new frmCategoryReport();
            r.MdiParent = this;
            r.Show();
        }

        private void employeeFormToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmEmployee f = new frmEmployee();
            f.MdiParent = this;
            f.Show();
        }

        private void employeeReportToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmEmployeeReport r = new frmEmployeeReport();
            r.MdiParent = this;
            r.Show();
        }

        private void departmentFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDepartment f = new frmDepartment();
            f.MdiParent = this;
            f.Show();
        }

        private void departmentReportToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmDepartmentReport r = new frmDepartmentReport();
            r.MdiParent = this;
            r.Show();
        }

        private void payrollFormToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmPayrollDetails f = new frmPayrollDetails();
            f.MdiParent = this;
            f.Show();
        }

        private void payrollReportToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmPayrollReport r = new frmPayrollReport();
            r.MdiParent = this;
            r.Show();
        }

        private void authorizarionAuthenticationProfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUALogin1 ua = new frmUALogin1();
            ua.MdiParent = this;
            ua.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutPEIMSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox a = new AboutBox();
            a.Show();
        } 
    }
}
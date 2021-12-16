using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ACCUNTING.AccuntingForms;
using ACCUNTING.CustomersForms;
using Accunting.DataLayer.Context;
using Accounting.utility.Convertor;
using Accounting.Besenes;
using Accunting.ViewModel.Account;


namespace ACCUNTING
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnInsertCustuomer_Click(object sender, EventArgs e)
        {
            FrmCustomers frmCustomers  = new FrmCustomers();
            frmCustomers.ShowDialog();
        }

        private void BtnInsertReport_Click(object sender, EventArgs e)
        {
           FrmNewAccunting frmNewAccounting = new FrmNewAccunting();
            frmNewAccounting.ShowDialog();
        }

        private void BtnRecevid_Click(object sender, EventArgs e)
        {
            FrmReport frmReport = new FrmReport();
            frmReport.TypeID = 1;
            frmReport.ShowDialog();
        }

        private void BtnPayments_Click(object sender, EventArgs e)
        {
            FrmReport frmReport = new FrmReport();
            frmReport.TypeID = 2;
            frmReport.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.Hide();
            //FrmLogin frmLogin = new FrmLogin();
            //if (frmLogin.ShowDialog() == DialogResult.OK)
            //{
            //    this.Show();
            //    Report();
            //    lblDate.Text = DateConvertor.ToShamsi(DateTime.Now);
            //    lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
            //}
            //else
            //{
            //    Application.Exit();
            //}
        }

        private void ToolStripDropDownButton3_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.IsEdit = true;
            frmLogin.ShowDialog();
        }

        private void BtnSeting_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.IsEdit = true;
            frmLogin.ShowDialog();
        }
        public void Report()
        {
            string vahed = "   تومان";
            ReportViewModel rp = Account.ReportFormMine();
            lblPay.Text = rp.Pay.ToString("#,0")+vahed;
            lblRecive.Text = rp.Resive.ToString("#,0")+vahed;
            lblAccountBalanse.Text = rp.AccountBalance.ToString("#,0")+vahed;
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            Report();
        }

       

       
    }
}

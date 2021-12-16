using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accunting.DataLayer.Context;
using Accunting.DataLayer.DbModel;
using ValidationComponents;

namespace ACCUNTING.AccuntingForms
{
    public partial class FrmNewAccunting : Form
    {
        private UnitOfWork db;
        
        public int AccountID = 0;
        public FrmNewAccunting()
        {
            InitializeComponent();
        }

        private void FrmNewAccunting_Load(object sender, EventArgs e)
        {
            db = new UnitOfWork();
            dgvCustomeers.AutoGenerateColumns = false;
            dgvCustomeers.DataSource = db.CustomerRepository.GetNameCustomers();
            if (AccountID != 0)
            {
                var account = db.AccountingRepository.GetById(AccountID);
                txtAmount.Text = account.Amount.ToString();
                txtDescription.Text = account.Description;
                txtName.Text = db.CustomerRepository.GetCustomerNameById(account.CustomerId);
                if (account.TypeId == 1)
                {
                    rbRecive.Checked = true;
                }
                else
                {
                    rbPay.Checked = true;
                }

                this.Text = "ویرایش";
                btnSave.Text = "ویرایش";
                db.Dispose();
            }
        }

        private void TxtFilter_TextChanged(object sender, EventArgs e)
        {
            dgvCustomeers.AutoGenerateColumns = false;
            dgvCustomeers.DataSource = db.CustomerRepository.GetNameCustomers(txtFilter.Text);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                if (rbPay.Checked || rbRecive.Checked)
                {
                    db = new UnitOfWork();
                    Accunting.DataLayer.DbModel.Accunting accounting = new Accunting.DataLayer.DbModel.Accunting()
                    {
                        Amount = int.Parse(txtAmount.Value.ToString()),
                        CustomerId = db.CustomerRepository.GetCustomerIdByName(txtName.Text),
                        TypeId = (rbRecive.Checked) ? 1 : 2,
                        DateTime = DateTime.Now,
                        Description = txtDescription.Text

                    };
                    if (AccountID == 0)
                    {
                        db.AccountingRepository.Insert(accounting);
                        db.Save();
                    }
                    else
                    {
                        accounting.Id = AccountID;
                        db.AccountingRepository.Update(accounting);

                    }
                    db.Save();
                    db.Dispose();
                    DialogResult = DialogResult.OK;
                   
                }
                else
                {
                    RtlMessageBox.Show("لطفا نوع تراکنش را انتخاب کنید");
                }
            }
        }

        private void DgvCustomeers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = dgvCustomeers.CurrentRow.Cells[0].Value.ToString();
        }
    }
}

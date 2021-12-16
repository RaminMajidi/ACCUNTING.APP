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
using Accounting.utility.Convertor;
using Accunting.ViewModel.Customers;
using ACCUNTING.AccuntingForms;


namespace ACCUNTING.AccuntingForms
{
    public partial class FrmReport : Form
    {

        public int TypeID = 0;
        public FrmReport()
        {
            InitializeComponent();
        }

        void Filter()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                List<Accunting.DataLayer.DbModel.Accunting> result = new List<Accunting.DataLayer.DbModel.Accunting>();
                DateTime? startDate;
                DateTime? endDate;
                if ((int)cbCustomer.SelectedValue != 0)
                {
                    int customerId = int.Parse(cbCustomer.SelectedValue.ToString());
                    result.AddRange(db.AccountingRepository.Get(a => a.TypeId == TypeID && a.CustomerId == customerId));
                }
                else
                {
                    result.AddRange(db.AccountingRepository.Get(a => a.TypeId == TypeID));
                }

                if (txtFromDate.Text != "    /  /")
                {
                    startDate = Convert.ToDateTime(txtFromDate.Text);
                    startDate = DateConvertor.ToMiladi(startDate.Value);
                    result = result.Where(r => r.DateTime >= startDate.Value).ToList();
                }
                if (txtToDate.Text != "    /  /")
                {
                    endDate = Convert.ToDateTime(txtToDate.Text);
                    endDate = DateConvertor.ToMiladi(endDate.Value);
                    result = result.Where(r => r.DateTime <= endDate.Value).ToList();
                }

                dgReport.Rows.Clear();
                foreach (var accounting in result)
                {
                    string customerName = db.CustomerRepository.GetCustomerNameById(accounting.CustomerId);
                    dgReport.Rows.Add(accounting.Id, customerName, accounting.Amount, accounting.DateTime.ToShamsi(), accounting.Description);
                }
            }

        }

        private void FrmReport_Load(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                List<ListCustomerViewModel> list = new List<ListCustomerViewModel>();
                list.Add(new ListCustomerViewModel()
                {
                    CustomerID = 0,
                    FullName = "انتخاب کنید"
                });
                list.AddRange(db.CustomerRepository.GetNameCustomers());
                cbCustomer.DataSource = list;
                cbCustomer.DisplayMember = "FullName";
                cbCustomer.ValueMember = "CustomerID";
            }
            if (TypeID == 1)
            {
                this.Text = "گزارش دریافتی ها";
            }
            else
            {
                this.Text = "گزارش پرداختی ها";
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dgReport.CurrentRow != null)
            {
                int id = int.Parse(dgReport.CurrentRow.Cells[0].Value.ToString());
                FrmNewAccunting frmNew = new FrmNewAccunting();
                frmNew.AccountID = id;
                if (frmNew.ShowDialog() == DialogResult.OK)
                {
                    Filter();
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgReport.CurrentRow != null)
            {
                int id = int.Parse(dgReport.CurrentRow.Cells[0].Value.ToString());
                if (RtlMessageBox.Show("آیا از حذف مطمئتن هستید ؟", "هشدار", MessageBoxButtons.YesNo) ==
                    DialogResult.Yes)
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        db.AccountingRepository.Delete(id);
                        db.Save();
                        Filter();
                    }
                }
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            Filter();
        }

        private void BtnFilter_Click(object sender, EventArgs e)
        {
            Filter();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            DataTable dtprint = new DataTable();
            dtprint.Columns.Add("Customer");
            dtprint.Columns.Add("Amount");
            dtprint.Columns.Add("Date");
            dtprint.Columns.Add("Description");
            foreach(DataGridViewRow dtg in dgReport.Rows)
            {
                dtprint.Rows.Add(
                    dtg.Cells[1].Value.ToString(),
                    dtg.Cells[2].Value.ToString(),
                    dtg.Cells[3].Value.ToString(),
                    dtg.Cells[4].Value.ToString()
                    );
                stiReport1.Load(Application.StartupPath + "/Report.mrt");
                stiReport1.RegData("DT", dtprint);
                stiReport1.Show();
            }
        }
    }
}

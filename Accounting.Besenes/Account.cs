using Accunting.DataLayer.Context;
using Accunting.ViewModel.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Besenes
{
   public  class Account
    {
        public static ReportViewModel ReportFormMine()
        {
            ReportViewModel rp = new ReportViewModel();
            using(UnitOfWork db = new UnitOfWork())
            {
                DateTime startdate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 01);
                DateTime enddate = new DateTime(DateTime.Now.Year, DateTime.Now.Month,28);
                var Recive = db.AccountingRepository.Get(r => r.TypeId == 1 && r.DateTime >= startdate && r.DateTime <= enddate).Select(a => a.Amount).ToList();
                var Pay = db.AccountingRepository.Get(r => r.TypeId == 2 && r.DateTime >= startdate && r.DateTime <= enddate).Select(a => a.Amount).ToList();
                rp.Resive = Recive.Sum();
                rp.Pay = Pay.Sum();
                rp.AccountBalance = (Recive.Sum() - Pay.Sum());
            }
            return rp  ;
        }
    }
}

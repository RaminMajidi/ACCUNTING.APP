using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accunting.DataLayer.DbModel;
using Accunting.DataLayer.Repositore;
using Accunting.DataLayer.Serves;

namespace Accunting.DataLayer.Context
{
   public class UnitOfWork:IDisposable
    {
        Accunting_dbEntities db = new Accunting_dbEntities();

        private ICustomerRepository _customerRepository;
        public ICustomerRepository CustomerRepository
        {
            get
            {
                if (_customerRepository == null)
                {
                    _customerRepository = new CustomerRepository(db);
                }

                return _customerRepository;
            }
        }


        private GenericRepository<DbModel.Accunting> _accountingRepository;

        public GenericRepository<DbModel.Accunting> AccountingRepository
        {
            get
            {
                if (_accountingRepository == null)
                {
                    _accountingRepository = new GenericRepository<DbModel.Accunting>(db);
                }

                return _accountingRepository;
            }
        }


        private GenericRepository<Login> _loginRepository;

        public GenericRepository<Login> LoginRepository
        {
            get
            {
                if (_loginRepository == null)
                {
                    _loginRepository = new GenericRepository<Login>(db);
                }
                return _loginRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}

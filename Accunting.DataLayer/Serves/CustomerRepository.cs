using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accunting.DataLayer.DbModel;
using Accunting.ViewModel.Customers;
using Accunting.DataLayer.Repositore;

namespace Accunting.DataLayer.Serves
{
  public  class CustomerRepository:ICustomerRepository
    {

        private Accunting_dbEntities db;

        public CustomerRepository(Accunting_dbEntities context)
        {
            db = context;
        }

        public List<Customer> GetAllCustomers()
        {
            return db.Customer.ToList();
        }

        public IEnumerable<Customer> GetCusstomersByFilter(string parameter)
        {
            return db.Customer.Where(c =>
                c.FullName.Contains(parameter) || c.Email.Contains(parameter) || c.Mobile.Contains(parameter)).ToList();
        }

        public List<ListCustomerViewModel> GetNameCustomers(string filter = "")
        {
            if (filter == "")
            {
                return db.Customer.Select(c => new ListCustomerViewModel()
                {
                    CustomerID = c.CustomerId,
                    FullName = c.FullName
                }).ToList();
            }

            return db.Customer.Where(c => c.FullName.Contains(filter)).Select(c => new ListCustomerViewModel()
            {
                CustomerID = c.CustomerId,
                FullName = c.FullName
            }).ToList();
        }

        public Customer GetCustomerById(int customerId)
        {
            return db.Customer.Find(customerId);
        }

        public bool InsertCustomer(Customer customer)
        {
            try
            {
                db.Customer.Add(customer);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateCustomer(Customer customer)
        {
           
            var local = db.Set<Customer>()
                .Local
                .FirstOrDefault(f => f.CustomerId == customer.CustomerId);
            if (local != null)
            {
                db.Entry(local).State = System.Data.Entity.EntityState.Detached;
            }
            db.Entry(customer).State = System.Data.Entity.EntityState.Modified;
            return true;
            
        }

        public bool DeleteCustomer(Customer customer)
        {
            try
            {
                db.Entry(customer).State = System.Data.Entity.EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteCustomer(int customerId)
        {
            try
            {
                var customer = GetCustomerById(customerId);
                DeleteCustomer(customer);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public int GetCustomerIdByName(string name)
        {
            return db.Customer.First(c => c.FullName == name).CustomerId;
        }

        public string GetCustomerNameById(int customerId)
        {
            return db.Customer.Find(customerId).FullName;
        }



    }
}

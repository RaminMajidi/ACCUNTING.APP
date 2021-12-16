using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accunting.DataLayer.DbModel;
using Accunting.ViewModel.Customers;



namespace Accunting.DataLayer.Repositore
{
  public   interface ICustomerRepository
    {
        List<Customer> GetAllCustomers();
        IEnumerable<Customer> GetCusstomersByFilter(string parameter);
        List<ListCustomerViewModel> GetNameCustomers(string filter = "");
        Customer GetCustomerById(int customerId);
        bool InsertCustomer(Customer customer);
        bool UpdateCustomer(Customer customer);
        bool DeleteCustomer(Customer customer);
        bool DeleteCustomer(int customerId);
        int GetCustomerIdByName(string name);
        string GetCustomerNameById(int customerId);
    }
}

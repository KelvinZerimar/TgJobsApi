using Domain.DomainEntities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface ICustomerRepository
    {
        Customer GetCustomer(int idCustomer);
        IEnumerable<Customer> GetCustomerProducts();
        Task<IEnumerable<Customer>> getCustomerFromApiAsync();
    }
}

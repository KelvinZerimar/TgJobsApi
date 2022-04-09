using Domain.DomainEntities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Repository
{
    /// <summary>
    /// Repository Customer
    /// </summary>
    public class CustomerRepository : RepositoryBase<Customer>, ICustomerRepository
    {
        private readonly TgJobsContext _tgJobsContext;

        public CustomerRepository()
        {
            _tgJobsContext = new TgJobsContext();
        }

        /// <summary>
        /// Obtener un customer
        /// </summary>
        /// <param name="idCustomer"></param>
        /// <returns></returns>
        public Customer GetCustomer(int idCustomer) =>
            _tgJobsContext.customers.FirstOrDefault(c => c.CustomerID == idCustomer);

        /// <summary>
        /// Obtener listado de customer con sus products
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public IEnumerable<Customer> GetCustomerProducts()
        {
            var query = (from cus in _tgJobsContext.customers
                         join sal in _tgJobsContext.sales on cus.CustomerID equals sal.CustomerID
                         select new Customer
                         {
                             CustomerID = cus.CustomerID,
                             Name = cus.Name,
                             EmailAddress = cus.EmailAddress,
                             Products = (from pro in _tgJobsContext.products
                                         where sal.SalesOrderDetails.Exists(x => x.ProductID == pro.ProductID)
                                         select pro).ToList()
                         }).ToList();

            return query;
        }

        /// <summary>
        /// Obtener un customer de forma asincrona
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Customer>> getCustomerFromApiAsync() {
            await Task.Delay(1000);
            return _tgJobsContext.customers; 
        }


    }
}

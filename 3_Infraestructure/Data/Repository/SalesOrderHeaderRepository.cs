using Domain.DomainEntities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Data.Repository
{
    class SalesOrderHeaderRepository: RepositoryBase<SalesOrderHeader>, ISalesOrderHeaderRepository
    {
        private readonly TgJobsContext _tgJobsContext;

        public SalesOrderHeaderRepository()
        {
            _tgJobsContext = new TgJobsContext();
        }

        /// <summary>
        /// Obtener las compras dado un customerId
        /// </summary>
        /// <param name="idCustomer"></param>
        /// <returns></returns>
        public IEnumerable<SalesOrderHeader> GetSalesByCustomer(int idCustomer) =>
             _tgJobsContext.sales.Where(s => s.CustomerID == idCustomer).ToList();

        /// <summary>
        /// Obtener la venta más pesada (la suma de los pesos de los productos
        /// </summary>
        /// <returns></returns>
        public SalesOrderHeader GetWeightestSale()
        {
            /*var query = from sl in _tgJobsContext.sales
                        group sl by sl.SalesOrderDetails into sd
                        select new 
                        {
                            a = (from pro in _tgJobsContext.products
                                 where sd.Exists(x => x.ProductID == pro.ProductID)
                                 select pro).ToList()
                        }*/
            throw new NotImplementedException();
        }
    }
}

using Domain.DomainEntities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Data.Repository
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        private readonly TgJobsContext _tgJobsContext;

        public ProductRepository()
        {
            _tgJobsContext = new TgJobsContext();
        }

        /// <summary>
        /// Obtener el producto más vendido
        /// </summary>
        /// <returns></returns>
        public Product GetTopProduct()
        {
            var queryTopProduct = _tgJobsContext.sales.SelectMany(x => x.SalesOrderDetails)
                .GroupBy(x=>x.ProductID).OrderByDescending(x=>x.Count()).FirstOrDefault();

            return _tgJobsContext.products.Where(prod=>prod.ProductID == queryTopProduct.Key).FirstOrDefault();
        }
             
    }
}



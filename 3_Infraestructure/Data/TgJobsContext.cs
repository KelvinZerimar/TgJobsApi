using Domain.DomainEntities;
using Infrastructure.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data
{
    class TgJobsContext
    {
        public readonly List<Customer> customers;
        public readonly List<Product> products;
        public readonly List<SalesOrderHeader> sales;

        public TgJobsContext()
        {
            this.customers = CustomerHelper.generateCustomers();
            this.products = ProductHelper.generateProducts();
            this.sales = SaleHelper.getSales();
        }
    }
}

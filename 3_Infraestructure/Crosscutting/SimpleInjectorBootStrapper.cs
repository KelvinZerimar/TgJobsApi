using Domain.Interfaces;
using Infrastructure.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Crosscutting
{
    public class SimpleInjectorBootStrapper
    {
        public static void RegisterService(IServiceCollection services)
        {
            //Application - Domain
            //...
            //Domain - Data
            services.AddSingleton<ICustomerRepository, CustomerRepository>();
            services.AddSingleton<IProductRepository, ProductRepository>();
            services.AddSingleton<ISalesOrderHeaderRepository, SalesOrderHeaderRepository>();
        }
    }
}

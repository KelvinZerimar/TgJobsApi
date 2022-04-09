using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TgJobsApi.Models;
using TgJobsAPI.Services.Interfaces;

namespace TgJobsAPI.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        /// <summary>
        /// Obtener el producto más vendido
        /// </summary>
        /// <returns></returns>
        public ProductDto GetTopProduct()
        {
            var productResult = _productRepository.GetTopProduct();
            return new ProductDto(productResult);
        }
    }
}

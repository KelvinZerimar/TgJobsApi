using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using TgJobsApi.Models;
using System;
using System.Threading.Tasks;
using TgJobsApi.Services;
using Microsoft.Extensions.Logging;
using TgJobsAPI.Services;

namespace TgJobsApi.Controllers
{
    [ApiController, Produces("application/json")]
    [Route("api/")]
    public class ValuesController : ControllerBase
    {
        private readonly CustomerService _customerService;
        private readonly SalesOrderHeaderService _salesOrderHeaderService;
        private readonly ProductService _productService;
        private readonly ILogger<ValuesController> _logger;

        public ValuesController(ILogger<ValuesController> logger, 
            CustomerService customerService,
            ProductService productService,
            SalesOrderHeaderService salesOrderHeaderService)
        {          
            _customerService = customerService;
            _productService = productService;
            _salesOrderHeaderService = salesOrderHeaderService;
            _logger = logger;
        }

        /// <summary>
        /// Endpoint para obtener un customer
        /// </summary>
        /// <returns>Un objeto Customer</returns>
        [HttpGet("getCustomer/{idCustomer}")]
        public IActionResult GetCustomer(int idCustomer)
        {
            CustomerDto customer = _customerService.getCustomer(idCustomer); 
            return Ok(customer);
        }

        /// <summary>
        /// Endpoint para obtener las compras dado un customerId
        /// </summary>
        /// <returns>Listado de SalesOrderHeader</returns>
        [HttpGet("getSalesByCustomer/{idCustomer}/")]
        public IActionResult GetSalesByCustomer(int idCustomer)
        {
            IEnumerable<SalesOrderHeaderDto> listSales = _salesOrderHeaderService.GetSalesByCustomer(idCustomer);
            return Ok(listSales);
        }

        /// <summary>
        /// Endpoint para obtener el producto más vendido
        /// </summary>
        /// <returns>Un objeto Product</returns>
        [HttpGet("getTopProduct")]
        public IActionResult GetTopProduct()
        {
            // Solución Ejercicio 1 
            ProductDto product = _productService.GetTopProduct();
            return Ok(product);
        }

        /// <summary>
        /// Endpoint para obtener los clientes y sus prodcutos comprados
        /// </summary>
        /// <returns>Listado de customer con array de products</returns>
        [HttpGet("getCustomerProducts")]
        public IActionResult GetCustomerProducts()
        {
            // Solución Ejercicio 2
            IEnumerable<CustomerDto> listCustomers = _customerService.GetCustomerProducts();
            return Ok(listCustomers);
        }

        /// <summary>
        /// Endpoint para obtener la venta más pesada (la suma de los pesos de los productos
        /// </summary>
        /// <returns>Un objeto SalesOrderHeader</returns>
        [HttpGet("getWeightestSale")]
        public IActionResult GetWeightestSale()
        {
            // Ejercicio 3 incompleta
            return BadRequest(new NotImplementedException());
        }

        /// <summary>
        /// Endpoint para obtener un customer usando async/await
        /// </summary>
        /// <returns>Un objeto Customer</returns>
        [HttpGet("getCustomerasync/{idCustomer}")]
        public async Task<IActionResult> GetCustomerAsync(int idCustomer)
        {
            // Solución Ejercicio 5
            var customer = await _customerService.getCustomerFromApiAsync();
            return Ok(customer.Where(c => c.CustomerID == idCustomer).FirstOrDefault());
        }
    }
}

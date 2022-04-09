using System.Collections.Generic;
using System.Threading.Tasks;
using TgJobsApi.Models;
using TgJobsAPI.Services.Interfaces;
using Domain.Interfaces;
using System.Linq;

namespace TgJobsApi.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        /// <summary>
        /// Retornar Customer por su ID
        /// </summary>
        /// <param name="idCustomer"></param>
        /// <returns></returns>
        public CustomerDto getCustomer(int idCustomer)
        {
            var customerResult = _customerRepository.GetCustomer(idCustomer);
            return new CustomerDto(customerResult);
        }

        /// <summary>
        /// Retornar los clientes y sus productos comprados
        /// </summary>
        /// <returns></returns>
        public IEnumerable<CustomerDto> GetCustomerProducts()
        {
            return _customerRepository.GetCustomerProducts()
                            .Select(entity => new CustomerDto(entity));
        }

        /// <summary>
        /// Obtener un customer por su Id Asyn
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<CustomerDto>> getCustomerFromApiAsync()
        {
            var customers =  await _customerRepository.getCustomerFromApiAsync();
            return customers.ToList().Select(entity => new CustomerDto(entity));
        }

    }
}

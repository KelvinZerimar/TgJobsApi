using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TgJobsApi.Models;

namespace TgJobsAPI.Services.Interfaces
{
    public interface ICustomerService
    {
        Task<IEnumerable<CustomerDto>> getCustomerFromApiAsync();
        CustomerDto getCustomer(int idCustomer);
        IEnumerable<CustomerDto> GetCustomerProducts();
    }
}

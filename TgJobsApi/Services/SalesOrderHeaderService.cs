using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TgJobsApi.Models;
using TgJobsAPI.Services.Interfaces;

namespace TgJobsAPI.Services
{
    public class SalesOrderHeaderService: ISalesOrderHeaderService
    {
        private readonly ISalesOrderHeaderRepository _salesOrderHeaderRepository;

        public SalesOrderHeaderService(ISalesOrderHeaderRepository salesOrderHeaderRepository)
        {
            _salesOrderHeaderRepository = salesOrderHeaderRepository;
        }

        /// <summary>
        /// Retornar las compras dado un customerId
        /// </summary>
        /// <param name="idCustomer"></param>
        /// <returns></returns>
        public IEnumerable<SalesOrderHeaderDto> GetSalesByCustomer(int idCustomer)
        {
            return _salesOrderHeaderRepository.GetSalesByCustomer(idCustomer)
                .Select(entity => new SalesOrderHeaderDto(entity));
        }
    }
}

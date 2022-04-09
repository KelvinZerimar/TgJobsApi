namespace TgJobsApi.Models
{
    using Domain.DomainEntities;
    using System;
    using System.Collections.Generic;

    public partial class SalesOrderHeaderDto
    {
        public SalesOrderHeaderDto()
        {
            this.SalesOrderDetails = new List<SalesOrderDetailDto>();
        }

        public SalesOrderHeaderDto(SalesOrderHeader salesOrderHeaderResult) 
        {
            this.SalesOrderID = salesOrderHeaderResult.SalesOrderID;
            this.CustomerID = salesOrderHeaderResult.CustomerID;
            this.OrderDate = salesOrderHeaderResult.OrderDate;
            this.ShipDate = salesOrderHeaderResult.ShipDate;
            this.Status = salesOrderHeaderResult.Status;
            this.Total = salesOrderHeaderResult.Total;
            //
            SalesOrderDetails = new List<SalesOrderDetailDto>();
            salesOrderHeaderResult.SalesOrderDetails?.ForEach(item => {
            this.SalesOrderDetails.Add(new SalesOrderDetailDto
            {   ProductID = item.ProductID,
                Price = item.Price });
            });
        }

        public int SalesOrderID { get; set; }

        public int CustomerID { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime? ShipDate { get; set; }

        /// <summary>
        /// 1. Pending
        /// 2. Sent
        /// 3. Complete
        /// </summary>
        public byte Status { get; set; }

        public double Total { get; set; }

        public virtual ICollection<SalesOrderDetailDto> SalesOrderDetails { get; set; }
    }
}

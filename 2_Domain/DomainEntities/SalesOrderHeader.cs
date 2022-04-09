namespace Domain.DomainEntities
{
    using System;
    using System.Collections.Generic;

    public partial class SalesOrderHeader
    {
        public SalesOrderHeader()
        {
            this.SalesOrderDetails = new List<SalesOrderDetail>();
        }

        public SalesOrderHeader(int Id, int CustomerId, DateTime OrderDate, DateTime? ShipDate, byte Status) 
            : this()
        {
            this.SalesOrderID = Id;
            this.CustomerID = CustomerId;
            this.OrderDate = OrderDate;
            this.ShipDate = ShipDate;
            this.Status = Status;
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

        // Solución Ejercicio 4: variable privada para asignar el total de la venta
        private double _total;
        public double Total { 
            get {
                SalesOrderDetails.ForEach(x => { _total += x.Price; });
                return _total;
            }
            set { //...
            } 
        } 
        
        public virtual List<SalesOrderDetail> SalesOrderDetails { get; set; }
    }
}

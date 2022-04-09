namespace Domain.DomainEntities
{
    public partial class SalesOrderDetail
    {
        public SalesOrderDetail() { }

        public SalesOrderDetail(int ProductId, double Price)
        {
            this.ProductID = ProductId;
            this.Price = Price;
        }

        public int ProductID { get; set; }

        public double Price { get; set; }
    }
}

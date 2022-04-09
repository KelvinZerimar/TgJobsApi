namespace TgJobsApi.Models
{
    public partial class SalesOrderDetailDto
    {
        public SalesOrderDetailDto() { }

        public SalesOrderDetailDto(int ProductId, double Price)
        {
            this.ProductID = ProductId;
            this.Price = Price;
        }

        public int ProductID { get; set; }

        public double Price { get; set; }
    }
}

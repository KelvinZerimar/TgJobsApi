namespace TgJobsApi.Models
{
    using Domain.DomainEntities;
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public partial class ProductDto
    {
        public ProductDto() { }

        public ProductDto(Product product)
        {
            this.ProductID = product.ProductID;
            this.Name = product.Name;
            this.Color = product.Color;
            this.Price = product.Price;
            this.Weight = product.Weight;
        }

        public int ProductID { get; set; }

        public string Name { get; set; }

        public string Color { get; set; }

        public double Price { get; set; }

        public double? Weight { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual ICollection<SalesOrderDetailDto> SalesOrderDetail { get; set; }
    }
}

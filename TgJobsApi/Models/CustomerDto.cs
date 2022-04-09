namespace TgJobsApi.Models
{
    using Domain.DomainEntities;
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public partial class CustomerDto
    {
        public CustomerDto() {  }

        public CustomerDto(Customer customerResult)
        {
            this.CustomerID = customerResult.CustomerID;
            this.Name = customerResult.Name;
            this.EmailAddress = customerResult.EmailAddress;
            this.Products = new List<ProductDto>();
            customerResult.Products?.ForEach(item => { this.Products.Add(new ProductDto { 
                ProductID = item.ProductID, 
                Name = item.Name, 
                Color = item.Color, 
                Price = item.Price, 
                Weight = item.Weight }); 
            });
        }

        public int CustomerID { get; set; }

        public string Name { get; set; }

        public string EmailAddress { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual ICollection<SalesOrderHeaderDto> SalesOrderHeader { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual ICollection<ProductDto> Products { get; set; }
    }
}

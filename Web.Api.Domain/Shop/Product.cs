using System;
using System.Collections.Generic;
using System.Text;

namespace Web.Api.Domain.Shop
{
    public class Product
    {
        public string prodcutCode;

        public Product()
        {
        }
        public Guid productId { get; set; }
        public string productCode { get; set; }
        public string productName { get; set; }
        public DateTime releaseDate { get; set; }
        public double price { get; set; }
        public double starRaging { get; set; }

    }
}

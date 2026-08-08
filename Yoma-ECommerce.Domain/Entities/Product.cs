using System;
using System.Collections.Generic;
using System.Text;

namespace Yoma_ECommerce.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public int StockQuantity { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreatedAt { get; set; }

    }
}

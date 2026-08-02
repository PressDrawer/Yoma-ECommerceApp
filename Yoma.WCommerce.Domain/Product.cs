using System;
using System.Collections.Generic;
using System.Text;

namespace Yoma.WCommerce.Domain
{
    internal class Product : BaseEntity
    {
        public string? ProductName { get; set; }
        public decimal Price { get; set; }
    }
}

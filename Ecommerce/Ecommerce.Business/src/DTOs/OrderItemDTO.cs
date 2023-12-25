using Ecommerce.Core.src.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Business.src.DTOs
{
    public class OrderItemReadDTO
    {
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
    }
    public class OrderItemCreateDTO
    {
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public Guid ProductId { get; set; }
    }
}
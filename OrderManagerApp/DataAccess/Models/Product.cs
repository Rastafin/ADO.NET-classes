using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Product(string name, decimal price, int stockQuantity)
    {
        public int Id { get; set; }
        public string Name { get; set; } = name;
        public decimal Price { get; set; } = price;
        public int StockQuantity { get; set; } = stockQuantity;
    }
}

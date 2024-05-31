using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataAccess.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; } 
        public decimal Price { get; set; } 
        public int StockQuantity { get; set; } 
        public Product (string name, decimal price, int stockQuantity)
        {
            Name = name;
            Price = price;
            StockQuantity = stockQuantity;
        }
        public Product(int id, string name, decimal price, int stockQuantity)
        {
            ProductId = id;
            Name = name;
            Price = price;
            StockQuantity = stockQuantity;
        }
    }


}

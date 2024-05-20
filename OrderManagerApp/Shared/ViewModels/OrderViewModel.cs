using DataAccess.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.ViewModels
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public string? CustomerName { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatus Status { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ValidApiCore3._1.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        public string ProductName { get; set; }

        public string CustomerName { get; set; }

        public string ContractId { get; set; }

        public int ProductCount { get; set; }

        public double ProductPrice { get; set; }

        public double FinalPrice { get; set; }

        public DateTime OrderDate { get; set; }

    }
}

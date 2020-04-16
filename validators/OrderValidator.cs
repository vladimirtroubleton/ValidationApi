using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ValidApiCore3._1.Models;

namespace ValidApiCore3._1.validators
{
    public class OrderValidator : IOrderValidator
    {
        public bool CheckOrderValid(OrderModel order)
        {
            if (order != null && order.FinalPrice > 0.01 && order.ProductName.Length > 1 && order.ContractId.Length > 10)
            {
                return true;
            }

            return false;
        }
    }
}

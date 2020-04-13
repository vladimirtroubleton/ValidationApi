using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ValidApiCore3._1.Contexts;
using ValidApiCore3._1.Models;

namespace ValidApiCore3._1.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private OrderContext context;

        public OrderRepository(OrderContext context)
        {
            this.context = context;
        }

        public OrderModel[] GetAllOrders()
        {
            return context.Orders.ToArray();
        }

        public void CreateOrder(OrderModel order)
        {
            context.Orders.Add(order);
        }
    }
}

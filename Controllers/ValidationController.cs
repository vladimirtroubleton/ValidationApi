using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ValidApiCore3._1.JsonModels;
using ValidApiCore3._1.modelBuilders;
using ValidApiCore3._1.Repositories;

namespace ValidApiCore3._1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValidationController : ControllerBase
    {
        private readonly IOrderRepository orderRepository;

        public ValidationController(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }

        [HttpGet("workingcheck")]  
        public string WorkingCheck()
        {
            var ordersByDb = orderRepository.GetAllOrders();
            var ordersInString = OrderBuilder.GetAllOrdersInString(ordersByDb);

            return ordersInString; 
        }

        [HttpPost("ordercreate")]
        public string OrderCreate(object order)
        {
            var receivedOrder = Desirialize<OrderJsonModel>(order.ToString());

            var formedOrder = OrderBuilder.CreateOrder(receivedOrder);

            orderRepository.CreateOrder(formedOrder);

            return "OrderCreated"; 
        }


        private TResult Desirialize<TResult>(string data)
        {
            return JsonConvert.DeserializeObject<TResult>(data);
        }

        private string Serialize<TParam>(TParam orders)
        {
            return JsonConvert.SerializeObject(orders);
        }
    }
}

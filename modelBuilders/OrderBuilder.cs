using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ValidApiCore3._1.JsonModels;
using ValidApiCore3._1.Models;

namespace ValidApiCore3._1.modelBuilders
{
    public static class OrderBuilder
    {
        public static string GetAllOrdersInString(OrderModel[] orders)
        {
            var stringList = new List<string>();
            foreach (var order in orders) 
            {
                stringList.Add("\nНомер договора - " + order.ContractId + " Имя заказчика - " + order.CustomerName + " Название товара- " + order.ProductName + " Сумма заказа- " + order.FinalPrice + " Дата заказа- " + order.OrderDate );
            }

            return String.Join(" " , stringList);
        }

        public static OrderModel CreateOrder(OrderJsonModel orderJsonModel)
        {
            return new OrderModel
            {
                ProductName = orderJsonModel.ProductName,
                CustomerName = orderJsonModel.CustomerName,
                ProductCount = orderJsonModel.ProductCount,
                ProductPrice = orderJsonModel.ProductPrice,
                ContractId = Guid.NewGuid().ToString(),
                FinalPrice = orderJsonModel.ProductPrice * orderJsonModel.ProductCount,
                OrderDate = DateTime.Now
            };
        }
    }

   
}

using ValidApiCore3._1.Models;

namespace ValidApiCore3._1.Repositories
{
    public interface IOrderRepository
    {
        void CreateOrder(OrderModel order);
        OrderModel[] GetAllOrders();
    }
}
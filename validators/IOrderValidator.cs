using ValidApiCore3._1.Models;

namespace ValidApiCore3._1.validators
{
    public interface IOrderValidator
    {
        bool CheckOrderValid(OrderModel order);
    }
}
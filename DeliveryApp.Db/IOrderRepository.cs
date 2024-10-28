using DeliveryApp.Db.Models;

namespace DeliveryApp.Db
{
    public interface IOrderRepository
    {
        Order Get(Guid id);
        List<Order> GetAll();
        void Add(Order order);
        void Update(Order order);
        void Remove(Guid id);

    }
}

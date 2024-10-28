

using DeliveryApp.Db.Models;

namespace DeliveryApp.Db
{
    public class OrderListRepository : IOrderRepository
    {
        private readonly List<Order> orderViewModels = new List<Order>();
        public void Add(Order order)
        {
            orderViewModels.Add(order);
        }

        public Order Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetAll()
        {
            return orderViewModels;
        }

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Order order)
        {
            throw new NotImplementedException();
        }
    }
}

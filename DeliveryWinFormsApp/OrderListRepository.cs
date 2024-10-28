using DeliveryWinFormsApp.Models;

namespace DeliveryWinFormsApp
{
    public class OrderListRepository : IOrderRepository
    {
        private readonly List<OrderViewModel> orderViewModels = new List<OrderViewModel>();
        public void Add(OrderViewModel order)
        {
            orderViewModels.Add(order);
        }

        public OrderViewModel Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<OrderViewModel> GetAll()
        {
            return orderViewModels;
        }

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(OrderViewModel order)
        {
            throw new NotImplementedException();
        }
    }
}

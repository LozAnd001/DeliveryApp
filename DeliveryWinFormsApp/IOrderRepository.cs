using DeliveryWinFormsApp.Models;

namespace DeliveryWinFormsApp
{
    public interface IOrderRepository
    {
        OrderViewModel Get(Guid id);
        List<OrderViewModel> GetAll();
        void Add(OrderViewModel order);
        void Update(OrderViewModel order);
        void Remove(Guid id);

    }
}

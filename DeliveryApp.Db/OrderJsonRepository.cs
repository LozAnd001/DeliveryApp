using DeliveryApp.Db.Models;
using Newtonsoft.Json;

namespace DeliveryApp.Db
{
    public class OrderJsonRepository : IOrderRepository
    {
        public static string path = "orders.json";
        public void Add(Order order)
        {
            var orders = GetAll();
            orders.Add(order);
            Save(orders);
        }

        public Order Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetAll()
        {
            if(!FileProvider.Exists(path))
            {
                return new List<Order>();
            }
            var fileData = FileProvider.GetValue(path);
            var orders = JsonConvert.DeserializeObject<List<Order>>(fileData);
            return orders;
        }

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Order order)
        {
            throw new NotImplementedException();
        }

        private void Save(List<Order> orders)
        {
            var jsonData = JsonConvert.SerializeObject(orders, Formatting.Indented);
            FileProvider.Replace(path, jsonData);
        }
    }
}

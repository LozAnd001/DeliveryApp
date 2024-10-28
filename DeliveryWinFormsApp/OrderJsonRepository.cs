using DeliveryWinFormsApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryWinFormsApp
{
    public class OrderJsonRepository : IOrderRepository
    {
        public static string path = "orders.json";
        public void Add(OrderViewModel order)
        {
            var orders = GetAll();
            orders.Add(order);
            Save(orders);
        }

        public OrderViewModel Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<OrderViewModel> GetAll()
        {
            if(!FileProvider.Exists(path))
            {
                return new List<OrderViewModel>();
            }
            var fileData = FileProvider.GetValue(path);
            var orders = JsonConvert.DeserializeObject<List<OrderViewModel>>(fileData);
            return orders;
        }

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(OrderViewModel order)
        {
            throw new NotImplementedException();
        }

        private void Save(List<OrderViewModel> orders)
        {
            var jsonData = JsonConvert.SerializeObject(orders, Formatting.Indented);
            FileProvider.Replace(path, jsonData);
        }
    }
}

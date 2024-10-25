using DeliveryWinFormsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryWinFormsApp
{
    public static class OrderStorage
    {
        private static List<OrderViewModel> orderViewModelsStorage = new List<OrderViewModel>();
        public static void AddOrder(OrderViewModel order)
        {
            orderViewModelsStorage.Add(order);
        }

        public static List<OrderViewModel> GetOrders()
        {
            return orderViewModelsStorage;
        }
    }
}

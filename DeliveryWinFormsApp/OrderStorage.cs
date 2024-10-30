using DeliveryApp.Db;
using DeliveryApp.Db.Models;
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
        private static IOrderRepository orderRepository = new OrderJsonRepository();

        public static void Add(OrderViewModel orderViewModel)
        {
            var order = Map.GetDB(orderViewModel);
            orderRepository.Add(order);
        }

        public static List<OrderViewModel> GetAll()
        {
            var orders = orderRepository.GetAll();
            var ordersViewModel = new List<OrderViewModel>();
            foreach (var order in orders)
            {
                ordersViewModel.Add(Map.GetVM(order));
            }
            return ordersViewModel;
        }
    }
}

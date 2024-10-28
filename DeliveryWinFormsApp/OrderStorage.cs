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
        public static void Add(OrderViewModel order)
        {
            orderRepository.Add(order);
        }

        public static List<OrderViewModel> GetAll()
        {
            return orderRepository.GetAll();
        }
    }
}

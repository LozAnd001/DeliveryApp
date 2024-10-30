using DeliveryApp.Db.Models;
using DeliveryWinFormsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryWinFormsApp
{
    public static class Map
    {
        public static District GetDB(DistrictViewModel district)
        {
            return new District()
            {
                Name = district.Name,
                Id = district.Id,
            };
        }
        public static Order GetDB(OrderViewModel order)
        {
            return new Order
            {
                Id = order.Id,
                Weight = order.Weight,
                District = GetDB(order.District),
                OrderDeliveryDate = order.OrderDeliveryDate,
                OrderCreationDate = order.OrderCreationDate
            };
        }
        public static DistrictViewModel GetVM(District district)
        {
            return new DistrictViewModel(district.Name)
            {
                Id = district.Id,
            };
        }
        public static OrderViewModel GetVM(Order order)
        {
            return new OrderViewModel
            {
                Id = order.Id,
                Weight = order.Weight,
                District = GetVM(order.District),
                OrderDeliveryDate = order.OrderDeliveryDate,
                OrderCreationDate = order.OrderCreationDate
            };
        }
    }
}

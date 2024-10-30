using DeliveryApp.Db.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryApp.Db
{
    public class OrderDBRepository : IOrderRepository
    {
        private readonly DatabaseContext dbContext;
        public void Add(Order order)
        {
            dbContext.Orders.Add(order);
            dbContext.SaveChanges();
        }

        public Order Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetAll()
        {
            return dbContext.Orders.ToList();
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

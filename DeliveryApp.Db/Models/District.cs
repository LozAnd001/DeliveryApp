using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace DeliveryApp.Db.Models
{
    public class District
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public virtual ObservableCollectionListSource<Order> Orders { get; } = new();
        
    }
}

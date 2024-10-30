namespace DeliveryApp.Db.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public int Weight { get; set; }
        public DateTime OrderDeliveryDate { get; set; }
        public DateTime OrderCreationDate { get; set; }
        public Guid DistrictId { get; set; }
        public virtual District District { get; set; }
        

    }
}

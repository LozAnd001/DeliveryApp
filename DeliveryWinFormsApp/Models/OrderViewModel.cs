namespace DeliveryWinFormsApp.Models
{
    public class OrderViewModel
    {
        public Guid Id { get; set; }
        public int Weight { get; set; }
        public DistrictViewModel District { get; set; }
        public DateTime OrderDeliveryDate { get; set; }
        public DateTime OrderCreationDate { get; set;}
        //public OrderViewModel(int weight, DistrictViewModel district, DateTime orderDeliveryDate, DateTime orderCreationDate)
        //{
        //    Id = Guid.NewGuid();
        //    Weight = weight;
        //    District = district;
        //    OrderDeliveryDate = orderDeliveryDate;
        //    OrderCreationDate = orderCreationDate;
        //}
    }
}

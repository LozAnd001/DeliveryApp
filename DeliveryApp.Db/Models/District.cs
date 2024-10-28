namespace DeliveryApp.Db.Models
{
    public class District
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public District(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
        }
    }
}

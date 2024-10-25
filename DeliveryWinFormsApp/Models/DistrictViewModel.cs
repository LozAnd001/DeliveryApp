using System.Web;

namespace DeliveryWinFormsApp.Models
{
    public class DistrictViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DistrictViewModel(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
        }
    }
}

using JM.Database;

namespace FoloNow.Database.Models.Entities
{
    public class Customer : EntityBase
    {
        public string Name { get; set; }
        public string Email { get; set; }
        //public virtual ICollection<Order> Orders { get; set; }
    }
}

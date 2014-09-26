
using JM.Database;

namespace FoloNow.MongoDB.Model.Model
{
   public class Contact : MongoBase
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}


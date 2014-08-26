using System.Data.Entity.ModelConfiguration.Conventions;

namespace FoloNow.Database
{
    public class DomainConventions : Convention
    {
        public DomainConventions()
        {

            Properties<int>()
                .Where(p => p.Name == "Id")
                .Configure(p => p.IsKey());

        }
    }
}

using System.Data.Entity;
using FoloNow.Database.Models.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FoloNow.Database.Tests
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void CustomerOrderTest()
        {
            System.Data.Entity.Database.SetInitializer<EFContext>(new CreateDatabaseIfNotExists<EFContext>());
            using (var context = new EFContext())
            {
                context.Database.CreateIfNotExists();
                Customer customer = new Customer
                {
                    Name = "Raviendra",
                    Email = "raviendra@test.com",
                    
                };
                context.Entry(customer).State = (EntityState) System.Data.EntityState.Added;
                context.SaveChanges();
            }
        }
    }
}

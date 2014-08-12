using System;
using System.Collections.Generic;
using System.Data.Entity;
using FoloNow.Database.Entities;
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
                //context.Database.Create();
                Customer customer = new Customer
                {
                    Name = "Raviendra",
                    Email = "raviendra@test.com",
                    
                };
                //context.Entry(customer).State = (EntityState) System.Data.EntityState.Added;
                context.SaveChanges();
            }
        }
    }
}

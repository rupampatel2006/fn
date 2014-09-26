using System.Collections.Generic;
using System.Web.Http;
using FoloNow.Database;

namespace JM.Web.Api.Controllers
{
    public class ValuesController : ApiController
    {
        private EfRepository repository = new EfRepository(new EFContext());
        //public ValuesController(EfRepository repo)
        //{
        //    repository = repo;
        //}
        //public ValuesController()
        //{
        //    repository = new EfRepository();
        //}
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        //public IEnumerable<CustomerModel> Get()
        //{
        //    return repository.GetAll<Customer>().Select(a => new CustomerModel
        //    {
        //        Email = a.Email,
        //        Id = a.Id,
        //        Name = a.Name

        //    }).ToList();
        //}

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}

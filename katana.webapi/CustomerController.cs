using System;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using katana.domain;

namespace katana.webapi
{
    public class CustomerController : ApiController
    {
        private CustomerContext db = new CustomerContext();

        public CustomerController()
        {
        }

        // Gets
        [HttpGet]
        public Customer Get(string customerId)
        {
            return new Customer()
            {
                Id= Int32.Parse(customerId),
                LastName = "Smith",

            };
        }

        [ResponseType(typeof(Customer))]
        public async Task<IHttpActionResult> PostCustomer(Customer customer)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                db.Customers.Add(customer);
                await db.SaveChangesAsync();

                return CreatedAtRoute("DefaultApi", new { id = customer.Id }, customer);
            }
            catch (Exception)
            {
                
                throw;
            }

        }

    }
}

using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Reflection;
using TodoApi.Models;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    public class CustomersController : Controller
    {        
        // POST api/values
        [HttpPost]
        public void CreateCustomer([FromForm]Customer customer)
        {
            AddCustomer(customer);
        }

        private void AddCustomer(Customer customer) 
        {
            var path = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

            using (StreamWriter file = new StreamWriter(Path.Combine(path, "Customers.txt")))
            {
                file.WriteLine(customer.Name);
            }
        }
    }
}

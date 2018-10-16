using Lagash.NoSql.MongoDB.Repository.MongoDB;
using Lagash.NoSql.MongoDB.Models;

namespace Lagash.NoSql.MongoDB
{
    class Program
    {        
        static void Main(string[] args)
        {
            IMongoDB service = new MongoDb();

            var customerRepository = new CustomersRepository(service,"customers");

            customerRepository.CreateOrUpdate(new Customer()
            {
                Name = "Horacio",
            });
        }
    }
}
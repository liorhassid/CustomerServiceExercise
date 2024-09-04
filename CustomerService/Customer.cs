
namespace CustomerService
{
    public class Customer
    {
        public int Id { get; set; }

        public Customer()
        {
            IdGenerator idg = new IdGenerator();
            Id = idg.Generate();
        }
    }
}

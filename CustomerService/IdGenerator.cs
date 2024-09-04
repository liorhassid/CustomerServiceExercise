
namespace CustomerService
{
    public class IdGenerator
    {
        private static int generatedId = 0;

        public int Generate()
        {
            generatedId++;
            return generatedId;
        }
    }
}

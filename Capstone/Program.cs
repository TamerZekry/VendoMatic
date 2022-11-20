using Capstone.Models;

namespace Capstone
{
    public class Program
    {

        static void Main(string[] args)
        {
            VendOMatic800 vendOMatic800 = new VendOMatic800();
            vendOMatic800.Start();
        }
    }
}


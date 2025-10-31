using System.Runtime.Serialization.Formatters;

namespace SwitchMethodCall
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //teha switch rakendus,
            //kus kasutaja sisestab sõiduki tüübi (couple või truck)
            string input = Console.ReadLine();
            //ja programm kustub vastava meetodi (CarCouple või Truck)
            switch (input)
            {
                case "car couple":
                    CarCouple();

                    break;

                case "truck":
                    Truck();

                    break;
                default:
                    Console.WriteLine("Unknown vehicle typle.");
                    break;
            }
        }

        static void CarCouple()
        {
            Console.WriteLine("This is a couple car.");
        }

        static void Truck()
        {
            Console.WriteLine("This is a truck.");
        }
    }
}
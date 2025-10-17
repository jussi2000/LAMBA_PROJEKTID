namespace SwitchWithNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta number");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("Valisid 1");
                    Console.Beep();
                    break;

                case "2":
                    Console.WriteLine("Valisid 2");
                    Console.Beep(); 
                    Console.Beep();
                    break;

                case "3":
                    Console.WriteLine("Valisid 3");
                    Console.Beep();
                    Console.Beep(); 
                    Console.Beep();
                    break;

                default:
                    Console.WriteLine("ERROR");
                    break;
            }
        }
    }
}

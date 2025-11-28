namespace ComputercalcLogic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("Kui palju on 3 + 8 / (4 - 2) * 4 = ?");
            Console.WriteLine("Kui palju on 3 + 8 / 4 - 2 * 4 = ?");
            Console.WriteLine("Kui palju on (3 + 8) / (4 - 2) * 4 = ?");
            Console.WriteLine("Kui palju on ((3 + 8) / (4 - 2) * 4) = ?");


            double calculation1 = 3 + 8 / (4 - 2) * 4;
            float calculation2 = 3 + 8 / 4 - 2 * 4;
            double calculation3 = (3 + 8) / (4 - 2) * 4;
            double calculation4 = ((3 + 8) / (4 - 2) * 4);

            // inimese loogika järgi oleks vastus 4,
            //kuid arvutii arvutab teist moodi
            Console.WriteLine("3 + 8 / (4 - 2) * 4 = VASTUS = " + calculation1);
            Console.WriteLine("3 + 8 / 4 - 2 * 4 = VASTUS = " + calculation2);
            Console.WriteLine("(3 + 8) / (4 - 2) * 4 = VASTUS = " + calculation3);
            Console.WriteLine("((3 + 8) / (4 - 2) * 4) = VASTUS = " + calculation4);
        }
    }
}

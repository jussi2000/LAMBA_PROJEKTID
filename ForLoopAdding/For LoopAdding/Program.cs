namespace For_LoopAdding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Täisarvude kokku liitmine kuni kümneni!");
            Console.WriteLine("_______________________________________");
            Console.WriteLine("\n\n");

            int j, sum = 0;

            for (int i = 0; i <= 10; i++)
            {
                sum += i;
                Console.WriteLine("Summa on: " + sum);
            }
        }
    }
}

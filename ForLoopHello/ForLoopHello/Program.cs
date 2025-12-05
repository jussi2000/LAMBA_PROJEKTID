namespace ForLoopHello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //teha konsoolirakendus, kus kasutatud for loopi
            //kolm korda näidatakse Tere tulemast
            int loop = 3;

            for (int i = 0; i < loop; i++)
            {
                Console.WriteLine("Tere tulemast");
            }
        }
    }
}

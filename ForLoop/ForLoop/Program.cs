namespace ForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For Loop");

            int loop = 10;

            //int i muutuja määratlemine ja selle väärtus on 0
            //i < loop igakord võrdleb loop muutuja, et kas on suurem i-st
            //i++ Liidab iag kord ühe korra juurde e. sama hea, kui i + 1
            for (int i = 0; i < loop; i++)
            {
                Console.WriteLine("Loop " + i);
                Thread.Sleep(1000);
                Console.Beep();
            }
        }
    }
}

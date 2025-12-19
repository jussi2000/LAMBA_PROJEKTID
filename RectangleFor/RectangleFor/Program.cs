using System.Data;

namespace RectangleFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta ristküliku kshr küljr mõõdud");
            Console.WriteLine("Pikkus");
            double lenght = double.Parse(Console.ReadLine());
            

            Console.WriteLine("Laius");
            double Width = double.Parse(Console.ReadLine());

            for (int row = 1; row <= lenght; row++)
            {
                for (int column = 1; column <= Width; column++)
                {
                    string mark;
                    if (row == column || row + column <= +1)
                    {
                       mark = "*";
                    }
                    else
                    {
                       mark = "*";
                    }
                    Console.Write(mark);
                }
                Console.WriteLine();
            }
        }
    }
}

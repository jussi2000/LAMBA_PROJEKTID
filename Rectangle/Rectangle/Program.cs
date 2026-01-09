using System.Drawing;

namespace Rectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta ristküliku suurus");
            //teha ristkülik tärnidest
            //peab arvutama pindala ja ümbermõõdu
            Console.WriteLine("Sisesta pikkus");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Sisesta laius");
            int col = int.Parse(Console.ReadLine());

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            int area = row * col;
            int around = 2 * (row * col);
            Console.WriteLine("Pindala on " + area);
            Console.WriteLine("Ümbermõõt on " + around);
        }
    }
}
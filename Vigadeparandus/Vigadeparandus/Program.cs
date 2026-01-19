namespace VigadeParandus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("VigadeParandus");
            Console.WriteLine("\n");
            Console.WriteLine("Vali oma meetod:");
            Console.WriteLine("1. UpsideDownpyramid <<");
            Console.WriteLine("2. Rectangle <<");
            Console.WriteLine("3. Pyramid <<");
            Console.WriteLine("_________________");

            string input = Console.ReadLine();
            //Console.Clear(); = puhastab konsooli eelnevast tekstist
            Console.Clear();

            switch (input)
            {
                case "1":
                    //meetodi välja kutsumine
                    UpsideDownpyramid();
                    break;

                case "2":
                    
                    Rectangle();
                    break;

                case "3":
                    
                    Pyramid();
                    break;

                default:
                    Console.WriteLine("Sellist valikut ei ole");
                    break;

            }
        }

        static void UpsideDownpyramid()
        {
            Console.WriteLine("Sisesta kõrgus");
            int i, j, n;
            n = Convert.ToInt32(Console.ReadLine());

            for (i = n - 0; i >= 1; i--)
            {
                for (j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");

            } 
        }
        static void Rectangle()
        {
            Console.WriteLine("Sisesta pikkus");
            int row = int.Parse(Console.ReadLine());

            Console.WriteLine("Sisesta laius");
            int width = int.Parse(Console.ReadLine());

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine("");
            }
            int area = row * width;
            int around = 2 * (row + width);

            Console.WriteLine("Pindala on " + area);
            Console.WriteLine("Ümbermõõt on " + around);
        }
        static void Pyramid()
        {
            Console.WriteLine("");
            Console.WriteLine("Sisesta püramiidi kõrgus: ");

            int i, j, n;
            n= int.Parse(Console.ReadLine());

            for(i = 1; i <= n; i++)
            {
                for (j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
    }
}


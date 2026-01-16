namespace HindelineToo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Teha switchiga kome meetodi kutsumist.
            //Esimene meetod küsib kasutajalt tagurpidi püramiidi kõrgust ja teeb selle.
            //Teine meetod teeb ristküliku. lisaks sellele peab arvutama pindala ja ümbermõõdu.
            //kolmas meetod teeb ruutvõrrandi valemiga: D=b2(Ruudus)-4ac.
            //Kasutaja peab saama sisestadamuutujaid a, b ja c.

            Console.WriteLine(">> Vali enda meetodi, kui sisestad numbri <<");
            Console.WriteLine("_____________________________________________");
            Console.WriteLine("1) Tagurpidi püramiid(arvutab kõrguse)");
            Console.WriteLine("2) Ristkülik(Arvutab pindala ja ümbermõõtu)");
            Console.WriteLine("3) Ruutvõrrand");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                TagurpidiPüramiid();
            }
            else if (choice == "2")
            {
                Ristkülik();
            }
            else if (choice == "3")
            {
                Ruutvõrrand();
            }
            else
            {
                Console.WriteLine("ERROR. sisesta number 1-3");
            }
            static void TagurpidiPüramiid()
            {
                Console.WriteLine("Loome Tärnidest tagurpidi püramiidi \n");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Sisesta kõrgus: ");

                int i, j, n;
                n = Convert.ToInt32(Console.ReadLine());

                for (i = n - 0; i >= 0; i--)
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

            static void Ristkülik()
            {
                Console.WriteLine("Sisesta ristküliku suurused");
                int size = int.Parse(Console.ReadLine());
                int size2 = int.Parse(Console.ReadLine());

                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size2; j++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                }
                //\n jätab ühe rea vahele
                Console.WriteLine("\n\n");
                //kui suurus on siestatud, siis kuvab meile ka ümbermõõdu ja pindala
                int area = size * size;
                int around = 4 * size2;
                Console.WriteLine("Pindala on " + area);
                Console.WriteLine("Ümbermõõt on " + around);
            }

            static void Ruutvõrrand()
            {
                //kolmas meetod teeb ruutvõrrandi valemiga: D=b2(Ruudus)-4ac.
                //Kasutaja peab saama sisestadamuutujaid a, b ja c.
                //kasutaja peab saama sisestada neid väärtuseid
                Console.WriteLine("Arvutamine Valemiga(D=b2(Ruudus)-4ac)");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("Sisesta a väärtus");
                double a = double.Parse(Console.ReadLine());

                Console.WriteLine("Sisesta b väärtus");
                double b = double.Parse(Console.ReadLine());

                Console.WriteLine("Sisesta c väärtus");
                double c = double.Parse(Console.ReadLine());

                double D = (b * b) - (4 * a * c);

                Console.WriteLine($"x1 = {(-b + Math.Sqrt(D)) / (2 * a)}, X2 = {(-b + Math.Sqrt(D)) / (2 * a)} ");
            }
        }
    }
}

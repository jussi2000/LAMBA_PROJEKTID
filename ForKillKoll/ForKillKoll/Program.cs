namespace ForKillKoll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Eelnevaid teadmisi kasutades kirjuta programm, mis väljastaks:
            //kill - koll
            //kill - koll
            //killadi - koll
            //kill - koll
            //kill - koll
            //killadi - koll
            //kill - koll
            //kill - koll
            //killadi - koll
            //kill - koll

            Console.WriteLine("Sisesta korduste arv");
            int arv = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < arv; i++)
            {

                //nüüd siia lisada kaks loopi
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("Kill-Koll");
                }
                for (int j = 0; j < 1; j++)
                {
                    Console.WriteLine("Killadi-Koll");
                }
                {
                    Console.WriteLine("Kill-Koll");
                }
            }
        }
    }
}

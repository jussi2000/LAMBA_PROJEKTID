namespace Digital_clock
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Digital Clock";
            Console.CursorVisible = false;

            //while (true)
            //{
            //    Console.Clear();
            //    Console.WriteLine("Digital Clock\n");
            //    Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
            //    Thread.Sleep(1000);
            //}

              //tsükkel
           // while (true)
           // {
           //    //tühjendab konsooliakna
           //    Console.Clear();
           //    //string time - Mis algab numbriga ning sellel
           //    //on vähemalt 4.tähemärgi pikkune
           //    //muutuja, millel on arvutiaeg
           //    string time = DateTime.Now.ToString("HH:mm:ss");
           //
           //    //ekraani laius
           //     //int - täisarv
           //     int x = (Console.WindowWidth - time.Length) / 2;
           //     //ekraani pikkus
           //     int y = Console.WindowHeight / 2;
           //
           //     //kella numbrite näitamise koht
           //     Console.SetCursorPosition(x, y);
           //     //näitab aega läbi muutuja time
           //     Console.Write(time);
           //     //ootab ühe sekundi
           //     Thread.Sleep(1000);
           // }

            //for loopiga teha digitaalne kell
                for ( ; ; ) 
            {
                Console.Clear();
                Console.WriteLine("Digital Clock\n");
                Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
                Thread.Sleep(1000);
            
            }
        }
    }
}

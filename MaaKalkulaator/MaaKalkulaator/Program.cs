namespace MaaKalkulaator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Arvutada välja Maa ümbermõõt ja mitu münti
            //Mahub järjestikku ümber Maa
            //Arvutades tohib kasutada ainult mündi diameetrit ja maa raadiust

            //Mündi diameeter: 25.75 mm
            //Maa raadius: 6 371 km

            double CoinDiameter = 25.75; //mm
            double earthradius = 637100000;
            double aroundEarth = 2 * Math.PI * earthradius;

            Console.WriteLine(aroundEarth);
            double howManyCoins = aroundEarth / CoinDiameter;

            Console.WriteLine("kahe eurosid läheb ümber maa {0:0}", howManyCoins);
        }
    }
}

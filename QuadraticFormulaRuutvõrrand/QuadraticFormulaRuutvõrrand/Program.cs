namespace QuadraticFormulaRuutvõrrand
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ruutvõrrand!");

            //ax2 + bx + c

            //sisesta a,b ja c väärtus
            //kasutaja peab saama sisestada neid väärtuseid

            // ÕPETAJAGA:

            Console.WriteLine("Sisesta a väärtus");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Sisesta b väärtus");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Sisesta c väärtus");
            double c = double.Parse(Console.ReadLine());

            double d = b * b - 4 * a * c;

            Console.WriteLine($"x1 = {(-b + Math.Sqrt(d)) / (2 * a)}, X2 = {(-b + Math.Sqrt(d)) / (2 * a)} ");

            // INTERNETIST:

        //    double[] ABC = getABC();
        //    double[] answerArray = QuadFormula(ABC);

        //    Console.WriteLine("Positive answer: {0:0.000} \n Negative answer: {1:0.000}", answerArray[0], answerArray[1]);

        //}
        //public static double[] QuadFormula(double[] abc)
        //{
        //    NotFiniteNumberException e = new NotFiniteNumberException();

        //    try
        //    {
        //        double a = abc[0];
        //        double b = abc[1];
        //        double c = abc[2];
        //        double discriminant = ((b * b) - (4 * a * c));
        //        if (discriminant < 0.00)
        //        {
        //            throw e;
        //        }

        //        discriminant = (Math.Sqrt(discriminant));
        //        Console.WriteLine("discriminant: {0}", discriminant);
        //        double posAnswer = ((-b + discriminant) / (2 * a));
        //        double negAnswer = ((-b - discriminant) / (2 * a));

        //        double[] xArray = { posAnswer, negAnswer };
        //        return xArray;

        //    }
        //    catch (NotFiniteNumberException)
        //    {
        //        Console.WriteLine("Both answers will be imaginary numbers");
        //        double[] xArray = { Math.Sqrt(-1), Math.Sqrt(-1) };
        //        return xArray;
        //    }

        //}

        //public static double[] getABC()
        //{


        //    Console.Write("a=");
        //    string sA = Console.ReadLine();
        //    Console.Write("b=");
        //    string sB = Console.ReadLine();
        //    Console.Write("c=");
        //    string sC = Console.ReadLine();

        //    int intA = Int32.Parse(sA);
        //    int intB = Int32.Parse(sB);
        //    int intC = Int32.Parse(sC);
        //    double[] ABC = { intA, intB, intC };

        //    return ABC;
        }
    }
}

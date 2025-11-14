namespace SwitchCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta esimene number");

            //loeme kasutaja sisendit ja teisendame selle float tüübiks
            float number = float.Parse(Console.ReadLine());

            //konsool kirjutab kasutajale, et vali tehe: +, -, *, /
            Console.WriteLine("Vali tehe:+, -, *, /");
            string operation = Console.ReadLine();
            //konsool kirjutab, et sisesta teine number ja teisenda selle float tüübiks
            Console.WriteLine("Sisesta teine number");
            float secondNumber = float.Parse(Console.ReadLine());

            //teeme switchi lausega tehte valiku
            switch(operation)
            {
                case "+":
                    Console.WriteLine(number + secondNumber);
                    break;

                case "-":
                    Console.WriteLine(number - secondNumber);
                    break;
                
                case "*":
                    Console.WriteLine(number * secondNumber);
                    break;

                case "/":
                    Console.WriteLine(number / secondNumber);
                    break;

                default:
                    Console.WriteLine("ERROR");
                    break;

            }
        }
    }
}

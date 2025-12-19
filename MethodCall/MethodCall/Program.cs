namespace MethodCall
{
    internal class Program
    {
        //Kutsuda meetod välja
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            SayHello();
            SayGoodbye();
        }
        static void SayHello()
        {
            Console.WriteLine("Hello");
        }
        static void SayGoodbye()
        {
            Console.WriteLine("Goodbye");

        }
    }
}

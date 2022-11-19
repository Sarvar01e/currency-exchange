namespace currency_exchange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сurrency exchanger\n USD to BYN course is 2.39");
            Console.WriteLine("Enter your value");
            string str;

            str = Console.ReadLine();

            double a = Convert.ToDouble(str);

            double exchange = a * 2.39;

            Console.WriteLine("Your money in BYN \t" + exchange);


        }
    }
}
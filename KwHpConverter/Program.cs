using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {

            double result = 0;

            Console.WriteLine("Please, enter value: ");
            double value = double.Parse(Console.ReadLine());

            Console.WriteLine("Convert to (enter kw or hp):");
            string convertTo = Console.ReadLine();

            if (convertTo == "kw")
            {
                result = KwToHp(value);
            }
            else
            {
                result = HpToKw(value);
            }

            Console.WriteLine(result);

        }

        private static double KwToHp(double kw)
        {
            return kw / 0.745699872;
        }

        private static double HpToKw(double hp)
        {
            return hp * 0.745699872;
        }

    }

}
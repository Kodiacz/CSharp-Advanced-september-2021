using System;

namespace Exercise_5_DateModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();

            int days = DateModifier.GetDateDifferenceInDays(firstDate, secondDate);
            Console.WriteLine(days);
        }
    }
}

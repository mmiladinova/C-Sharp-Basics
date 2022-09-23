using System;

namespace lab._03.DepositCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double amountDeposited = double.Parse(Console.ReadLine());
            int depositTerm = int.Parse(Console.ReadLine());
            double annualInterstRate = double.Parse(Console.ReadLine());

            //сума = депозирана сума + срок на депозита *((депозирана сума* годишен лихвен процент ) / 12)
            double summa = amountDeposited + depositTerm * ((amountDeposited * (annualInterstRate/100)) / 12);
            Console.WriteLine(summa);
        }
    }
}
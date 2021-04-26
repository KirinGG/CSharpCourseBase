using System;

namespace BankDeposit
{
    class BankDeposit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер вклада:");
            double bankDeposit = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите срок(в месяцах) вклада:");
            int bankDepositTerm = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите процентную ставку вклада:");
            double annualInterestRate = Convert.ToDouble(Console.ReadLine());

            double monthlyInterestRate = CalculateMonthlyInterestRate(annualInterestRate);
            double calculatedBankDeposit = bankDeposit;

            for (int i = 1; i <= bankDepositTerm; i++)
            {
                calculatedBankDeposit += calculatedBankDeposit * monthlyInterestRate;
            }

            double profit = calculatedBankDeposit - bankDeposit;
            Console.WriteLine("Сумма банковского вклада - {0:f2}, прибыль - {1:f2}", calculatedBankDeposit, profit);
        }

        public static double CalculateMonthlyInterestRate(double annualInterestRate)
        {
            const int monthsCount = 12;
            const int hundred = 100;
            
            return annualInterestRate / (hundred * monthsCount);
        }
    }
}

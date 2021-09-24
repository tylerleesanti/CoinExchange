using System;

namespace Coin_Exchange
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your amount:");
            //decimal moneyInput = Convert.ToDecimal(Console.ReadLine()) * 100;
            decimal moneyInput = decimal.Parse(Console.ReadLine())* 100;
            int numOfQuarters, numOfDimes, numOfNickels, numOfPennies;

            // Find Number of Quarters
            numOfQuarters = (int)(moneyInput / 25);
            // Remove all Quarters from total
            moneyInput -= (numOfQuarters * 25);
            // Find Number of Dimes
            numOfDimes = ((int)moneyInput / 10);
            // Remove all Dimes from total
            moneyInput -= (numOfDimes * 10);
            // Find Number of Nickels
            numOfNickels = (int)moneyInput / 5;
            // Remove all Nickels from total
            moneyInput -= numOfNickels * 5;
            // Remainder goes into pennies
            numOfPennies = (int)moneyInput;

            Console.WriteLine("{0} quarters, {1} dimes, {2} nickles, {3} pennies", numOfQuarters, numOfDimes, numOfNickels, numOfPennies);

        }
    }
}

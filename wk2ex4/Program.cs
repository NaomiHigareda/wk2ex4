using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace wk2ex4
{
    internal class Program
    {
        private static object balance;

        private static void Main(string[] args)
        {
            decimal depositAmount = 0;
            //main deposit amount
            Main(args, depositAmount, balance);
        }

        static void Main(string[] args, decimal depositAmount, object balance)
        {
            //display the menu options
            Console.WriteLine("ATM Menu:");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Exit");

            //prompt user to select an option
            Console.WriteLine("Please select an option (1-4):");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    //check balance
                    Console.WriteLine($"Your current balance is {balance:C}");
                    break;
                case 2:
                    //deposit
                    Console.WriteLine("Enter the amount to withdraw");
                    decimal amountToDeposit = decimal.Parse(Console.ReadLine());
                    balance += amountToDeposit;
                    Console.WriteLine($"You have successfully depoisted {amountToDeposit:C}. Your new balance is: {balance:C}");
                    break;
                 case 3:
                    //withdraw
                    Console.WriteLine("Enter the amount to withdraw");
                    decimal withdrawAmount = decimal.Parse(Console.ReadLine());
                    if (withdrawAmount = balance)
                    {
                        balance = withdrawAmount;
                        Console.WriteLine($"You have successfully withdrawn {withdrawAmount:C}. Your new balance is: {balance:C}");
                    }
                    else
                    {
                        Console.WriteLine("Insufficient balance for this withdrawl.");
                    }
                    break;
                case 4:
                    //Exit
                    Console.WriteLine("Thank you for using the ATM. Goodbye!");
                    return;
                default:
                    //option invalid
                    Console.WriteLine("Invalid option. Please try again");
                    break;
            }



            }
    }
}

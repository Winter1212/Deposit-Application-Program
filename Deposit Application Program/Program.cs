using System;
using System.Diagnostics;
using System.Dynamic;

namespace DepositApplicationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposit = 0;
            double totalMoney = 0;
            double interest = 0;
            double monthlyInterest = 0;
            int currencyChoice = 0;
            int monthChoice = 0;
            double interestInriel = 0;
            double interestIndollar = 0;
            String ch = "";
            
            Again:
            Console.WriteLine("========================================");
            Console.WriteLine("Deposit Application System");
            Console.Write("Please Enter the amount of deposit:");
            deposit = Convert.ToDouble(Console.ReadLine());
           
            Console.WriteLine("Currency: ");
            Console.WriteLine("1. Riel");
            Console.WriteLine("2. Dollar");
            Console.Write("Please Enter your transaction");
            currencyChoice = Convert.ToInt32(Console.ReadLine());
            while (currencyChoice != 1 && currencyChoice != 2) 
                
            {
                Console.WriteLine("Enter the option of 1 or 2");
                currencyChoice = Convert.ToInt32(Console.ReadLine());
            }
          
            
            Console.WriteLine("1. 1 month");
            Console.WriteLine("2. 2 months");
            Console.WriteLine("3. 3 months");
            Console.WriteLine("4. 4 months");
            Console.WriteLine("5. 5 months");
            Console.Write("Plese Enter your transaction");
            monthChoice = Convert.ToInt32(Console.ReadLine());
            while (monthChoice !=1 && monthChoice !=2 && monthChoice !=3 && monthChoice != 4 && monthChoice != 5 )
            {
                Console.WriteLine("Please Enter the valid option");
                monthChoice = Convert.ToInt32(Console.ReadLine());
            }

            switch(monthChoice)
            {
                case 1:
                    interestInriel = (3.5/100) / 12;
                    interestIndollar = (3 / 100) / 12;
                    break;
                case 2:
                    interestInriel = (4 / 100) / 6;
                    interestIndollar = (3.5 / 100) / 6;
                    break;
                case 3:
                    interestInriel = (4.5 / 100) / 4;
                    interestIndollar = (4 / 100) / 4;
                    break;
                case 4:
                    interestInriel = (6.75/100)/2;
                    interestIndollar = (5.5/100) / 2;
                    break;
                case 5:
                    interestInriel = 8.5 / 100;
                    interestIndollar = 8 / 100;
                    break;
                default:
                    break;



            }

            if (currencyChoice == 1)
            {
                interest = (deposit * interestInriel) - ((deposit * interestInriel) * 0.06);

            }
            else if (currencyChoice == 2)
            {
                interest = (deposit * interestIndollar) - ((deposit * interestIndollar) * 0.06);

            }
            totalMoney = interest + deposit;
            monthlyInterest = interest / 12;


            Console.WriteLine("=======================================================");
            Console.WriteLine("\tTotal Money:" + interest.ToString("#,###.00R"));
            Console.WriteLine("\tTotal Money:" + totalMoney.ToString("#,###.00R"));
            Console.WriteLine("\tTotal Money:" + monthlyInterest.ToString("#,###.00R"));
            Console.WriteLine("Would you like to you the application again (Y/N)");
            ch = Console.ReadLine();
            ch = ch.ToUpper();
            if(ch == "Y")
            {
                goto Again;
            } else if (ch == "N")
            {
                Console.WriteLine("Exit the program");
            }
            else {
                Console.WriteLine("Exit the program");
            }







            Console.ReadKey();


        }
    }
}
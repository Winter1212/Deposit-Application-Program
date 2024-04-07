

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Deposit_Application_Program
{
    internal class DepositFunction
    {


        public double interest(double deposit, int monthChoice, int currencyChoice)
        {
            double result = 0, interestInriel= 0 , interestIndollar = 0 ;
            switch (monthChoice)
            {
                case 1:
                    interestInriel = (3.5 / 100) / 12;
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
                    interestInriel = (6.75 / 100) / 2;
                    interestIndollar = (5.5 / 100) / 2;
                    break;
                case 5:
                    interestInriel = 8.5 / 100;
                    interestIndollar = 8 / 100;
                    break;
                default:
                    break;



            };
            if (currencyChoice == 1)
            {
                result = (deposit * interestInriel) - ((deposit * interestInriel) * 0.06);

            }
            else if (currencyChoice == 2)
            {
                result = (deposit * interestIndollar) - ((deposit * interestIndollar) * 0.06);

            }
            
            return result;

        }

        public double totalMoney(double deposit, double interest)
        {
            return deposit + interest;
        }

        public double monthlyIntereset(double interest, int duration)
        {
            if (duration == 4)
            {
                duration = 6;
            }
            else if (duration == 5)
            {
                duration = 12;
            }
            return interest / duration;
        }
    }
}




























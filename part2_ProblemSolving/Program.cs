using System.Diagnostics.Metrics;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Schema;

namespace part2_ProblemSolving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int noOfHours = 0;
            double priceAccumulated = 0;

            //loop
            for (int i = 0;noOfHours!=-999; i++)
            {
                //get input from user
                Console.WriteLine($"\n{ "Enter number of hours(-999 to quit): "}");
                noOfHours= int.Parse(Console.ReadLine());

                //call CalculateCharge method to display the price.
                double price = CalculateCharge(noOfHours);
                priceAccumulated = price + priceAccumulated;
                Console.WriteLine($"{"Customer Charge : "+ (price),-20}{"Total Receipt: "+(priceAccumulated),60}");
            }

        }
        /*static private double CalculateCharge(double noOfHours)
        {
         // use the switch statement instead.   
            double MinFee = 2;//minimum fee for 3 hours
            double minFee_Hours = 3;
            double ratePerHour = 0.5;
            double hourlyFee_Calc = noOfHours* ratePerHour;
            double maxFee = 10;
            double total = 0;

            // decision to calculate the cost of usage.
            while(noOfHours > 0)
            {
                total = MinFee;

                if(noOfHours>minFee_Hours)
                {
                    total = total + hourlyFee_Calc;
                }
                if (total>=maxFee) 
                {
                    total = maxFee;
                }
                
            }
            return total;
            
        }*/
        static double CalculateCharge(int noOfHours)
        {

            string errorMessage = "invalid number of hours entered";

            if (noOfHours<= 0)
            {
                Console.WriteLine("invalid number of hours entered");
                return 0 ;
            }

            //switch statement
            switch (noOfHours)
            {
                case 1:
                case 2:
                case 3:
                    return 2;
                case 4:
                    return 2.5;
                case 5:
                    return 3;
                case 6:
                    return 3.5;
                case 7:
                    return 4;
                case 8:
                    return 4.5;
                case 9:
                    return 5;
                case 10:
                    return 6.5;
                case 11:
                    return 7;
                case 12:
                    return 7.5;
                case 13:
                    return 8;
                case 14:
                    return 8.5;
                case 15:
                    return 9;
                case 16:
                    return 9.5;
                default:
                    return 10;
                
            }
        }
    }

}
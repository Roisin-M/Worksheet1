namespace Q2
    /* 
Question 2

a)	Write a method, CountOddNumbers, which reads in 5 integer values from the console,
    and returns the number of them which are odd. 

b)	Write a method, AverageMinMax, to read in 5 integer values from the console and output
    their average, the smallest number entered and the largest number entered to the console.
    */
    
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"\nNumber of odd numbers is {(CountOddNumbers())}");
            AverageMinMax();
        }
        //Part A
        static int CountOddNumbers()
        {
            int[] numberinput = new int[5];
            int countOfOdds = 0;
            Console.WriteLine($"{"Calculate number of odd numbers from what you enter",-40}\r\n");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"{"enter value "+(i+1)+" : ",-40}");
                numberinput[i] = int.Parse(Console.ReadLine());
                if (numberinput[i] % 2 != 0)
                {
                    countOfOdds++;
                }
            }
            return countOfOdds;
        }
        // part b
        static void AverageMinMax()
        {
            int[] numberInput = new int[5];
            int lowest, highest;
            double average;

            Console.WriteLine($"\n{"Average, lowest number, highest number calculator",-40}");
            Console.WriteLine($"{"----------------------------------------------------------",-40}");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"{"enter number "+(i+1)+": ",-40}");
                numberInput[i] = int.Parse(Console.ReadLine());
            }
            // a method to calculate the highest value
            static int GetHighest(int[] numberInput)
            {
                int highest = numberInput.Max();
                return highest;
            }
            //a method to calculate the average of all votes cast
            static double GetAverage(int[] numberInput)
            {
                double average = numberInput.Average();
                return average;
            }
            //a method to calculate the lowest value
            static int GetLowest(int[] numberInput)
            {
                int lowest = numberInput.Min();
                return lowest;
            }
            // call methods into averagemin max mathod
            average = GetAverage(numberInput);
            highest = GetHighest(numberInput);
            lowest = GetLowest(numberInput);

            // display the results
            Console.WriteLine($"\n{"Here are the results from the what you have entered",-40}");
            Console.WriteLine($"{"----------------------------------------------------------",-40}");
            Console.WriteLine($"\n{"The average : "+(average),-40}");
            Console.WriteLine($"{"The highest value : " + (highest),-40}");
            Console.WriteLine($"{"The lowest value : " + (lowest),-40}");
        }

    }
}
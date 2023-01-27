namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine($"Number of odd numbers is {(CountOddNumbers())}");
            
        }
        //Part A
        static int CountOddNumbers()
        {
            int[] numberinput = new int[5];
            int countOfOdds = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("enter a number value: ");
                numberinput[i] = int.Parse(Console.ReadLine());
                if (numberinput[i] % 2 != 0)
                {
                    countOfOdds++;
                }
            }
            return countOfOdds;
        }
        // part b
        static double AverageMinmax()
        {
            int[] numberInput = new int[5];
            int lowest, highest;
            double average;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("enter a number value: ");
                numberInput[i] = int.Parse(Console.ReadLine());
            }
            return average = GetAverage(numberInput);
            return highest = HighestVotes(numberInput);
            return lowest = LowestVotes(numberInput);

            static int HighestVotes(int[] numberInput)
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
            static int LowestVotes(int[] numberInput)
            {
                int lowest = numberInput.Min();
                return lowest;
            }
        }

    }
}
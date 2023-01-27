namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"Number of odd numbers is {(CountOddNumbers())}");
            
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

    }
}
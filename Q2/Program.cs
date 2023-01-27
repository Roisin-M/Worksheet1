namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"Number of odd numbers is {(CountOddNumbers())}");
            
        }
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

            /*for (int i = 0; i < numberOdd.Length; i++)
            {
                Console.WriteLine($"{(numberOdd[i]),-30}");
            }
            */
            /*int i = 0;
            int[]oddNumber=new int[5];
            do
            {
                Console.Write("enter a number value: ");
                numberinput[i] = int.Parse(Console.ReadLine());
                i++;
                if (i % 2 != 0)
                {
                    numberinput[i]=oddNumber[i];
                }
            }
            while(i < numberinput.Length);*/
            /*for (int c = 0; c < oddNumber.Length; i++)
            {
                Console.WriteLine($"{(oddNumber[c]),-30}");
            }*/
        
    }
}
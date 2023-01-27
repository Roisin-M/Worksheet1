namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CountOddNumbers();
            
        }
        static void CountOddNumbers()
        {
            int[] numberinput = new int[5];

            for (int i = 0; i < numberinput.Length; i++)
            {
                Console.Write("enter a number value: ");
                numberinput[i] = int.Parse(Console.ReadLine());
                if(i%2 !=0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
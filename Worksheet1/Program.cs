namespace Worksheet1
{
    internal class Program

    { 
        // declare array to store all integers between 40 and 60
        static int[] integers = { 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 52, 52, 53, 54, 55, 56, 57, 58, 59 };
        static void Main(string[] args)
        {
            PrintIntegersWhile();
        }
        // method for a for loop
        static private void PrintIntegersFor()
        { 
            
            for(int i=0; i< integers.Length; i++)
            {
                Console.WriteLine(integers[i]); 
            }
        }
        // method for a while loop
        static private void PrintIntegersWhile()
        {
            
            int i = 0;
            while(i<integers.Length)
            {
                Console.WriteLine(integers[i]);
                i++;
            }
        }
        // method for a do while loop
        static private void PrintIntegersDo()
        {

        }
    }
}
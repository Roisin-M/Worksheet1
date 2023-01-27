namespace q1
{
            namespace Worksheet1
    {
        internal class Program

        {
            // declare array to store all integers between 40 and 60
            static int[] integers = { 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 52, 52, 53, 54, 55, 56, 57, 58, 59 };
            static int number1 = 40;
            static int number2 = 60;
            static int number3 = 59;
            static int excludenumber1 = 46;
            static int excludenumber2 = 48;

            static void Main(string[] args)
            {
                PrintExcludingFor();
                PrintIntegersWhile();
                PrintIntegersDo();
                PrintExcludingFor();
                PrintDescendingOrder();
            }
            // method for a for loop A
            static private void PrintIntegeresFor()
            {

                for (int i = 0; i < integers.Length; i++)
                {
                    Console.WriteLine(integers[i]);
                }
            }
            // method for a while loop B
            static private void PrintIntegersWhile()
            {

                int i = 0;
                while (i < integers.Length)
                {
                    Console.WriteLine(integers[i]);
                    i++;
                }
            }
            // method for a do while loop C
            static private void PrintIntegersDo()
            {
                int i = 0;
                do
                {
                    Console.WriteLine(integers[i]);
                    i++;
                }
                while (i < integers.Length);

            }
            // method for a for loop excluding 46 and 48 D
            static private void PrintExcludingFor()
            {

                for (int i = number1; i < number2; i++)
                {
                    if (i != excludenumber1 && i != excludenumber2)
                    {
                        Console.WriteLine(i);
                    }
                }

            }
            //method for a for loop that prints in descending order E
            static private void PrintDescendingOrder()
            {
                for (int i = number3; i > number1; i--)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
    

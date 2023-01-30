namespace q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintTriangleGeneralCharacter();
        }
        //A method to print one "#" at a time (a)
        static private void PrintTriangle()
        {
            /*string symbol = "#";
            string symbol2 = "#";
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(symbol);
                symbol = symbol + symbol2;
            }
            */
            for(int i = 0; i <= 5; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("# ");
                }
                Console.WriteLine();
            }
        }
        // write a method to print the same pattern as "PrintTriangle()" but upside down(b)
        static private void PrintTriangleUpsideDown()
        {
            for ( int i = 0; i<5; i++)
            {
                // +++++++++++++look back over++++++++++++++
                for ( int j = 0; j<(5-i); j++)
                {   
                    Console.Write("# ");
                }
                Console.WriteLine();
            }
            /* can do it this way either -> jacks way
             * string hashtag="#";
             * inti=5;
             * while(0<=i)
             * {
             * int counter=0;
             * while(counter<i)
             * {
             * Console.Write(hashtag);
             * counter++;
             * }
             * Console.Write($"\n");
             * i--
             * }
             * */

        }
        // write a method to print hashtag pattern an inputted number of times (c)
        static private void PrintTriangleGeneral()
        {
            Console.Write("Enter a number: ");
            int numberOfTimes=int.Parse(Console.ReadLine());

            for (int i = 0; i <= numberOfTimes; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("# ");
                }
                Console.WriteLine();
            }
        }
        /*(d) d)	Write another method PrintTriangleGeneralCharacter which takes an integer
         * and a character as parameters and prints the pattern with the number of rows of
         * the entered character which was input. If you call the method with the arguments,
         * 5, ‘#’ you should get the pattern from a) above.
         * */
        static private void PrintTriangleGeneralCharacter()
        {
            int integer;
            char character;

            // get inout from user to creat pattern
            Console.Write($"{"Enter the character you would like to print: "}",-40);
            character = char.Parse(Console.ReadLine());
            Console.Write($"{"Enter the number of times you would like the pattern to repeat: ",-40}");
            integer= int.Parse(Console.ReadLine());

            //loop
            for (int i = 0; i <= integer; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(character);
                }
                Console.WriteLine();
            }
        }
      

    }
}
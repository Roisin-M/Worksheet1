namespace q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintTriangle();
        }
        //A method to print one "#" at a time (a)
        static private void PrintTriangle()
        {
            string symbol = "#";
            string symbol2 = "#";
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(symbol);
                symbol = symbol + symbol2;
            }
        }

    }
}
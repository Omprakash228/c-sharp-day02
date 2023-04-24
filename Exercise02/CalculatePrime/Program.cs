using System.Globalization;

namespace CalculatePrime
{
    public class Program
    {
        static int[] FindPrimes(int start, int end)
        {
            int[] result = new int[end - start];
            int resultIndex = 0;
            int divisibleCount = 0;

            for (int i = start; i < end; i++)
            {
                for(int j = 1; j < end; j++)
                {
                    if(i%j == 0)
                    {
                        divisibleCount++;
                    }
                }
                if(divisibleCount == 2)
                {
                    result[resultIndex++] = i;
                }
                divisibleCount = 0;
            }

            return result;
        }

        static void Main(string[] args)
        {
            int s, e;
            Console.WriteLine("Enter a start value: ");
            s = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a end value: ");
            e = int.Parse(Console.ReadLine());

            int[] result = FindPrimes(s, e);

            for(int i = 0; i < result.Length && result[i] != 0; i++)
            {
                Console.Write("{0} ", result[i]);
            }
        }
    }
}
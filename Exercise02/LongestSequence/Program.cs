namespace LongestSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the array values(space separated): ");
            string[] tokens = (Console.ReadLine()).Split(' ');
            int[] numbers = Array.ConvertAll(tokens, int.Parse);

            int[] result = new int[0];
            int start = 0, end = 0;

            while (end < numbers.Length)
            {
                if (end < numbers.Length - 1 && numbers[end] == numbers[end + 1])
                {
                    end++;
                }
                else
                {
                    int len = end - start + 1;
                    if (len > result.Length)
                    {
                        result = new int[len];
                        Array.Fill(result, numbers[start]);
                    }
                    start = end = end + 1;
                }
            }

            for (int i = 0; i < result.Length; i++)
            {
                Console.Write("{0} ", result[i]);
            }
        }
    }
}
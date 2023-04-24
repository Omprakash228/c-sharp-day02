namespace RotationSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the array values(space separated): ");
            string[] tokens = (Console.ReadLine()).Split(' ');
            int[] numbers = Array.ConvertAll(tokens, int.Parse);

            Console.WriteLine("Enter the number of rotations");
            int k = int.Parse(Console.ReadLine());

            int[] result = new int[numbers.Length];

            for(int i = 1; i <= k; i++)
            {
                for(int j = 0; j < result.Length; j++)
                {
                    int newIndex = (j + i) % numbers.Length;
                    result[newIndex] += numbers[j];
                }
            }

            for(int i = 0; i < result.Length; i++)
            {
                Console.Write("{0} ", result[i]);
            }
        }
    }
}
namespace Exercise02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] arr2 = new int[arr1.Length];

            for(int i = 0; i < arr1.Length; i++)
            {
                arr2[i] = arr1[i];
            }

            Console.WriteLine("Original Array");
            for (int i = 0; i < arr1.Length;i++)
            {
                Console.Write("{0} ", arr1[i]);
            }

            Console.WriteLine("\nCopied Array");
            for(int i = 0; i < arr2.Length; i++)
            {
                Console.Write("{0} ", arr2[i]);
            }
        }
    }
}
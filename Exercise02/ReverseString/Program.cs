using System.Text;

namespace ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] chars = input.ToCharArray();

            for(int i = 0; i < chars.Length/2; i++)
            {
                char temp = chars[i];
                chars[i] = chars[chars.Length - i - 1];
                chars[chars.Length - i - 1] = temp;
            }

            string result = new string(chars);
            Console.WriteLine(result);


            for (int i = input.Length -1; i >= 0; i--)
            {
                Console.Write(input[i]);
            }
        }
    }
}
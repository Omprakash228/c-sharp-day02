namespace LoopList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            bool loop = true;

            while(loop)
            {
                Console.WriteLine("Items in the list: ");
                foreach(string listItem in list)
                {
                    Console.WriteLine(listItem);
                }
                Console.WriteLine("Enter command (+ item, - item, or -- to clear, q to exit)):");
                string input = Console.ReadLine();
                if (input == "--")
                {
                    list = new List<string>();
                } else if (input[0] == '-')
                {
                    string[] components = input.Split(" ");
                    List<string> newList = new List<string>(); 
                    foreach(string listItem in list)
                    {
                        if(listItem != components[1])
                            newList.Add(listItem);
                    }
                    list = newList;
                } else if (input[0] == '+')
                {
                    string[] components = input.Split(" ");
                    list.Add(components[1]);
                } else
                {
                    loop = false;
                }
            }
        }
    }
}
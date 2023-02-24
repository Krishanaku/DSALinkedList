using System.Collections;

namespace DataStructure
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to DSA LinkedList Problem Problem...");

            LinkedList linked = new LinkedList();
            linked.Append(56); // add a elemt at last postion Append is nothinf act as Add () method
            linked.Append(30);
            linked.Append(70);
            linked.Display();
        }
    }
}

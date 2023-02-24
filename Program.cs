using System.Collections;

namespace DataStructure
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to DSA LinkedList Problem Problem...");

            LinkedList linked = new LinkedList();
            linked.Add(56); // add a elemt at last postion Append is nothinf act as Add () method
            linked.Add(30);
            linked.Add(70);
            linked.Display();
            int a = linked.Search(30);
            linked.InsertAtParticularPosition(a + 1, 40);
            linked.Display();

            
            
            




        }
    }
}

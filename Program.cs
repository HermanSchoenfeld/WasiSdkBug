namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args) {
            Console.WriteLine("Before GC");
            GC.Collect();
            Console.WriteLine("After GC");
        }
    }
}

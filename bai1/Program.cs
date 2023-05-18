using System;
namespace bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime a = DateTime.Now;
            Console.WriteLine("time hien tai : "+ a.ToString("dd/MM/yyyy HH:mm:ss"));
            Console.ReadKey();
        }
    }
}
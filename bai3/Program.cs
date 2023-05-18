using System;
namespace bai3
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.Write("Your name : ");
            String name=Console.ReadLine();
            Console.WriteLine("HI !!" +name);
            Console.ReadKey();
        }
    }
}
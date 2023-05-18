using System;
namespace bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            float w; float h;
            Console.Write("height = ");
            w= float.Parse(Console.ReadLine());
            Console.Write("width = ");
            h = float.Parse(Console.ReadLine());
            float area =w*h;
            Console.WriteLine("area = " +area);
            Console.ReadKey();
        }
    }
}
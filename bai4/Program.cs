using System;
namespace bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap so tien ( 1 usd = 23000 vnd ) : ");
            const float rate = 23000;
            float usd = float.Parse(Console.ReadLine());
            Console.WriteLine("VND = "+rate*usd );
            Console.ReadKey();
        }
    }
}
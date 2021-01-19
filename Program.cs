using System;

namespace RefandOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 20;
            int rakam1;
            int rakam2;
            var result=ekle(ref sayi1,sayi2);
            var result2 = ekle1(out rakam1, 30);
            Console.WriteLine(result + "->>>ref örneği için");
            Console.WriteLine(result2+"->>>out örneği için");
        }
        static int ekle(ref int sayi1, int sayi2=30)
        {
            sayi1 = 100;
            var result = sayi1 + sayi2;
            return result;
        }
        static int ekle1(out int rakam1,int rakam2)
        {
            rakam1 = 30;
            return rakam1 + rakam2;
            
        }
    }
}
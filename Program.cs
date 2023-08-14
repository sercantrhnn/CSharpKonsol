using System;

namespace CSharpKonsol
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dizinin boyutunu giriniz: ");
            int diziboyut = int.Parse(Console.ReadLine());
            int[] dizi = new int[diziboyut];

            for (int i = 0; i < diziboyut; i++)
            {
                Console.Write("Dizinin {0} elemanını giriniz: ", i+1);
                dizi[i] = int.Parse(Console.ReadLine());
            }

           
            foreach (var item in dizi)
            {
                if (item % 2 == 0)
                {
                    Console.Write(item);
                }
            }
        }
    }
}

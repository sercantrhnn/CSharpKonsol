using System;

namespace CSharpKonsol
{
    class Program
    {
        static void Main(string[] args)
        {
            // Girilen dizide çift sayıları ekrana bastıran kod.
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

            //Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
            Console.Write("Lütfen ilk sayıyı giriniz:");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.Write("Lütfen ikinci sayıyı giriniz:");
            int sayi2 = int.Parse(Console.ReadLine());
            Console.Write("Lüfken {0} adet sayı giriniz: ",sayi1);
            int[] sayilar = new int[sayi1];

             for (int i = 0; i < sayi1; i++)
            {
                Console.Write("Dizinin {0} elemanını giriniz: ", i+1);
                sayilar[i] = int.Parse(Console.ReadLine());
            }

            foreach (var item in sayilar)
            {
                if (item == sayi2 || item % sayi2 == 0)
                {
                    Console.WriteLine(item);
                }
            }



        

        }
    }
}

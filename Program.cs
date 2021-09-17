using System;

namespace millipiyango
{   
    class Program
    {
        static void Main(string[] args)
        {
            int sayac = 0;
            Console.WriteLine("Milli Piyango Çekilişine Hoşgeldiniz."); 
            int[] girilen = new int[6];
            for (int i = 0; i < girilen.Length; i++)
            {
                Console.WriteLine("Lütfen {0} adet sayı giriniz. [0-99]", girilen.Length-i);
                girilen[i] = Convert.ToInt32(Console.ReadLine());
            }
            Random rastgele = new Random();
            int[] piyango = new int[6];
            for (int i = 0; i < piyango.Length; i++)
            {
                piyango[i] = rastgele.Next(0, 100);
                Console.WriteLine("Piyango çekiliyor.. {0}. sayi: {1}", i + 1, piyango[i]);
            }
            Console.WriteLine("Talihli sayilar belli oldu!");
            Console.WriteLine($"Kazanan numaralar : {piyango[0]} {piyango[1]} {piyango[2]} {piyango[3]} {piyango[4]} {piyango[5]}");
            int[] kazanannumaralar = new int[6];
            for (int i=0; i<piyango.Length; i++)
            {
                for (int j = 0;  j < piyango.Length;  j++)
                {
                    if (piyango[i] == girilen[j])
                    {
                    kazanannumaralar[sayac] = piyango[i];
                    sayac++;
                    }
                }
            }
            Console.Write("Senin Numaraların :");
            for (int i = 0; i < girilen.Length; i++)
            {
                Console.Write(girilen[i] + " ");
            }
            if (sayac == 0)
                Console.WriteLine("\nMaalesef çok bahtsızsın. Hiçbir sayı tutmadı :(");
            else if (sayac == 1)
                Console.WriteLine("\n1 sayı tutturdun o da {0} eh işte.", kazanannumaralar[0]);
            else if (sayac == 2)
                Console.WriteLine($"\nOha lan 2 sayı tuttu bak : {kazanannumaralar[0]} ve {kazanannumaralar[1]}");
            else if (sayac == 3)
                Console.WriteLine($"\nseni totocu 3 sayı tutturdun {kazanannumaralar[0]} {kazanannumaralar[1]} {kazanannumaralar[2]}");
            else if (sayac == 4)
                Console.WriteLine($"\n6da 4 baya iyi lan napıon sen alooo {kazanannumaralar[0]} {kazanannumaralar[1]} {kazanannumaralar[2]} {kazanannumaralar[3]}");
            else if (sayac == 5)
                Console.WriteLine($"\nAH ULAN! 1 tane kalmıştı. İyi para kaldırdın 5/6 :) {kazanannumaralar[0]} {kazanannumaralar[1]} {kazanannumaralar[2]} {kazanannumaralar[3]} {kazanannumaralar[4]}");
            else
                Console.WriteLine($"\nYOK ARTIK! Milyoner oldun lan 6/6 sen varya aşkta büyük kaybedecen he  {kazanannumaralar[0]} {kazanannumaralar[1]} {kazanannumaralar[2]} {kazanannumaralar[3]} {kazanannumaralar[4]} {kazanannumaralar[5]}");
            Console.ReadKey();
        }
    }
}

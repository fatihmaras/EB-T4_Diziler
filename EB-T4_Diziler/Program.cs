using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[4];
            sayilar[0] = 10;
            sayilar[1] = 20;
            sayilar[2] = 30;
            sayilar[3] = 40;

            for (int i = 0; i < sayilar.Length; i++)
            {

                Console.WriteLine(sayilar[i]);
            }

            Console.WriteLine("\n");

            string[] isimler = new string[5];

            string[] isimler1 = { "Fatih", "Ali", "Ayça", "Cansu", "Mehmet" };

            double[] ondaliklisayilar = { 1.44, 7.66, 8.34, 10.51 };

            char[] karakter = { 'N', 'S', 'T', 'F' };



            for (int c = 0; c < isimler1.Length; c++)
            {
                Console.WriteLine(isimler1[c]);

                for (int a = 0; a < ondaliklisayilar.Length; a++)
                {
                    Console.WriteLine(ondaliklisayilar[a]);

                    for (int b = 0; b < karakter.Length; b++)
                    {
                        Console.Write(karakter[b]);


                    }
                }

                Console.WriteLine("\n");

                int[] sayilar2 = new int[4];

                for (int i = 0; i < sayilar2.Length; i++)
                {
                    Console.Write("Sayilar2 dizisinin " + (i + 1) + ". değerini giriniz : ");
                    sayilar[i] = Convert.ToInt32(Console.ReadLine());

                }

                Console.WriteLine("\n");

                for (int i = 0; i < sayilar.Length; i++)
                {
                    Console.WriteLine(sayilar[i]);

                }
                Console.ReadLine();
            }

        }

    }
}
















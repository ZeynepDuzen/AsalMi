using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsalMi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //***sayinin asal olup olmadigini kontrol eden kod blogu***
            //Console.WriteLine(" 1 disinda pozitif sayi girin : ");
            //int sayi = Convert.ToInt16(Console.ReadLine());

            //string result = AsalMi(sayi);
            //Console.WriteLine("Girmis oldugunuz sayi : " + result);

            // *** for dongusundeki sayilarin asci tablosundaki karsiliklari
            //for (int i = 60; i <= 70; i++)
            //{
            //    Console.WriteLine((char)i);
            //}
            //for (char c = 'A'; c <= 'z'; c++)
            //{
            //    Console.WriteLine(c);
            //}
            //for (char c = 'A'; c <= 'z'; c++)
            //{
            //    if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z')) //harf disindaki karakterleri yazdirmamis oluruz
            //    {
            //        Console.WriteLine(c);
            //    }
            //}

            // *** for ile faktoriyel hesaplama ***
            Console.WriteLine("Faktoriyelinin hesaplanmasini istediginiz bir sayi giriniz : ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int carpim = 1;

            for (int i = 1; i <= sayi; i++)
            {
                carpim *= i;
            }
            Console.WriteLine(sayi + "sayisinin faktoriyeli : " + carpim);

            Console.Read();
        }
        static string AsalMi(int sayi)
        {
            bool asalMi = true; //flag

            for (int sayac = 2; sayac < sayi; sayac++)
            {
                if (sayi % sayac == 0)
                {
                    asalMi = false;
                    break;
                }
            }
            return asalMi ? "Asal sayi" : "Asal sayi degil";
        }







    }
}

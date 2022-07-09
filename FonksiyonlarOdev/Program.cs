using System;

namespace FonksiyonlarOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Birinci Sayıyı Giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci Sayıyı Giriniz:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            //static void için
            Topla(sayi, sayi2);
            carp(sayi, sayi2);
            bol(sayi, sayi2);
            cıkarma(sayi, sayi2);

            //static int için
            int toplam = artı(sayi, sayi2);
            Console.WriteLine("Toplamm: {0}", + toplam);
            int carpım = carpı(sayi, sayi2);
            Console.WriteLine("Carpımm: {0}", +carpım);
            int bolmee = bolme(sayi, sayi2);
            Console.WriteLine("Bölmee: {0}", +bolmee);
            int çıkarmaa = çıkarma(sayi, sayi2);
            Console.WriteLine("Çıkarmaa {0}", +çıkarmaa);

        }
        static void Topla(int a, int b)
        {
            Console.WriteLine("Toplam: {0}", a + b);
        }
        static void carp(int a, int b)
        {
            Console.WriteLine("Çarpım: {0}", a * b);
        }
        static void bol(int a, int b)
        {
            Console.WriteLine("Bölüm: {0}", a / b);
        }
        static void cıkarma(int a, int b)
        {
            Console.WriteLine("Çıkarma: {0}", a - b);
        }
        static int artı(int a, int b)
        {
            return a + b;
        }
        static int carpı(int a, int b)
        {
            return a * b;
        }
        static int bolme(int a, int b)
        {
            return a / b;
        }
        static int çıkarma(int a, int b)
        {
            return a - b;
        }

    }
}

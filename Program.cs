﻿namespace CalculatorApp_OYU
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hesap Makinesi");
            Console.Write("Birinci Sayıyı Giriniz: ");
            double firstNumber = double.Parse(Console.ReadLine());

            Console.Write("İkinci Sayıyı Giriniz: ");
            double secondNumber = double.Parse(Console.ReadLine());

            Console.Write("İşlem Türü Seçiniz: ");
            string operationType = Console.ReadLine().ToLower();
        }
    }
}
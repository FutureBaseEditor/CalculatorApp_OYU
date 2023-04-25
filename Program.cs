namespace CalculatorApp_OYU
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hesap Makinesi");
            Console.Write("Birinci Sayıyı Giriniz: ");
            double sayi1 = double.Parse(Console.ReadLine());

            Console.Write("İkinci Sayıyı Giriniz: ");
            double sayi2 = double.Parse(Console.ReadLine());

            Console.Write("İşlem türü seçiniz: ");
            string islem = Console.ReadLine();
        }
    }
}
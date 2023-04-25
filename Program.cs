namespace CalculatorApp_OYU
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hesap Makinesi");
            Console.Write("Birinci Sayıyı Giriniz: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("İkinci Sayıyı Giriniz: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.Write("İşlem türü seçiniz: ");
            string operation = Console.ReadLine().ToLower();
        }
    }
}
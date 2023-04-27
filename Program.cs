namespace CalculatorApp_OYU
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

            
            if (operationType == "+" || operationType == "topla" || operationType == "toplama")
                Console.WriteLine("{0} + {1} = {2}", firstNumber, secondNumber, (firstNumber + secondNumber));
            
            else if (operationType == "-" || operationType == "çıkar" || operationType == "çıkarma")
                Console.WriteLine("{0} - {1} = {2}", firstNumber, secondNumber, (firstNumber - secondNumber));

            else if (operationType == "*" || operationType == "çarp" || operationType == "çarpma")
                Console.WriteLine("{0} x {1} = {2}" , firstNumber, secondNumber, (firstNumber * secondNumber));

            else if (operationType == "/" || operationType == "böl" || operationType == "bölme")
                Console.WriteLine("{0} / {1} = {2}", firstNumber, secondNumber, (firstNumber / secondNumber));


        }
    }
}

namespace Gazi.KararYapilariAppSube2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Sayıyı giriniz:");
            double sayi1 = double.Parse(Console.ReadLine());
            Console.WriteLine("2.Sayıyı giriniz");
            double s2 = double.Parse(Console.ReadLine());
            Console.WriteLine("İşlem seçiniz:+,*,/,-");
            char islem = char.Parse(Console.ReadLine());
            string msg = "İşlemin sonucu:";
            if (islem == '+')
            {
                Console.WriteLine($"{msg}{sayi1 + s2}");
            }
            else if (islem == '-')
            {
                Console.WriteLine($"{msg}{sayi1 - s2}");
            }
            else if (islem == '*')
            {
                Console.WriteLine($"{msg}{sayi1 * s2}");
            }
            else if (islem == '/')
            {
                Console.WriteLine($"{msg}{sayi1 / s2}");
            }
            else
            {
                Console.WriteLine("Hatalı giriş yaptınız.");
            }
        }
    }
}


//Dil Seçiniz/Choose Language:TR
//1. sayıyı giriniz:10
//2. sayıyı giriniz:5
//İşlem seçiniz: +
//İşlemin sonucu: 15

//Dil Seçiniz/Choose Language:EN
//Enter first number:10
//Enter second number:5
//Choose Operation: +
//Result: 15
namespace Gazi.KararYapilariAppSube2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Select EN for English:");
            //string cevap = Console.ReadLine().ToUpper();

            //string msg1 = "1.sayıyı giriniz:", msg2 = "2.sayıyı giriniz:", msg3 = "İşlem seçiniz:", msg4 = "İşlemin sonucu:", msg5 = "Hatalı giriş yaptınız";

            //if (cevap == "EN")
            //{
            //    msg1 = "Enter first number:";
            //    msg2 = "Enter second number:";
            //    msg3 = "Select Operation:";
            //    msg4 = "Result:";
            //    msg5 = "Incorrect Operation Selected!";
            //}

            //Console.WriteLine(msg1);
            //double sayi1 = double.Parse(Console.ReadLine());
            //Console.WriteLine(msg2);
            //double s2 = double.Parse(Console.ReadLine());
            //Console.WriteLine(msg3);
            //char islem = char.Parse(Console.ReadLine());
            //if (islem == '+')
            //{
            //    Console.WriteLine($"{msg4}{sayi1 + s2}");
            //}
            //else if (islem == '-')
            //{
            //    Console.WriteLine($"{msg4}{sayi1 - s2}");
            //}
            //else if (islem == '*')
            //{
            //    Console.WriteLine($"{msg4}{sayi1 * s2}");
            //}
            //else if (islem == '/')
            //{
            //    Console.WriteLine($"{msg4}{sayi1 / s2}");
            //}
            //else
            //{
            //    Console.WriteLine(msg5);
            //}


            //try
            //{
            //    Console.WriteLine("Hava nasıl?");
            //    string durum = Console.ReadLine().ToLower();
            //    if (durum == "güzel")
            //    {
            //        Console.WriteLine("Kaç derece");
            //        sbyte derece = sbyte.Parse(Console.ReadLine());
            //        if (derece < 15)
            //        {
            //            Console.WriteLine("Hava soğuk evde otur");
            //        }
            //        else if (derece >= 15 && derece < 35)
            //        {
            //            Console.WriteLine("Hava güzel dışarı çıkabilirsin");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Hava çok sıcak evde oturmalısın");
            //        }
            //    }
            //    else if (durum == "kötü")
            //    {
            //        Console.WriteLine("Evde otur");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Hatalı giriş yaptınız!");
            //    }
            //}
            //catch (Exception)
            //{
            //    throw;
            //}
            //try
            //{
            //    Console.WriteLine("Bir sayı giriniz:");
            //    byte sayi = byte.Parse(Console.ReadLine());
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Sayı ile giriş yapınız.");
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("0-255 arası değer giriniz");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Bir hata oluştu!");
            //    Console.WriteLine($"Hata Detayları:\nTarih Saat:{DateTime.Now}\nHata Mesajı:{ex.Message}\nStack Trace:{ex.StackTrace}");
            //}


            Console.WriteLine("Bir sayı giriniz:");
            int sayi = int.Parse(Console.ReadLine());
            if (sayi == 1)
            {
                Console.WriteLine("Bir");
            }
            else if (sayi == 2)
            {
                Console.WriteLine("İki");
            }
            else if (sayi == 3)
            {
                Console.WriteLine("Üç");
            }
            else
            {
                Console.WriteLine("Yanlış giriş");
            }


            switch (sayi)
            {
                case 1:
                    Console.WriteLine("Bir");
                    break;
                case 2:
                    Console.WriteLine("İki");
                    break;
                case 3:
                    Console.WriteLine("Üç");
                    break;
                default:
                    Console.WriteLine("Hatalı Giriş!");
                    break;
            }


        }
    }
}
//Exception Handling

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
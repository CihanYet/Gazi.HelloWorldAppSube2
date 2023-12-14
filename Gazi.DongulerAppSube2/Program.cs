namespace Gazi.DongulerAppSube2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("İsminizi giriniz:");
            //string isim = Console.ReadLine();
            //Console.WriteLine("Kaç kere yazılsın?");
            //int tekrar = int.Parse(Console.ReadLine());

            //for (int i = 0; i < tekrar; i++)
            //{
            //    Console.WriteLine($"{i+1}.{isim}");
            //}

            //Console.WriteLine("Başlangıç değerini giriniz:");
            //int bas = int.Parse(Console.ReadLine());
            //Console.WriteLine("Bitiş değerini giriniz:");
            //int bit = int.Parse(Console.ReadLine());
            //Console.WriteLine("Tek/Çift?");
            //string cevap = Console.ReadLine().ToLower();


            ////bas:10 bit:5
            //if (bas > bit)
            //{
            //    int temp = bas;
            //    bas = bit;
            //    bit = temp;
            //}

            //int sonuc = 0;
            //for (int i = bas; i <= bit; i++)
            //{
            //    //if (i % 2 == 0 && cevap == "çift")
            //    //{
            //    //    Console.WriteLine(i);
            //    //    sonuc += i;
            //    //}
            //    //else if (i % 2 == 1 && cevap == "tek")
            //    //{
            //    //    Console.WriteLine(i);
            //    //    sonuc += i;
            //    //}

            //    if (i % 2 == (cevap == "tek" ? 1 : 0))
            //    {
            //        Console.WriteLine(i);
            //        sonuc += i;
            //    }
            //}
            //Console.WriteLine($"Sayıların Toplamı:{sonuc}");

            //7 8 9
            //int sonuc = 0;
            //sonuc = sonuc + 7;
            //sonuc = sonuc + 8;
            //sonuc = sonuc + 9;
            //Console.WriteLine(sonuc);


            //Taban değeri giriniz:2
            //Üs değeri giriniz:3
            //İşlemin sonucu:8


            //Console.WriteLine("Taban değeri giriniz:");
            //int taban=int.Parse(Console.ReadLine());
            //Console.WriteLine("Üs değeri giriniz:");
            //int us=int.Parse(Console.ReadLine());

            //int sonuc = 1;
            //for (int i = 0; i < us; i++)
            //{
            //    sonuc = sonuc * taban;
            //}
            //Console.WriteLine(sonuc);

            //Bir sayı giriniz:5
            //Girilen sayının faktoriyeli:120

            //Console.WriteLine("Bir sayı giriniz:");
            //int sayi = int.Parse(Console.ReadLine());
            //int sonuc = 1;
            //for (int i = 2; i <= sayi; i++)
            //{
            //    sonuc *= i;
            //}
            //Console.WriteLine(sonuc);

            //Bir sayı giriniz:11
            //Girdiğiniz sayı asal

            // 2 3 4 5

            //Console.WriteLine("Bir sayı giriniz:");
            //int sayi = int.Parse(Console.ReadLine());


            //if (sayi > 2 && sayi % 2 == 0)
            //{
            //    Console.WriteLine("Asal değil");
            //}
            //else if(sayi<2)
            //{
            //    Console.WriteLine("En küçük asal sayı 2'dir.");
            //}
            //else
            //{
            //    int sayac = 0;
            //    for (int i = 2; i <= (sayi / 2); i++)
            //    {
            //        if (sayi % i == 0)
            //        {
            //            sayac++;
            //            break;
            //        }
            //    }
            //    Console.WriteLine(sayac == 0 ? "Asal" : "Asal Değildir");
            //}

            //for (; ; )
            //{
            //    Console.WriteLine("Kullanıcı adı giriniz");
            //    string user = Console.ReadLine();
            //    Console.WriteLine("Şifre giriniz:");
            //    string pass = Console.ReadLine();
            //    if (user == "admin" && pass == "123")
            //    {
            //        Console.WriteLine("Giriş başarılı!");
            //        break;
            //    }
            //}

            //Bir sayı giriniz:5
            //Devam etmek istiyor musunuz?E
            //Bir sayı giriniz:8
            //Devam etmek istiyor musunuz?E
            //Bir sayı giriniz:3
            //Devam etmek istiyor musunuz?H
            //Girdiğiniz en büyük sayı:8

            int max = int.MinValue;
            int toplam = 0;
            for (; ; )
            {
                Console.Write("Bir sayı giriniz:");
                int sayi = int.Parse(Console.ReadLine());
                toplam += sayi;
                if (sayi>max)
                {
                    max = sayi;
                }
                Console.WriteLine("Devam etmek istiyor musunuz?");
                string cvp=Console.ReadLine();
                if (cvp=="h")
                {
                    break;
                }
                else if (cvp=="e")
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Hatalı giriş yaptınız!");
                }
            }
            Console.WriteLine($"Girilen en büyük sayı:{max}\nSayıların Toplamı:{toplam}");



        }
    }
}
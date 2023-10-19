namespace Gazi.HelloWorldAppSube2
{
    internal class Program
    {
        static int oyuncusayi = 50;
        static void Main(string[] args)
        {
            #region Değişken Tanımlamaları
            //Değer tipi (Value Type) - STACK bölgesi
            //int sayi = 50;
            //byte number = 50;
            ////Referans tipi (Reference type) - HEAP bölgesi
            //string isim = "Ahmet";
            //Console.WriteLine(sayi);
            //Console.WriteLine(number);
            //Console.WriteLine(isim);
            //byte a;
            //a = 30;
            //Console.WriteLine(a);
            //const int number = 50;
            //Console.WriteLine(number);
            //number = 100;
            //Console.WriteLine(number);
            //byte yas=25;
            //Console.WriteLine(yas); 
            #endregion

            #region String biçimlendirme
            //string isim = "Ahmet", soyad = "Mehmet";

            //Console.WriteLine("Merhaba " + isim + " " + soyad);
            //Console.WriteLine("Merhaba {0} {1}", isim, soyad);
            //Console.WriteLine($"Merhaba {isim} {soyad}"); 
            #endregion

            Console.WriteLine("İsminizi Giriniz:");
            string isim = Console.ReadLine();
            Console.ReadKey();
        }
    }
}

//8bit = 1 Byte
//1024byte = 1 Kilobyte(KB)
//1024 KB = 1 Megabyte(MB)
//1024 MB = 1 Gigabyte(GB)
//1024 GB = 1 Terabyte(TB)


//Namespace: İçinde classları bulunduran yapılardır.
//{}: Blok Yapısı(Scope)
//Class: İçinde metodları bulunduran yapılardır.
//Metod: İş yapan kod bloklarıdır.
//Main Metodu: Console uygulamalarının giriş noktasıdır.
//Syntax: Kod yazım kuralları

//Derleme(Compile): C#->Build->MS-IL(exe)->Runtime->Makina Dili(0-1)

//Ctrl+B: Derleme kısayolu
//Ctrl+K+D:Kodları düzenle
//Ctrl+K+C:Yorum satırı
//Ctrl+K+U:Yorumu eski haline çevirme
//IntelliSense: Kod yazım yardımcısı
//IntelliCode: Yapay Zeka Kod yazım yardımcısı
//Solution: İçerisinde bir yada birden fazla proje bulunduran yapılardır.Projelerin disk üzerinde kayıtlı oldugu yer bilgisini tutar.

//.NET
//Microsoft tarafından geliştirilen bir yazılım geliştirme platformudur(Framework)
//.NET Bileşenleri
// 1- Programlama Dilleri C#-VB-F#
// 2- Editörler: Visual Studio-Visual Studio Code
// 3- Kütüphaneler: Namespace
// 4- Runtime

//.NET ile yapılabilecekler
// 1- Desktop Applications (Console,Windows Forms App..)
// 2- Web Applications 
// 3- Mobile Applications (Android-iOS) Xamarin Applications
// 4- Game Development : Unity
// 5- IoT: Internet Of Things : Akıllı Cihazlar
// 6- AI: Yapay Zeka
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temel_ifadeler_ornek_cozumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //// 1. Soru
            //Console.WriteLine("Merhaba");
            //Console.WriteLine("Onur ÖZEL");


            //// 2. Soru
            //Console.WriteLine(8+7);
            //Console.WriteLine(97-55);
            //Console.WriteLine(9*8);
            //Console.WriteLine(10 / 2);

            //// 3. Soru
            //Console.WriteLine(-3 + 9 * 5);
            //Console.WriteLine((45 + 2) * 8);
            //Console.WriteLine((35 / 7) % 3);
            //Console.WriteLine(19 + (-5) * 7 / 3);
            //Console.WriteLine(3 + 15 / 5 * 2 - 9 % 4);

            // 4.Soru
            //Console.WriteLine("Birinci Sayıyı Giriniz --> ");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("İkinci Sayıyı Giriniz --> ");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Birinci Sayı : " + sayi1 + " İkinci Sayı : " + sayi2);
            //Console.WriteLine("Sayılar Yer Değiştiriyooooorrr....");

            //int yedek;

            //yedek = sayi1;
            //sayi1 = sayi2;
            //sayi2 = yedek;

            //Console.WriteLine("Birinci Sayı : "+sayi1+" İkinci Sayı : "+sayi2);

            //// 5. Soru
            //Console.WriteLine("Birinci Sayı : ");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("İkinci Sayı");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Üçüncü Sayı");
            //int sayi3 = Convert.ToInt32(Console.ReadLine());

            //int sonuc = sayi1 * sayi2 * sayi3;
            //Console.WriteLine("{0} * {1} * {2} = {3}", sayi1, sayi2, sayi3, sonuc);

            // 6. Soru
            //Console.WriteLine("Birinci Sayı : ");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("İkinci Sayı : ");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("{0} + {1} = {2}", sayi1, sayi2, (sayi1 + sayi2));
            //Console.WriteLine("{0} - {1} = {2}", sayi1, sayi2, (sayi1 - sayi2));
            //Console.WriteLine("{0} * {1} = {2}", sayi1, sayi2, (sayi1 * sayi2));
            //Console.WriteLine("{0} / {1} = {2}", sayi1, sayi2, (sayi1 / sayi2));
            //Console.WriteLine("{0} % {1} = {2}", sayi1, sayi2, (sayi1 % sayi2));

            // 7. Soru
            //Console.WriteLine("Birinci Sayı : ");
            //double sayi1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("İkinci Sayı : ");
            //double sayi2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Üçüncü Sayı : ");
            //double sayi3 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Dördüncü Sayı : ");
            //double sayi4 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Beşinci Sayı : ");
            //double sayi5 = Convert.ToDouble(Console.ReadLine());

            //double sonuc = (sayi1 + sayi2 + sayi3 + sayi4 + sayi5) / 5;
            //Console.WriteLine("{0}, {1}, {2}, {3}, {4} sayılarının ortalaması : {5}", sayi1, sayi2, sayi3, sayi4, sayi5, sonuc);

            // 8. Soru
            //Console.WriteLine("Sıcaklığı celcius cinsinden giriniz : ");
            //int celcius = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Kelvin : {0}", (celcius + 273));
            //Console.WriteLine("Fahrenheit : {0}", (celcius * 18 / 10 + 32));

            // 9. Soru
            //string cumle = "Bu bir C# Programlama örneğidir.";

            //Console.WriteLine(cumle.ToLower());

            // 10. Soru
            Console.WriteLine("Vize Notunu Giriniz :");
            double vize = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Final Notunu Giriniz : ");
            double final = Convert.ToDouble(Console.ReadLine());

            double sonuc = vize * 0.4 + final * 0.6;

            Console.WriteLine("Sonuc : {0}", sonuc);




            Console.ReadKey();
        }
    }
}

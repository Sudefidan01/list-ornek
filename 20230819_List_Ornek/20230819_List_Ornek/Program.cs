using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230819_List_Ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan kaç adet sayı girmek istediğini soralım
            //O kadar sayıyı List<> koleksiyonu içerisinde barındıralım
            //Kullanıcının girmiş olduğu sayıların toplamını ve ortalamasını ekrana yazdıralım
            Console.Write("Kaç adet sayı girmek istersiniz : ");
            int adet=int.Parse(Console.ReadLine());

            List<double> sayilar = new List<double>();

            for (int i = 1; i <=adet; i++)
            {
                Console.Write(i+". Sayıyı Giriniz  : ");
                int sayi=int.Parse(Console.ReadLine());
                sayilar.Add(sayi);
            }
            double toplam = 0;
            foreach (var item in sayilar)
            {
                toplam += item;
            }
            double ort=toplam/sayilar.Count();

            Console.Clear();
            Console.WriteLine("Sayıların Toplamı = "+toplam);
            Console.WriteLine("Sayıların Ortalaması = "+ort);

            Console.ReadKey();
        }
    }
}

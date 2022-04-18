using System;

namespace hata_ayiklama
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bir sayı giriniz:");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş Oldugunuz Sayı:" + sayi);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.ToString());                
               
            }
            finally
            {
                Console.WriteLine("İşlem Tamamlandı");
            }

            try
            {
                //int a = int.Parse(null);
                //int a = int.Parse("test");
                int a = int.Parse("-200000000000");

            }
            catch (AggregateException ex)
            {                
                Console.WriteLine("Boş değer girdiniz");
                Console.WriteLine(ex);
            }
            catch (FormatException ex)
            {                
                Console.WriteLine("Veri tipi uygun değildir.");
                Console.WriteLine(ex);
            }
            catch (OverflowException ex)
            {                
                Console.WriteLine("Çok büyük veya çok küçük bir değer girdiniz.");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("İşlem Tamamlandı");
            }
        }
    }
}

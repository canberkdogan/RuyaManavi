using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Rüya Manavında Fiyatlar Çok Uygun");
        Console.WriteLine("Elma 2 TL \n Armut 3 TL \n Çilek 2 TL \n Muz 3 TL \n diğer bütün meyveler 4 TL");
        Console.Write("Hangi Meyveyi satın almak istiyorusunuz?");


        string meyve = Console.ReadLine().ToLower(); // Büyük küçük harf duyarlılığı için ToLower'ı kullandım
        int fiyat = 0;

        /*if (meyve == "elma")
        {
            fiyat = 2;
        }
        else if (meyve == "armut")
        {
            fiyat = 3;
        }
        else if (meyve == "çilek")
        {
            fiyat = 2;
        }
        else if (meyve == "muz")
        {
            fiyat = 3;
        }
        else
        {
            fiyat = 4;
        }
       */
       
        switch (meyve) // Bu tarz bir örnek için Switch case kullanmak daha mantıklı

        {
            case "elma":
                fiyat = 2;
                break;
            case "armut":
                fiyat = 3;
                break;
            case "çilek":
                fiyat = 2;
                break;
            case "muz":
                fiyat = 3;
                break;
            default:
                fiyat = 4;
                break;
        }






        Console.WriteLine($"{meyve} fiyatı: {fiyat} TL'dir");
        
       
    }
}
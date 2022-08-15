internal class Program
{
    private static void Main(string[] args)
    {
        string sayi="999";
        bool sonuc = int.TryParse(sayi, out int outSayi);
        if(sonuc==true)
        {
            Console.WriteLine("Başarılı");
            Console.WriteLine(outSayi);
        }
        else
        {
            Console.WriteLine("Başarısız");
        }

        Metotlar instance = new Metotlar();
        instance.topla(4,5,out int toplamSonucu);
        Console.WriteLine(toplamSonucu);

        //Method Overloading
        int ifade =999;
        instance.ekranaYazdir(Convert.ToString(ifade)); 
    }
}

class Metotlar
{  
     public void topla(int a, int b, out int toplam)
     {
        toplam=a+b;
     }

     public void ekranaYazdir(string veri)
     {
        Console.WriteLine(veri);
     }
}
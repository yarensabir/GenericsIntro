using System;

// Engin Demiroğ - Yazılım Geliştirici Yetiştirme Kampı
// Ders 4 + Ödev 5

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Engin");
            Console.WriteLine(isimler.Lenght);
            isimler.Add("Demiroğ");
            Console.WriteLine(isimler.Lenght);

        }
    }
}

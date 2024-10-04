using System;

class Program
{
    static void Main()
    {
        // Kullanıcının adını al
        Console.Write("Adınızı girin: ");
        string ad = Console.ReadLine();

        // Kullanıcının soyadını al
        Console.Write("Soyadınızı girin: ");
        string soyad = Console.ReadLine(); 

        // Kullanıcının öğrenci numarasını al
        Console.Write("Öğrenci numaranızı girin: ");
        string ogrenciNo = Console.ReadLine(); 

        // Kullanıcının cep telefonu numarasını al
        Console.Write("Cep telefonunuzu girin: ");
        string cepTel = Console.ReadLine(); 

        // Kullanıcının girdiği bilgilerin tamamını yazdır
        Console.WriteLine("\nGirilen Bilgiler:");
        Console.WriteLine("Ad: " + ad);
        Console.WriteLine("Soyad: " + soyad);
        Console.WriteLine("Öğrenci No: " + ogrenciNo);
        Console.WriteLine("Cep Telefonu: " + cepTel);
    }
}

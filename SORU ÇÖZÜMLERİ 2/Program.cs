using System;

namespace SORU_ÇÖZÜMLERİ_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //	Girilen pozitif herhangi bir tam sayıyı ikilik düzene çeviren programı yazınız.

            string Mod ="";

            Console.Write("Lütfen Bir Sayı Giriniz: ");

            float a = Convert.ToSingle(Console.ReadLine());

            int b = Convert.ToInt32(a);

            if (a <= 0 || a != b)
            {
                mod = "bir pzitif tam sayı girmelisiniz";
            }

            else
            {
                for (; b > 0; b /= 2)
                {
                    Mod = b % 2 + Mod;
                }   
            }
               
            Console.Write(Mod);

            Console.ReadKey();
        }
    }
}

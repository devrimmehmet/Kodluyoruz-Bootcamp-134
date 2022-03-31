using System;

namespace introCSharp
{
     class Program
    {
        static void Main(string[] args)
        {
            // namespace klasör anlamına gelir
            // süslü parantezler açılışı doğum kapanışı ölüm orjinal ifadesiyle scope alan demek 
            // class uygulamanızdaki işlerin sorumluluklarını alan kişiler
            // en küçük çalışma birimi class dır.
            // uygulamanın çalışmaya başlangıç noktası main methodudur.
            // void geriye değer döndürmeyen
            // dünyanın ilk programlanabilir şeyi nedir?
            // miladdan sonra 960 da perste yaşayan üç kardeş "banu musa" kardeşlerin yaptığı bir robotları var bir flüt var parmaklar otomatik olarak hareket ediyor.

            // sayısal veri tipleri
            // byte age = 255; eksi değer almaz. 8bittir
            // sbyte age1 = 256;
            // sbyte age2 = -255; hata - yok
            // sbyte deger1 = -128;
            // sbyte deger2 = 127;
            
            // short deger4 = short.MaxValue;
            // short deger5 = short.MinValue;
            // Console.WriteLine(deger4); //32767
            // Console.WriteLine(deger5);  //-32768

            // ushort deger6 = ushort.MaxValue;
            // Console.WriteLine(deger6); //32767
            // ushort deger7 = ushort.MinValue;  //65535 pozitif
            // Console.WriteLine(deger7); //0

            // int
            // long
            // ulong
            // double
            // float

            // decimal



            // sözel
            //  cep telefonu numarası sözeldir
            //  cep telefonu numarası sayısal değildir ortalamasını almak gibi bir derdin olmaz o yüzden

            // char deger8 = '(';
            // char deger10 = 'a';
            // string deger9 = "Devrim Mehmet Pattabanoğlu"; // katar  bir çok karakterin bir araya geldiği koleksiyon
            // string word = "Türkay Ürkmez"; // bir aray oluşturuyor ve ben bu arrayi kullanabiliyorum.
            // küçük harfle string c#a aittir.
            // String ise büyük harfle yazılırsa .Net e aittir.

            // veri tipi keyword


            //mantıksal

            // george boole matematiksel mantığı sembolik mantığa çeviren kişidir 1 - 0

            // bool veri tipide george boole'den gelir
            // bool isClosed = true;

            // kilo / boyun karesi  (boy metre cinsinden karesi).

            /*
             * Amaç: Kullanıcının boy ve kilosuna göre BMI hesaplamak
             */
            try
            {
                Console.WriteLine("Your Weight : "); string weightValue = Console.ReadLine();
                int weight = Convert.ToInt32(weightValue);

                Console.WriteLine("Your tall (meter unit): "); double height = Convert.ToDouble(Console.ReadLine());

                double bmi = weight / (height * height);
                Console.WriteLine("Your bmi value is " + bmi); //snapi var cw tab tab

                if (bmi<18.5)
	            {
                    Console.WriteLine("You are Underweight");
	            }
                else if(bmi<=24.9)
                {
                    Console.WriteLine("You are normal");
                } 
                else if (bmi <= 29.9)
                {
                    Console.WriteLine("You are overweight"); 
                }
                else
                {
                    Console.WriteLine("You are obese");
                }
            }
            catch (FormatException)
            {

                Console.WriteLine("Please give values with true format");
            }

            //ilk ödev formül geliştir ve formülle uygulamasını yazın

        }
    }
}

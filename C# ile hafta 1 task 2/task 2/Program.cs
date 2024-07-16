    using System;
    using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;
    using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    public static string Bmi(int _boy, int _kilo)
    {
        float payda = _boy / 100f;
        float bmi = _kilo / (payda * payda);

        if (bmi < 18.5)
        {
            return "zayif";
        }
        else if (bmi >= 18.5 && bmi <= 24.9)
        {
            return "Saglikli";
        }
        else if (bmi >= 25 && bmi <= 29.9)
        {
            return "Kilolu";
        }
        else
        {
            return "Obez";
        }


    }
    public static string getad()
    {
        Console.WriteLine("Adinizi giriniz \n");
        string ad = Console.ReadLine();

        if (ad.ToLower() == "hakan")
        {
            //Hakan ismini sevmiyorum
            ad = "hasan";
            index_hakan[sayac] = true;
            bazkilo = 5;

        }
        Console.WriteLine("Ad veriye yazildi");
        return ad;
    }
    public static int getboy()
    {
        Console.WriteLine("Boyunuzu giriniz\n");
        int boy = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Boy veriye yazildi\n");
        return boy;
    }
    public static int getkilo()
    {

        Console.WriteLine("Kilonuzu giriniz \n");

        int kilo = Convert.ToInt32(Console.ReadLine());
        if (index_hakan[sayac])
        {
            kilo += 5;
        }
        return kilo;
    }
    public static string getsoyad()
    {
        Console.WriteLine("soyadini gir");
        string ad = Console.ReadLine();
        Console.WriteLine("soyad veriye yazildi");
        return ad;
    }
    public static int getyas()
    {
        Console.WriteLine("Yasinizi giriniz\n");
        int yas = Convert.ToInt32(Console.ReadLine());
        if (index_hakan[sayac])
        {
            index_hakan_yas[sayac] = yas;
        }
        Console.WriteLine("Boy veriye yazildi\n");
        return yas;
    }

    public static void tumdiziler(string a, string b, int c, int d, int e)
    {
        List <object> tumdiziler = new List<object>();
        tumdiziler.Add(a); tumdiziler.Add(b); tumdiziler.Add(c); tumdiziler.Add(d); tumdiziler.Add(e);


    }
    public static string[] ad_dizi = new string[100];
    public static string[] soyad_dizi = new string[100];
    public static string[] isim_soyisim = new string[100];
    public static int[] boy_dizi = new int[100];
    public static int[] kilo_dizi = new int[100];
    public static int[] yas_dizi = new int[100];
    public static bool[] index_hakan = new bool[100];
    public static int[] index_hakan_yas = new int[100];
    public static int sayac = 0;
    public static int bazkilo = 0;

    public static void VeriEkle()
    {
        ad_dizi[sayac] = getad();
        soyad_dizi[sayac] = getsoyad();
        boy_dizi[sayac] = getboy();
        kilo_dizi[sayac]=getkilo();
        string _bmi = Bmi(boy_dizi[sayac], kilo_dizi[sayac]);
        yas_dizi[sayac] = getyas();
        Console.WriteLine($"\n BMI Skorunuz :{_bmi}\n ");
        tumdiziler(ad_dizi[sayac], soyad_dizi[sayac], boy_dizi[sayac], kilo_dizi[sayac], yas_dizi[sayac]);
        sayac++;

    }

    public static void VeriDuzenle()
    {
        Console.WriteLine("Kacinci veriyi sececeginizi seciniz");
        for (int i = 0; i < sayac; i++)
        {
            Console.WriteLine($"{i + 1}.veri:{ad_dizi[i]}\n");
        }
        int hangiveri = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Sadece Yas,Boy,Kilo degistirebilirsiniz \n Yas (1), Boy(2), Kilo(3)");
        string degis = Console.ReadLine();
        switch (degis)
        {
            case "1":
                Console.WriteLine(yas_dizi[hangiveri - 1] + "  adli veriyi ne ile degistirmek istediginizi seciniz \n");
                int new_yas = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("veriniz " + new_yas + " ile degistirildi\n");
                yas_dizi[hangiveri - 1] = new_yas;
                break;
            case "2":
                Console.WriteLine(boy_dizi[hangiveri - 1] + "  adli veriyi ne ile degistirmek istediginizi seciniz \n");
                int new_boy = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("veriniz " + new_boy + " ile degistirildi\n");
                boy_dizi[hangiveri - 1] = new_boy;
                string bmi_ = Bmi(new_boy, kilo_dizi[hangiveri - 1]);
                Console.WriteLine($"Yeni BMI Skorunuz: {bmi_}");
                break;
            case "3":
                Console.WriteLine(kilo_dizi[hangiveri - 1] + "  adli veriyi ne ile degistirmek istediginizi seciniz \n");
                int new_kilo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("veriniz " + new_kilo + " ile degistirildi\n");
                kilo_dizi[hangiveri - 1] = new_kilo;
                bmi_ = Bmi(boy_dizi[hangiveri - 1], new_kilo);
                Console.WriteLine($"Yeni BMI Skorunuz:{bmi_}");
                break;
        }
    }

    public static void VeriGoster()
    {
        Array.Sort(yas_dizi, 0, sayac);
        Array.Sort(index_hakan, 0, sayac);

        for (int i = 0; i < sayac; i++)
        {
            if (index_hakan[i])
            {
                continue;
            }
            else
            {
                Console.WriteLine($"{i + 1}.veri: {ad_dizi[i]} -- {soyad_dizi[i]} -- {yas_dizi[i]} -- {boy_dizi[i]} --{kilo_dizi[i]} ");
            }
        }
        for (int i = 0; i < sayac; i++)
        {
            if (index_hakan[i])
            {
                Console.WriteLine($"{i + 1}.veri: {ad_dizi[i]} -- {soyad_dizi[i]} -- {index_hakan_yas[i]} -- {boy_dizi[i]} --{kilo_dizi[i]} ");
            }
        }



    }

    public static void VeriCikart()
    {
        Console.WriteLine("Son veri cikartiliyor");
        //overload
        ad_dizi = sil(ad_dizi, sayac);
        soyad_dizi = sil(soyad_dizi, sayac);
        yas_dizi = sil(yas_dizi, sayac);
        boy_dizi = sil(boy_dizi, sayac);
        sayac--;

    }


    public static int[] sil(int[] array, int index)
    {
        int[] temp = new int[array.Length];

        for (int i = 0; i < array.Length - 1; i++)
        {
            temp[i] = array[i];
        }
        //Console.WriteLine("calisti1");
        return temp;
    }

    public static string[] sil(string[] array, int index)
    {
        string[] temp = new string[array.Length];
        for (int i = 0; i < array.Length - 1; i++)
        { temp[i] = array[i]; }
        //Console.WriteLine("calisti");
        return temp;
        
    }


    static void Main()

    {
        while (true)
        {
            Console.WriteLine($"{sayac + 1}.veridesin\n Ekle(1), Cikart(2), Duzenle(3), Goster(4)\n ");
            string secim = Console.ReadLine();

            switch (secim)
            {
                case "1":
                    Console.WriteLine("Veriekle ye giriliyor \n");
                    VeriEkle();
                    break;
                case "2":
                    VeriCikart();
                    break;

                   
                case "3":
                    Console.WriteLine("Duzenleme ekranina giriliyor \n");
                    VeriDuzenle();

                    break;
                case "4":
                    VeriGoster();
                    break;
                default:
                    Console.WriteLine("Yanlış veya eksik tuşladınız.");
                    break;
            }
        }
    }


}











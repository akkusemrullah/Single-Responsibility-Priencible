using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Single_Responsibility_Priencible
{
    // Single Responsibility Priencible (Her sınıf ve metod sadece kendisi ile ilgili olan görevi yapacak.)
    // Basit bir alışeriş sistemi
    // Müşteri kart limitini kontrol ederek alışveriş işlemini tamamlayacak
    class Program
    {
        static void Main(string[] args)
        {
            Urun u1 = new Urun("Telefon", 2000);
            Musteri m1 = new Musteri("Emrullah", 5000);

            LimitKontrol limitKontrol = new LimitKontrol();
            Odeme odeme = new Odeme();
            if (limitKontrol.limitKnt(m1, u1))
            {
                odeme.odemeYap();
            }
            else
            {
                Console.WriteLine("Limit yetersiz!");
            }

            Console.ReadKey();
        }
    }

    class Odeme
    {
        public bool odemeYap()
        {
            Console.WriteLine("Ödeme işlemi yapıldı.");
            return true;
        }
    }
    class LimitKontrol
    {
        public bool limitKnt(Musteri m1, Urun u1)
        {
            if(m1.kartLimiti>= u1.fiyat)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Urun
    {
        public string urunAdi { get; set; }
        public double fiyat { get; set; }

        public Urun (string _urunAdi, double _fiyat)
        {
            urunAdi = _urunAdi;
            fiyat = _fiyat;
        }
    }

    class Musteri
    {
        public string isim { get; set; }
        public double kartLimiti { get; set; }
        public Musteri(string _isim, double _kartLimiti)
        {
            isim = _isim;
            kartLimiti = _kartLimiti;
        }
    }
}

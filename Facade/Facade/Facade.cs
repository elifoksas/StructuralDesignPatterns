using System;

namespace Facade
{
    class Facade
    {
        public class Gadget
        {
            public string islem1()
            {
                return "Gadget: hazır.\n";
            }
            public string islem2()
            {
                return "Gadget: kalkışa hazırlanıyor...\n";
            }
        }
        public class Spencer
        {
            public string islem1()
            {
                return "Spencer: hazır.\n";
            }
            public string islem2()
            {
                return "Spencer:kalkışa hazırlanıyor...\n";
            }
        }
        public class Cephe
        {
            protected Gadget _g;
            protected Spencer _s;

            public Cephe(Gadget altG, Spencer altS)
            {
                this._g = altG;
                this._s = altS;
            }
            public string Islem()
            {
                string sonuc = "Cephe Tasarım Alt Sistemleri Baslattı\n";
                sonuc += this._g.islem1();
                sonuc += this._s.islem1();
                sonuc += "Cephe Tasarımı Altsistemlere Komut Göneriyor\n";
                sonuc += this._g.islem2();
                sonuc += this._s.islem2();
                return sonuc;
            }
        }


        public static void Main(string[] args)
        {
            Gadget altG = new Gadget();
            Spencer altS = new Spencer();
            Cephe cephe = new Cephe(altG, altS);
            Console.WriteLine(cephe.Islem());

            Console.ReadKey();
        }
    }
}

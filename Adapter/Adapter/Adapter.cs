using System;

namespace Adapter
{
    class Adapter
    {
        interface ISiparis
        {
            void siparis(string s);
        }
        class Adapte
        {
            public void ozelSiparis()
            {
                Console.WriteLine("Gitar siparişi oluşturuldu.");
            }
        }
        class Adapterr:Adapte, ISiparis
        {
            public void siparis(string s)
            {
                Console.WriteLine(s + " siparişi oluşturuldu.");
            }
        }
        static void Main(string[] args)
        {
            Adapte _adapte = new Adapte();
            _adapte.ozelSiparis();

            ISiparis _siparis = new Adapterr();
            _siparis.siparis("Keman");

            ISiparis _siparis2 = new Adapterr();
            _siparis2.siparis("Tulum");

            ISiparis _siparis3 = new Adapterr();
            _siparis3.siparis("Saz");

            Console.ReadKey();
        }
    }
}

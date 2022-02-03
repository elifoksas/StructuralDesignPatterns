using System;

namespace Proxy
{
    class Proxy
    {
        public interface ISubject {
            string Istek();
     
        }

        private class Subject
        {
            public string Istek()
            {
                return "Soldaki kapıya git.\n";
            }
        }
        public class Proxxy:ISubject
        {
            Subject _subject;
            public string Istek()
            {
                if (_subject == null)
                {
                    Console.WriteLine("Robot inaktif durumdadır.\n");
                    _subject = new Subject();
                    return "Proxy sınıfı robotun isteğini bulamıyor.Lütfen robotu aktif ediniz. \n";
                }
                else
                {
                    Console.WriteLine("Robot aktif durumdadır. \n");
                    return "Proxy sınıfı robotun isteğini belirtiyor: " + _subject.Istek();

                }
            }

        }
        public class korumaProxy : ISubject
        {
            Subject _subject;
            string sifre = "hodor";

            public string dogrulama(string _s)
            {
                if (_s != sifre)              
                    return "Koruma Proxy: Sifre geçerli değil. Erişim izni yok.\n";              
                else
                    return "Koruma Proxy: Sifre geçerli. Erişim Sağlandı\n";

            }
            public string Istek()
            {
                if (_subject == null)
                    return "Koruma Proxy: İlk olarak doğrulama işlemi gerçekleştiriniz.\n";
                else
                    return "Proxy sınıfı robotun isteğini belirtiyor: "+_subject.Istek();
            }
        }

        static void Main(string[] args)
        {
            ISubject _subject = new Proxxy();
            Console.WriteLine(_subject.Istek());
            Console.WriteLine(_subject.Istek());

            _subject = new korumaProxy();
            Console.WriteLine((_subject as korumaProxy).dogrulama("deneme"));
            Console.WriteLine((_subject as korumaProxy).dogrulama("hodor"));
            Console.WriteLine(_subject.Istek());


            Console.ReadKey();
        }
    }
}

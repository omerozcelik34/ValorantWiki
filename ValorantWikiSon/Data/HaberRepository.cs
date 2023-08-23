using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ValorantWikiSon.Models;

namespace ValorantWikiSon.Data
{
    public class HaberRepository
    {
        private static List<Haber> _haberler = null;

        static HaberRepository()
        {
            _haberler = new List<Haber>
            {
                new Haber {id=1,Baslik="Kafe Turnuvaları - Haziran 2023",Resim="/images/haberler/haber-kafe.jpg",Aciklama="3-25 Haziran tarihleri arasında gerçekleştirilecek kafe turnuvalarına takımını kurup gel ve heyecanın bir parçası ol!",Link="https://playvalorant.com/tr-tr/news/community/kafe-turnuvalari-haziran-2023/"},
                new Haber {id=2,Baslik="VALORANT 6.10 Yama Notları",Resim="/images/haberler/haber-yama.jpg",Aciklama="Sprey Çarkı'na hangi spreyleri koyacaksınız? Yeni özellikler ve daha fazlası bu yazıda.",Link="https://playvalorant.com/tr-tr/news/game-updates/valorant-6-10-yama-notlari/"},
                new Haber {id=3,Baslik="VALORANT Topluluk Turnuvası - Mayıs",Resim="/images/haberler/haber-topluluk.jpg",Aciklama="29-30-31 Mayıs tarihlerinde gerçekleştirilecek toplam 34.000 TL değerinde ödül havuzuna sahip VALORANT Topluluk Turnuvası'nı kaçırmayın!",Link="https://playvalorant.com/tr-tr/news/community/valorant-topluluk-turnuvasi-mayis/"},
                new Haber {id=4,Baslik="Türkiye’de VALORANT Fiyat Değişiklikleri",Resim="/images/haberler/haber-fiyat.jpg",Aciklama="25 Nisan’da Türkiye’de VP fiyat güncellemesine gidiyoruz.",Link="https://playvalorant.com/tr-tr/news/announcements/turkiye-de-valorant-fiyat-degisiklikleri/"}

            };
        }

        public static List<Haber> Haberler
        {
            get
            {
                return _haberler;
            }
        }

        public static void AddHaber(Haber haber)
        {
            _haberler.Add(haber);
        }

        public static Haber GetHaberById(int id)
        {
            return _haberler.FirstOrDefault(k => k.id == id);
        }
    }
}

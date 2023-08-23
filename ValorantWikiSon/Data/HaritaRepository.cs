using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ValorantWikiSon.Models;

namespace ValorantWikiSon.Data
{
    public class HaritaRepository
    {
        private static List<Harita> _haritalar = null;

        static HaritaRepository()
        {
            _haritalar = new List<Harita>
            {
                new Harita {id=1,Isim="Ascent",Resim="/images/haritalar/ascent.jpg",Aciklama="Ascent, Valorant'ta yer alan modern ve şehirsel bir haritadır. İki bombsite'a sahip olan harita, oyunculara stratejik seçenekler sunar. Açık ve geniş alanlarla birlikte dar koridorlar ve yüksek avantajlı noktalar içerir. Teröristler bombayı yerleştirerek patlatmaya çalışırken, savunmacılar bunu engellemeye çalışır. Ascent, taktiksel düşünmeyi gerektiren rekabetçi bir harita olarak bilinir. Ascent, Valorant'ın çeşitli haritalarından biridir ve oyunculara benzersiz bir oyun deneyimi sunar. Oyuncular, doğru zamanlama, pozisyonlama ve iletişim becerilerini kullanarak Ascent haritasında üstünlük sağlamaya çalışırlar. Bu harita, strateji meraklıları ve rekabetçi oyuncular için heyecan dolu bir oyun ortamı sunar."},
                new Harita {id=2,Isim="Haven",Resim="/images/haritalar/haven.jpg",Aciklama="Haven, Valorant'ta yer alan büyük ve çeşitli taktiksel seçenekler sunan bir haritadır. Avrupa temalı ortamıyla dikkat çeken harita, üç bombsite'a sahiptir ve oyunculara geniş bir oyun alanı sunar. Teröristlerin bombayı yerleştirip patlatma amacına karşı savunmacılar stratejik pozisyonlar alır. Haritanın büyüklüğü ve çok sayıda bombsite seçeneği, farklı stratejilerin kullanılmasını ve takım koordinasyonunun önemini vurgular. Haven, taktiksel düşünme, iletişim ve takım çalışmasının ön planda olduğu heyecanlı bir harita olarak Valorant oyuncularına stratejik bir deneyim sunar."},
                new Harita {id=3,Isim="Bind",Resim="/images/haritalar/bind.jpg",Aciklama="Bind, Valorant'ta çöl temalı bir harita olarak dikkat çeker. Dar koridorlar, geçiş noktaları ve yüksek avantajlı noktalarıyla oyunculara taktiksel bir deneyim sunar. Harita, iki bombsite'a sahip olup teröristlerin bombayı yerleştirme amacına karşı savunmacılar stratejik pozisyonlar alır. Dar koridorlar ve geçiş noktaları, stratejik hareketler ve iyi iletişim becerileriyle avantaj elde etmek için kullanılır. Bind, Valorant'ın rekabetçi atmosferinde strateji ve hızlı tempolu oyun deneyimini bir araya getirir. Oyuncular, haritayı etkili bir şekilde kullanarak taktiksel becerilerini sergilerken, heyecan dolu bir oyun deneyimi yaşarlar."},
                new Harita {id=4,Isim="Breeze",Resim="/images/haritalar/breeze.jpg",Aciklama="Breeze, Valorant'ta tropikal bir ada temalı nefes kesici bir haritadır. Geniş açık alanlar, gizli geçişler ve taktiksel seçenekler sunan harita, üç bombsite'a sahiptir. Teröristlerin bombayı yerleştirme amacına karşı savunmacılar stratejik pozisyonlar alır. Geniş açık alanlar oyunculara nişancılık becerilerini sergileme imkanı sunarken, gizli geçişler ve engeller taktiksel avantajlar sağlar. Breeze haritası, görsel açıdan etkileyici bir atmosfere sahip olup taktiksel düşünme, koordinasyon ve iletişim becerilerini gerektiren bir oyun deneyimi sunar. Oyuncular, bu haritada stratejik planlama yaparak taktiksel üstünlük sağlama fırsatı bulurlar, böylece Valorant'ta heyecan dolu bir deneyim yaşarlar."},
                new Harita {id=5,Isim="Fracture",Resim="/images/haritalar/fracture.jpg",Aciklama="Fracture, Valorant'ta çatlaklarla dolu sıra dışı bir haritadır. İlginç tasarımı ve yıkılmış yapılarıyla dikkat çeken harita, oyunculara benzersiz bir deneyim sunar. İki bombsite'a sahip olan Fracture, taktiksel oyun tarzını destekler. Çatlaklar ve alternatif geçiş noktaları, oyunculara yaratıcı stratejiler uygulama ve taktiksel avantajlar elde etme imkanı sağlar. Teröristlerin bombayı yerleştirme amacına karşı savunmacılar, stratejik pozisyonlar alarak haritayı kontrol etmeye çalışır. Fracture, Valorant'taki diğer haritalardan farklı bir atmosfere sahip olup stratejik düşünme, hızlı tepki verme ve koordinasyon gerektiren heyecanlı bir oyun deneyimi sunar."},
                new Harita {id=6,Isim="Pearl",Resim="/images/haritalar/pearl.jpg",Aciklama="Pearl, Valorant'ın haritası olan, Su altında geçen bir mücadeleyi sunan Pearl, oyuncuların farklı bir deneyim yaşamasını sağlıyor. Harita, üç farklı koridora sahip olup oyunculara çeşitli savaş alanları sunuyor. Ayrıca, Portekizli sanatçıların Fado müziklerinin çalındığı ve duvar resimlerinde Portekizli ressamların eserlerinin yer aldığı ilginç detaylarla dolu. Pearl haritası, su altı şehri Pearl'in iklim değişikliğiyle mücadele edilen bir dünyada inşa edildiği hikayesine sahip ve oyun içinde restoran ve kafeler gibi şehir öğelerini de içeriyor. Valorant oyuncuları, bu yeni haritanın ilgi çekici özellikleri ve su altı atmosferiyle heyecanlanarak deneyimlemeyi bekliyor."},
                new Harita {id=7,Isim="Lotus",Resim="/images/haritalar/lotus.jpg",Aciklama="Lotus haritasının öne çıkan özelliği ise Haven haritasına benzer üç bölgeye sahip olmasıdır. Batı Ghats’ta, Omega Earth’ün Hindistan’ında yer alıyor ve büyük ölçüde Hint basamaklı kuyu yapıları ve kayaya oyulmuş Dravidian Mimarisinden ilhamlar haritaya verilmiştir. Lotus haritası, irfandaki Muhafızların doğru bir görsel temsilini sağlayan çeşitli göstergeler ve öğeler içermektedir. Fakat, bu özellikler gizli ve oyuncu tabanının kendilerinin fark etmesi ve keşfetmesi için dışarıda bırakılıyor. Lotus haritasına üç farklı yeni mekanik dahil. Breeze ve Fracture haritasında da gözlemlediğimiz gelenekler kayar kapılar yerine dönen kapılara sahip. Lotus haritasında yeni “sessiz düşme” mekaniği de yer alacak ve üç yeni mekaniği de Valorant’ta türünün ilk örneği olarak deneyimleyeceksiniz."},
                new Harita {id=8,Isim="Icebox",Resim="/images/haritalar/icebox.jpg",Aciklama="Icebox, Valorant oyununda yer alan zorlu ve heyecan dolu bir haritadır. Karlı ve buzlu bir ortamda geçen harita, oyunculara taktiksel oyun deneyimi sunar. İki bombsite'a sahip olan Icebox, oyunculara farklı taktiksel seçenekler sunar. Oyuncuların karlı yollar, dar geçişler ve yüksek noktalar arasında manevra yapması gerekmektedir. Icebox, stratejik düşünme, iletişim ve koordinasyonu önemseyen oyuncular için zorlu bir mücadele sunar. Haritanın atmosferi ve oynanışı, Valorant'ın rekabetçi atmosferine heyecan katar. Oyuncular, Icebox haritasında başarılı olmak için uygun stratejiler geliştirmeli ve taktiksel avantajları kullanmalıdır."},
                new Harita {id=9,Isim="Split",Resim="/images/haritalar/split.jpg",Aciklama="Split, Valorant'ta yer alan Asya temalı bir haritadır. Oyunculara dikey bir yapı sunan harita, yukarıdan aşağıya ve sağdan sola hareket imkanı sağlar. İki bombsite'a sahip olan Split, teröristlerin bombayı yerleştirip patlatma amacına karşılık savunmacıların engelleme stratejilerini gerektirir. Stratejik pozisyonlama, takım çalışması ve iletişim Split haritasında üstünlük sağlamak için önemlidir. Oyuncular, harita özelliklerini kullanarak rakiplerine karşı avantaj elde etmeye çalışırken, takım koordinasyonu büyük önem taşır. Split haritası, Valorant'ın rekabetçi atmosferinde zorlu ve heyecan dolu bir deneyim sunar."}

            };
        }

        public static List<Harita> Haritalar
        {
            get
            {
                return _haritalar;
            }
        }

        public static void AddHarita(Harita harita)
        {
            _haritalar.Add(harita);
        }

        public static Harita GetHaritaById(int id)
        {
            return _haritalar.FirstOrDefault(k => k.id == id);
        }
    }
}

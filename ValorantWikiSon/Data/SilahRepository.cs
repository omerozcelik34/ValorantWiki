using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ValorantWikiSon.Models;

namespace ValorantWikiSon.Data
{
    public class SilahRepository
    {
        private static List<Silah> _silahlar = null;

        static SilahRepository()
        {
            _silahlar = new List<Silah>
            {
                new Silah {id=1,Isim="Vandal",Hasar="40",Fiyat="2900",Atishizi="9.75",Reloadspeed="2.5",Rol="Taarruz",Detayresim="vandal-detay.jpg",Resim="/images/silahlar/Vandal.png",Aciklama="Vandal, Valorant oyununda tercih edilen bir tüfektir ve oyuncular arasında popülerliği yüksektir. Yüksek hasar gücü ve hassas nişan alma kabiliyetiyle bilinen Vandal, hem tekli ateş modunda hem de seri ateş modunda kullanılabilir. Yüksek mermi penetrasyon kabiliyeti sayesinde düşmanların zırhını etkili bir şekilde delebilir ve uzun menzilli nişanlarda da istikrarlı bir ateş gücü sunar. Geri tepme kontrolü gerektirebilir, ancak doğru nişan alındığında yüksek hasar veren ve güven veren bir silahtır. Vandal, becerikli nişancılar ve uzun menzilli savaşlarda üstünlük sağlamak isteyen oyuncular için ideal bir seçenektir."},
                new Silah {id=2,Isim="Phantom",Hasar="31",Fiyat="2900",Atishizi="11",Reloadspeed="2.5",Rol="Taarruz",Detayresim="phantom-detay.jpg",Resim="/images/silahlar/Phantom.png",Aciklama="Phantom, Valorant oyununda popülerliği yüksek olan bir tüfektir. Yüksek ateş hızı ve düşük geri tepme özelliği sayesinde hızlı ve kesintisiz bir ateş gücü sunar. Sessiz bir şekilde ateş etme kabiliyeti ve seri ateş moduyla kısa mesafelerde yüksek hasar verebilme potansiyeline sahiptir. Phantom'un hassas nişan alma kabiliyeti yüksektir ve uzun menzilde etkili bir performans sergiler. Taktiksel ve hızlı tepki gerektiren oyuncular için ideal bir silahtır. Valorant oyuncuları arasında tercih edilen bir seçenektir ve güvenle kullanılabilir."},
                new Silah {id=3,Isim="Operator",Hasar="150",Fiyat="4700",Atishizi="0.6",Reloadspeed="3.7",Rol="Keskin Nişancı Tüfeği",Detayresim="operator-detay.jpg",Resim="/images/silahlar/Operator.png",Aciklama="Operator, Valorant oyununda etkili bir keskin nişancı tüfeği olarak öne çıkar. Tek atışla düşmanları anında öldürebilme yeteneği ve yüksek mermi penetrasyonu sayesinde güçlü bir hasar potansiyeline sahiptir. Yavaş ateş hızı ve büyük geri tepme gibi zorluklarına rağmen, doğru nişan alma ve zamanlama becerileriyle kullanıldığında oyunun dengesini değiştirebilir. Operator, keskin nişancılık yeteneklerine sahip oyuncular tarafından tercih edilen bir silahtır ve stratejik bir oyun tarzını benimseyen oyuncular için ideal bir seçenektir."},
                new Silah {id=4,Isim="Spectre",Hasar="20",Fiyat="1600",Atishizi="13.33",Reloadspeed="2.25",Rol="Hafif Makineli",Detayresim="spectre-detay.jpg",Resim="/images/silahlar/Spectre.png",Aciklama="Spectre, Valorant oyununda ekonomik bir makineli tüfek olarak bilinen ve çok yönlü bir silahtır. Yüksek ateş hızı ve düşük geri tepme özellikleriyle oyunculara hızlı ateş etme ve hareket etme esnekliği sağlar. Ekonomik bir seçenek olması, oyuncuların kaynaklarını verimli bir şekilde yönetmelerini ve düşmanlarla etkili bir mücadele sürdürmelerini sağlar. Spectre, yakın ve orta mesafelerde etkili bir performans sergilerken oyunculara kontrol ve çok yönlülük imkanı sunar. Valorant oyuncuları arasında yaygın bir tercih olan Spectre, ekonomik avantajı ve etkili ateş gücüyle dikkat çeker."},
                new Silah {id=5,Isim="Sheriff",Hasar="55",Fiyat="800",Atishizi="4",Reloadspeed="2.25",Rol="Tabanca",Detayresim="sheriff-detay.jpg",Resim="/images/silahlar/Sheriff.png",Aciklama="Sheriff, Valorant oyununda yüksek hasar verme potansiyeline sahip ve tek atışla düşmanları öldürebilen bir tabanca silahıdır. Baş bölgesine isabet eden bir atışla anında ölüm sağlayabilme özelliğiyle dikkat çeker. Sheriff, uzun menzilde de etkili olabilir ve düşmanların zırhını delebilme özelliğine sahiptir. Yavaş ateş hızı ve geri tepme zorluklarına rağmen, doğru nişan alma becerisiyle kullanıldığında oyun içinde büyük etkiler yaratabilir. Ekonomik bir seçenek olarak da tercih edilen Sheriff, keskin nişancılık yeteneklerini gerektiren oyuncular arasında popülerdir."}
            };
        }

        public static List<Silah> Silahlar
        {
            get
            {
                return _silahlar;
            }
        }

        public static void AddSilah(Silah silah)
        {
            _silahlar.Add(silah);
        }

        public static Silah GetSilahById(int id)
        {
            return _silahlar.FirstOrDefault(k => k.id == id);
        }
    }
}

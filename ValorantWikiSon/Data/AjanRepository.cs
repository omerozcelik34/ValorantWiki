using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ValorantWikiSon.Models;

namespace ValorantWikiSon.Data
{
    public class AjanRepository
    {
        private static List<Ajan> _ajanlar = null;

        static AjanRepository()
        {
            _ajanlar = new List<Ajan>
            {
                new Ajan {id=1,Isim="Cypher",Rol="Gözcü",Q="cypherQ.png",C="cypherC.png",E="cypherE.png",X="cypherX.png",Resim="/images/ajanlar/cypher.png",Pp="/images/ajanlar/pp/cypherPp.png",Aciklama="Bakalım bu defa nereye gidecekler."},
                new Ajan {id=2,Isim="Sova",Rol="Öncü",Q="sovaQ.png",C="sovaC.png",E="sovaE.png",X="sovaX.png",Resim="/images/ajanlar/sova.png",Pp="/images/ajanlar/pp/sovaPp.png",Aciklama="Nereye kaçarlarsa kaçsınlar onları bulurum."},
                new Ajan {id=3,Isim="Sage",Rol="Gözcü",Q="sageQ.png",C="sageC.png",E="sageE.png",X="sageX.png",Resim="/images/ajanlar/sage.png",Pp="/images/ajanlar/pp/sagePp.png",Aciklama="Bil ki ben hem kalkan hem kılıcım."},
                new Ajan {id=4,Isim="Killjoy",Rol="Gözcü",Q="killjoyQ.png",C="killjoyC.png",E="killjoyE.png",X="killjoyX.png",Resim="/images/ajanlar/killjoy.png",Pp="/images/ajanlar/pp/killjoyPp.png",Aciklama="Alman disipliniyle dalga geçiyosunuz ama tasarladığım cihazları kullanmayı biliyosunuz."},
                new Ajan {id=5,Isim="Jett",Rol="Düellocu",Q="jettQ.png",C="jettC.png",E="jettE.png",X="jettX.png",Resim="/images/ajanlar/jett.png",Pp="/images/ajanlar/pp/jettPp.png",Aciklama="cypher! nerde oldukarını söyle gerisini bana bırak."}

            };
        }

        public static List<Ajan> Ajanlar
        {
            get
            {
                return _ajanlar;
            }
        }

        public static void AddAjan(Ajan ajan)
        {
            _ajanlar.Add(ajan);
        }

        public static Ajan GetAjanById(int id)
        {
            return _ajanlar.FirstOrDefault(k => k.id == id);
        }
    }
}

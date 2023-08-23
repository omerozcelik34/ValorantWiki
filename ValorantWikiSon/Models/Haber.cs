using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ValorantWikiSon.Models
{
    public class Haber
    {
        public int id { get; set; }
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public string Link { get; set; }
        public string Resim { get; set; }
    }
}

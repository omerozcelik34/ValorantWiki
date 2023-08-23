using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ValorantWikiSon.Data;
using ValorantWikiSon.ViewModels;

namespace ValorantWikiSon.Controllers
{
    public class SilahController : Controller
    {
        public IActionResult List(int? id)
        {
            var silahlar = SilahRepository.Silahlar;

            if (id != null)
            {
                silahlar = silahlar.Where(p => p.id == id).ToList();
            }

            var silahViewModel = new SilahViewModel()
            {
                Silahlar = silahlar
            };

            return View(silahViewModel);
        }

        public IActionResult Detay(int id)
        {
            return View(SilahRepository.GetSilahById(id));
        }
    }
    
}

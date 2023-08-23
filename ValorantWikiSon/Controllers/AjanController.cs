using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ValorantWikiSon.Data;
using ValorantWikiSon.ViewModels;

namespace ValorantWikiSon.Controllers
{
    public class AjanController : Controller
    {
        public IActionResult List(int? id)
        {
            var ajanlar = AjanRepository.Ajanlar;

            if (id != null)
            {
                ajanlar = ajanlar.Where(p => p.id == id).ToList();
            }

            var ajanViewModel = new AjanViewModel()
            {
                Ajanlar = ajanlar
            };

            return View(ajanViewModel);
        }

        public IActionResult Detay(int id)
        {
            return View(AjanRepository.GetAjanById(id));
        }
    }
}

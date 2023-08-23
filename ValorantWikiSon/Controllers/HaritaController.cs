using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ValorantWikiSon.Data;
using ValorantWikiSon.ViewModels;

namespace ValorantWikiSon.Controllers
{
    public class HaritaController : Controller
    {
        public IActionResult List(int? id)
        {
            var haritalar = HaritaRepository.Haritalar;

            if (id != null)
            {
                haritalar = haritalar.Where(p => p.id == id).ToList();
            }

            var haritaViewModel = new HaritaViewModel()
            {
                Haritalar = haritalar
            };

            return View(haritaViewModel);
        }

        public IActionResult Detay(int id)
        {
            return View(HaritaRepository.GetHaritaById(id));
        }
    }
}

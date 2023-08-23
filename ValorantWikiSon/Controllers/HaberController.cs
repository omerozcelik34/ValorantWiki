using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ValorantWikiSon.Data;
using ValorantWikiSon.ViewModels;

namespace ValorantWikiSon.Controllers
{
    public class HaberController : Controller
    {
        public IActionResult List(int? id)
        {
            var haberler = HaberRepository.Haberler;

            if (id != null)
            {
                haberler = haberler.Where(p => p.id == id).ToList();
            }

            var haberViewModel = new HaberViewModel()
            {
                Haberler = haberler
            };

            return View(haberViewModel);
        }

        public IActionResult Detay(int id)
        {
            return View(HaberRepository.GetHaberById(id));
        }
    }
}

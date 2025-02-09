using Microsoft.AspNetCore.Mvc;
using AngsuranMVC.Models;
using System.Collections.Generic;

namespace AngsuranMVC.Controllers
{
    public class AngsuranController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Hitung(AngsuranModel model)
        {
            if (ModelState.IsValid)
            {
                model.HitungAngsuran(); 
                var jadwalAngsuran = model.GenerateJadwal();

                return View("Hasil", jadwalAngsuran);
            }
            return View("Index");
        }
    }
}

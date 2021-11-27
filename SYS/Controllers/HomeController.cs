using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SYS.Models;
using SYS.Models.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SYS.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private SysContext _sysContext;

        public HomeController(ILogger<HomeController> logger,SysContext SysContext)
        {
            _logger = logger;
            _sysContext = SysContext;
            
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult SporcuEkle()
        {
            SporcuBilgiViewModel model = new SporcuBilgiViewModel();
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> SporcuEkle(SporcuBilgiViewModel sporcuBilgiViewModel)
        {
            SporcuBilgi sporcuBilgi = new SporcuBilgi
            {
                Ad = sporcuBilgiViewModel.Ad,
                Soyad = sporcuBilgiViewModel.Soyad,
                DogumYeri = sporcuBilgiViewModel.DogumYeri,
                DogumTarihi = sporcuBilgiViewModel.DogumTarihi,
                Boy=sporcuBilgiViewModel.Boy,
                Kilo=sporcuBilgiViewModel.Kilo
                
            };
            _sysContext.Add(sporcuBilgi);
            await _sysContext.SaveChangesAsync();
            return RedirectToAction("SporcuListele");

        }
        public IActionResult SporcuListele()
        {
            var SporcuListesi = _sysContext.SporcuBilgiler.ToList();
            SporcuListeViewModel liste = new SporcuListeViewModel()
            {
                Sporcular = SporcuListesi
            };

            return View(liste);
        }
        public IActionResult Anasayfa()
        {
            return View();
        }
    }
}

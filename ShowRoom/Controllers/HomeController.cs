using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShowRoom.Data.Interfaces;
using ShowRoom.Data.Model;

namespace ShowRoom.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMarqueRepository _marqueRepository;

        public HomeController(IMarqueRepository marqueRepository)
        {
            _marqueRepository = marqueRepository;
        }

        [Route("")]
        public IActionResult Index()
        {
            IEnumerable<Marque> marques = _marqueRepository.GetAll();

            return View(marques);
        }
    }
}

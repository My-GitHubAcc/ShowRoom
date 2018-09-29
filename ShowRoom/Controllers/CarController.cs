using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShowRoom.Data.Interfaces;
using ShowRoom.Data.Model;

namespace ShowRoom.Controllers
{
    public class CarController : Controller
    {
        private readonly IMarqueRepository _marqueRepository;
        private readonly IModelRepository _modelRepository;

        public CarController(IMarqueRepository marqueRepository, IModelRepository modelRepository)
        {
            _marqueRepository = marqueRepository;
            _modelRepository = modelRepository;
        }
        public IActionResult ShowModels(int id)
        {
            Marque marque = _marqueRepository.FindWithModels(id);
            if (marque.Models.Count == 0)
            {
                return View("Empty");
            }
            return View(marque);
        }
        public IActionResult DetailsModel(int id)
        {
            Models model = _modelRepository.FindWithDetails(id);

            return View(model);
        }
    }
}
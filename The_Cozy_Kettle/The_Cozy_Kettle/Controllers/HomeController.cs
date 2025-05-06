using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using The_Cozy_Kettle.Interfaces;
using The_Cozy_Kettle.Models;
using The_Cozy_Kettle.ViewModels;

namespace The_Cozy_Kettle.Controllers
{
   
    public class HomeController : Controller
    {
        private readonly IDrinkRepository _drinkRepository;
        public HomeController(IDrinkRepository drinkRepository)
        {
            _drinkRepository = drinkRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                PreferredDrinks = _drinkRepository.PreferredDrinks
            };
            return View(homeViewModel);
        }
    }
}

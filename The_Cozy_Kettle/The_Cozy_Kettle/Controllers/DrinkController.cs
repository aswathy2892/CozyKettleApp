using Microsoft.AspNetCore.Mvc;
using The_Cozy_Kettle.Interfaces;
using The_Cozy_Kettle.Models;
using The_Cozy_Kettle.ViewModels;

namespace The_Cozy_Kettle.Controllers
{
    public class DrinkController : Controller
    {
        private readonly IDrinkRepository _drinkRepository;
        private readonly ICategoryRepository _categoryRepository;
        public DrinkController(IDrinkRepository drinkRepository,ICategoryRepository categoryRepository)
        {
           _drinkRepository = drinkRepository;
            _categoryRepository = categoryRepository;
        }
        public IActionResult List(string category)
        {
            ViewBag.Name = "cozyKettle";
            //DrinkListViewModel vm=new DrinkListViewModel();
            //vm.Drinks = _drinkRepository.Drinks;
            //vm.CurrentCategory = "DrinkCategory";
            //return View(vm);

            string _category=category;
            IEnumerable<Drink> drinks;

            string currentCategory=string.Empty;

            if (string.IsNullOrEmpty(category))
            {
                drinks = _drinkRepository.Drinks.OrderBy(n => n.DrinkId);
                currentCategory = "All Drinks";
            }

            else
            {
                if(string.Equals("Hot Beverage",_category,StringComparison.OrdinalIgnoreCase))
                {
                    drinks = _drinkRepository.Drinks.Where(p => p.Category.CategoryName.Equals("Hot Beverage")).OrderBy(n => n.DrinkId);
                }
                else
                {
                    drinks = _drinkRepository.Drinks.Where(p => p.Category.CategoryName.Equals("Refresher")).OrderBy(n => n.DrinkId);
                    currentCategory = _category;
                
                }
            }

            var drinkListViewModel = new DrinkListViewModel
            {
                Drinks = drinks,
                CurrentCategory = currentCategory,
            };

            return View(drinkListViewModel);

        }
    }
}

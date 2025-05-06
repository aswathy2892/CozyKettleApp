using Microsoft.AspNetCore.Mvc;
using The_Cozy_Kettle.Interfaces;
using The_Cozy_Kettle.Models;
using The_Cozy_Kettle.ViewModels;

namespace The_Cozy_Kettle.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IDrinkRepository _drinkRepository;
        private readonly ShoppingCart _shoppingcart;

        public ShoppingCartController(IDrinkRepository drinkRepository,ShoppingCart shoppingCart)
        {
            _drinkRepository = drinkRepository;
            _shoppingcart = shoppingCart;
        }
        public IActionResult Index()
        {
            var items = _shoppingcart.GetShoppingCartItems();
            _shoppingcart.ShoppingCartItems=items;

            var sCVM = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingcart,
                ShoppingCartTotal = _shoppingcart.GetShoppingcartTotal()
            };

            return View(sCVM);
        }

        public IActionResult AddToShoppingCart(int drinkId)
        {
            var selectedDrink = _drinkRepository.Drinks.FirstOrDefault(p => p.DrinkId == drinkId);
            if (selectedDrink != null)
            {
                _shoppingcart.AddToCart(selectedDrink, 1);
            }

            return RedirectToAction("Index");
        }

        public IActionResult RemoveFromShoppingCart(int drinkId)
        {
            var selectedDrink = _drinkRepository.Drinks.FirstOrDefault(p => p.DrinkId == drinkId);
            if (selectedDrink != null)
            {
                _shoppingcart.RemoveFromcart(selectedDrink);
            }

            return RedirectToAction("Index");
        }


        [HttpPost]
        public IActionResult UpdateQuantity(int DrinkId, int Amount)
        {
            if (Amount < 1) Amount = 1;

            _shoppingcart.UpdateItemQuantity(DrinkId, Amount);
            return RedirectToAction("Index");
        }
    }
}

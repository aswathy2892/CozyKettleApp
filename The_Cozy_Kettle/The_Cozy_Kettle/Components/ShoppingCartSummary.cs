using Microsoft.AspNetCore.Mvc;
using The_Cozy_Kettle.Models;
using The_Cozy_Kettle.ViewModels;

namespace The_Cozy_Kettle.Components
{
    public class ShoppingCartSummary: ViewComponent
    {
        private readonly ShoppingCart _shoppingCart;
        public ShoppingCartSummary(ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }

        public IViewComponentResult Invoke()
        {
            var items=_shoppingCart.GetShoppingCartItems();

            //var items=new List<ShoppingCartItem>()
            //{
            //    new ShoppingCartItem(),
            //    new ShoppingCartItem()
            //};
            
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingcartTotal()
            };

            return View(shoppingCartViewModel);
        }
    }
}

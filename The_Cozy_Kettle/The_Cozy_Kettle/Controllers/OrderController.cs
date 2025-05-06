using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using The_Cozy_Kettle.Interfaces;
using The_Cozy_Kettle.Models;

namespace The_Cozy_Kettle.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderRepository _orderRepository;
        private readonly ShoppingCart _shoppingcart;
        private readonly ILogger<OrderController> _logger;
        public OrderController(IOrderRepository orderRepository,ShoppingCart shoppingCart,ILogger<OrderController> logger)
        {
            _orderRepository = orderRepository;
            _shoppingcart = shoppingCart;
            _logger = logger;
        }

        [Authorize]
        public IActionResult CheckOut()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public IActionResult CheckOut(Order order)
        {
            var items = _shoppingcart.GetShoppingCartItems();
            _shoppingcart.ShoppingCartItems= items;

            if(_shoppingcart.ShoppingCartItems.Count == 0)
            {
                ModelState.AddModelError("", "Your Cart is Empty ! Add Some Drinks..");

            }


            if (ModelState.IsValid)
            {
                _logger.LogInformation("Order is valid, proceeding with order creation and redirection.");



                order.OrderLines = items.Select(item => new OrderDetail
                {
                    DrinkId = item.Drink.DrinkId,
                    Amount = item.Amount,
                    Price = item.Drink.Price
                }).ToList();

                order.OrderTotal = order.OrderLines.Sum(ol => ol.Price * ol.Amount);
                order.OrderPlaced = DateTime.Now;



                _orderRepository.CreateOrder(order);
                _shoppingcart.ClearCart();

                _logger.LogInformation("Redirecting to CheckOutComplete.");
                return RedirectToAction("CheckOutComplete");

               
            }
            _logger.LogWarning("Model validation failed.");
            return View(order);

            
        }

        

        public IActionResult CheckOutComplete()
        {
            ViewBag.CheckOutCompleteMessage = "Thank you for your order! 😊";
            return View();
        }
    }
}

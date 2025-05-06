using The_Cozy_Kettle.Data;
using The_Cozy_Kettle.Interfaces;
using The_Cozy_Kettle.Models;

namespace The_Cozy_Kettle.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _context;
        private readonly ShoppingCart _shoppingCart;

        public OrderRepository(AppDbContext context, ShoppingCart shoppingCart)
        {
            _context = context;
            _shoppingCart = shoppingCart;
        }
        public void CreateOrder(Order order)
        {
            order.OrderPlaced=DateTime.Now;
            _context.Orders.Add(order);
            _context.SaveChanges();
            var shoppingCartItems = _shoppingCart.ShoppingCartItems;

            foreach(var item in shoppingCartItems)
            {
                var orderDetail = new OrderDetail()
                {
                    Amount = item.Amount,
                    DrinkId = item.Drink.DrinkId,
                    OrderId=order.OrderId,
                    Price=item.Drink.Price

                };

                _context.OrdersDetail.Add(orderDetail);
               

            }
            _context.SaveChanges();
        }
    }
}

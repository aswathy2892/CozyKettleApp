﻿namespace The_Cozy_Kettle.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }
        public Drink Drink { get; set; }
        public int  Amount { get; set; }
        public string ShoppingCartId { get; set; }
    }
}

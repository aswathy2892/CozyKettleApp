﻿namespace The_Cozy_Kettle.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string? CategoryName { get; set; }
        public string? Description { get; set; }
        public virtual ICollection<Drink> Drinks { get; set; } = new List<Drink>();

    }
}

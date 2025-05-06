using The_Cozy_Kettle.Data;

namespace The_Cozy_Kettle.Models
{
    public  class DbInitializer
    {

        public static void Seed(AppDbContext context)
        {
            //AppDbContext context =
            //    applicationBuilder.ApplicationServices.GetRequiredService<AppDbContext>();

            if (!context.Categories.Any())
            {
                context.Categories.AddRange(Categories.Select(c => c.Value));
            }

            if (!context.Drinks.Any())
            {
                context.AddRange
                (
                    new Drink
                    {
                        Name = "Cappuccino",
                        Price = 10.25M,
                        ShortDescription = "Espresso with steamed milk and foam.",
                        LongDescription = "Cappuccino is an Italian coffee drink that is traditionally prepared with equal parts double espresso, steamed milk, and milk foam.",
                        Category = Categories["Hot Beverage"],
                        ImageUrl = "/Images/17.png",
                        InStock = 1,
                        IsPreferredDrink = true,
                        ImageThumbnailUrl = "/Images/17.png"
                    },
                    new Drink
                    {
                        Name = "Espresso",
                        Price = 9.50M,
                        ShortDescription = "Strong and rich Italian coffee.",
                        LongDescription = "Espresso is a full-flavored, concentrated form of coffee served in small shots and made by forcing pressurized hot water through finely-ground coffee beans.",
                        Category = Categories["Hot Beverage"],
                        ImageUrl = "/Images/15.jpg",
                        InStock = 1,
                        IsPreferredDrink = true,
                        ImageThumbnailUrl = "/Images/15.jpg"
                    },
                    new Drink
                    {
                        Name = "Latte",
                        Price = 10.50M,
                        ShortDescription = "Mild espresso with milk.",
                        LongDescription = "A latte is a coffee drink made with espresso and steamed milk, often topped with a light layer of foam and flavored with syrups.",
                        Category = Categories["Hot Beverage"],
                        ImageUrl = "/Images/11.jpg",
                        InStock = 1,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "/Images/11.jpg"
                    },
                    new Drink
                    {
                        Name = "Lemon Mint Cooler",
                        Price = 10.95M,
                        ShortDescription = "Lemonade with mint and crushed ice.",
                        LongDescription = "This zesty lemonade infused with fresh mint and served over crushed ice is both revitalizing and thirst-quenching.",
                        Category = Categories["Refresher"],
                        ImageUrl = "/Images/3.png",
                        InStock = 1,
                        IsPreferredDrink = true,
                        ImageThumbnailUrl = "/Images/3.png"
                    },
                    new Drink
                    {
                        Name = "Matcha Latte",
                        Price = 11.25M,
                        ShortDescription = "Japanese green tea with milk.",
                        LongDescription = "Matcha Latte is made with finely ground matcha green tea powder whisked into steamed milk. It's creamy, earthy, and energizing.",
                        Category = Categories["Hot Beverage"],
                        ImageUrl = "/Images/7.png",
                        InStock = 1,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "/Images/7.png"
                    },
                    new Drink
                    {
                        Name = "Iced Hibiscus Tea",
                        Price = 9.95M,
                        ShortDescription = "Crisp and tangy herbal iced tea.",
                        LongDescription = "Hibiscus petals steeped and chilled, this deep-red drink is tangy, refreshing, and caffeine-free.",
                        Category = Categories["Refresher"],
                        ImageUrl = "/Images/8.jpg",
                        InStock = 0,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "/Images/8.jpg"
                    },
                    new Drink
                    {
                        Name = "Mint Lemonade",
                        Price = 9.75M,
                        ShortDescription = "Classic lemonade with a minty edge.",
                        LongDescription = "Lemon juice and mint leaves blended with sugar and ice — a café essential.",
                        Category = Categories["Refresher"],
                        ImageUrl = "/Images/9.jpg",
                        InStock = 0,
                        IsPreferredDrink = true,
                        ImageThumbnailUrl = "/Images/9.jpg"
                    },
                    new Drink
                    {
                        Name = "Chai Latte",
                        Price = 10.95M,
                        ShortDescription = "Spiced tea with steamed milk.",
                        LongDescription = "Chai Latte is made by mixing spiced black tea concentrate with steamed milk, offering a comforting and aromatic hot beverage.",
                        Category = Categories["Hot Beverage"],
                        ImageUrl = "/Images/20.jpg",
                        InStock = 0,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "/Images/20.jpg"
                    },
                    new Drink
                    {
                        Name = "Flat White",
                        Price = 10.75M,
                        ShortDescription = "Velvety espresso-milk blend.",
                        LongDescription = "A flat white is similar to a latte but uses microfoam and a stronger espresso-to-milk ratio, giving it a smoother texture.",
                        Category = Categories["Hot Beverage"],
                        ImageUrl = "/Images/1.jpg",
                        InStock = 1,
                        IsPreferredDrink = true,
                        ImageThumbnailUrl = "/Images/1.jpg"
                    },
                    new Drink
                    {
                        Name = "Hot Chocolate",
                        Price = 9.95M,
                        ShortDescription = "Rich and creamy cocoa drink.",
                        LongDescription = "Hot chocolate is a sweet, warm beverage made with melted chocolate or cocoa powder, milk, and often topped with whipped cream or marshmallows.",
                        Category = Categories["Hot Beverage"],
                        ImageUrl = "/Images/5.jpg",
                        InStock = 0,
                        IsPreferredDrink = true,
                        ImageThumbnailUrl = "/Images/5.jpg"
                    },
                    new Drink
                    {
                        Name = "Kiwi Refresher",
                        Price = 11.00M,
                        ShortDescription = "Zingy kiwi and lime blend.",
                        LongDescription = "A tangy mix of fresh kiwi puree, lime juice, and honey served ice-cold.",
                        Category = Categories["Refresher"],
                        ImageUrl = "/Images/6.jpg",
                        InStock = 0,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "/Images/6.jpg"
                    },
                    new Drink
                    {
                        Name = "Black Tea",
                        Price = 7.95M,
                        ShortDescription = "Classic, bold tea flavor.",
                        LongDescription = "Black tea is a fully oxidized tea known for its robust flavor and deep amber color. It’s often served plain or with milk and sugar.",
                        Category = Categories["Hot Beverage"],
                        ImageUrl = "/Images/10.png",
                        InStock = 0,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "/Images/10.png"
                    },
                    new Drink
                    {
                        Name = "Americano",
                        Price = 8.75M,
                        ShortDescription = "Espresso diluted with hot water.",
                        LongDescription = "An Americano is a simple and classic coffee drink made by diluting a shot or two of espresso with hot water for a lighter taste.",
                        Category = Categories["Hot Beverage"],
                        ImageUrl = "/Images/18.jpg",
                        InStock = 0,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "/Images/18.jpg"
                    },
                    new Drink
                    {
                        Name = "Macchiato",
                        Price = 9.50M,
                        ShortDescription = "Espresso with a hint of foam.",
                        LongDescription = "A macchiato is an espresso 'stained' with a small amount of milk or foam, offering a bold and rich flavor in a small cup.",
                        Category = Categories["Hot Beverage"],
                        ImageUrl = "/Images/21.jpg",
                        InStock = 0,
                        IsPreferredDrink = true,
                        ImageThumbnailUrl = "/Images/21.jpg"
                    },
                    new Drink
                    {
                        Name = "Cranberry Cooler",
                        Price = 10.50M,
                        ShortDescription = "Tart cranberry meets sweet lime.",
                        LongDescription = "Refreshing cranberry juice blended with lime and topped with soda for a zesty drink.",
                        Category = Categories["Refresher"],
                        ImageUrl = "/Images/2.jpg",
                        InStock = 1,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "/Images/2.jpg"
                    },
                    new Drink
                    {
                        Name = "Turmeric Latte",
                        Price = 11.50M,
                        ShortDescription = "Golden milk with turmeric and spices.",
                        LongDescription = "Turmeric Latte, also known as golden milk, is a warm blend of milk, turmeric, ginger, and cinnamon known for its soothing and anti-inflammatory properties.",
                        Category = Categories["Hot Beverage"],
                        ImageUrl = "/Images/4.jpg",
                        InStock = 1,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "/Images/4.jpg"
                    },
                    new Drink
                    {
                        Name = "Peppermint Tea",
                        Price = 8.45M,
                        ShortDescription = "Refreshing and caffeine-free.",
                        LongDescription = "Peppermint tea is a naturally caffeine-free drink known for its cooling flavor and calming properties.",
                        Category = Categories["Hot Beverage"],
                        ImageUrl = "/Images/12.jpg",
                        InStock = 1,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "/Images/12.jpg"
                    },
                    new Drink
                    {
                        Name = "Herbal Tea",
                        Price = 8.75M,
                        ShortDescription = "Caffeine-free and calming.",
                        LongDescription = "Herbal tea is made from herbs, spices, flowers, or fruits. It’s naturally caffeine-free and perfect for relaxation.",
                        Category = Categories["Hot Beverage"],
                        ImageUrl = "/Images/16.jpg",
                        InStock = 1,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "/Images/16.jpg"
                    }
                   
                );
            }

            context.SaveChanges();
        }

        private static Dictionary<string, Category> categories;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (categories == null)
                {
                    var genresList = new Category[]
                    {
                        new Category { CategoryName = "Hot Beverage", Description="Hot and comforting drinks" },
                        new Category { CategoryName = "Refresher", Description="Cold and refreshing drinks" }
                    };

                    categories = new Dictionary<string, Category>();

                    foreach (Category genre in genresList)
                    {
                        categories.Add(genre.CategoryName, genre);
                    }
                }

                return categories;
            }
        }
    }
}

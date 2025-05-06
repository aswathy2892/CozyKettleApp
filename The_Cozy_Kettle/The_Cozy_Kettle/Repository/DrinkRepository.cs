using Microsoft.EntityFrameworkCore;
using The_Cozy_Kettle.Data;
using The_Cozy_Kettle.Interfaces;
using The_Cozy_Kettle.Models;

namespace The_Cozy_Kettle.Repository
{
    public class DrinkRepository : IDrinkRepository
    {
        private readonly AppDbContext _context;
        public DrinkRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Drink> Drinks => _context.Drinks.Include(c => c.Category);
        public IEnumerable<Drink> PreferredDrinks => _context.Drinks.Where(p => p.IsPreferredDrink).Include(c => c.Category);

        public Drink GetDrinkById(int drinkId)
        {
          return   _context.Drinks.FirstOrDefault(p => p.DrinkId == drinkId);
        }
    }
}

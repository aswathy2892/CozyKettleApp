using The_Cozy_Kettle.Models;

namespace The_Cozy_Kettle.Interfaces
{
    public interface IDrinkRepository
    {
        IEnumerable<Drink> Drinks { get;  }  
        IEnumerable<Drink> PreferredDrinks { get;  }
        Drink GetDrinkById(int drinkId);
    }
}

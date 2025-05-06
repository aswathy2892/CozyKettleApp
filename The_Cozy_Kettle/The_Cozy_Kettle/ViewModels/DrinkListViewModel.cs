using The_Cozy_Kettle.Models;

namespace The_Cozy_Kettle.ViewModels
{
    public class DrinkListViewModel
    {
        public IEnumerable<Drink> Drinks { get; set; }  
        public string CurrentCategory { get; set; }
    }
}

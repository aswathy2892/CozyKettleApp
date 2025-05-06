using The_Cozy_Kettle.Models;

namespace The_Cozy_Kettle.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Categories { get;  }
    }
}

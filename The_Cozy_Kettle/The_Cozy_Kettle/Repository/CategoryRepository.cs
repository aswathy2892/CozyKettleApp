using The_Cozy_Kettle.Data;
using The_Cozy_Kettle.Interfaces;
using The_Cozy_Kettle.Models;

namespace The_Cozy_Kettle.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _context;
        public CategoryRepository(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Category> Categories =>_context.Categories;
    }
}

using Microsoft.AspNetCore.Mvc;
using The_Cozy_Kettle.Interfaces;

namespace The_Cozy_Kettle.Components
{
    public class CategoryMenu: ViewComponent
    {

        private readonly ICategoryRepository _categoryRepository;
        public CategoryMenu(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IViewComponentResult Invoke()
        {
            var categories=_categoryRepository.Categories.OrderBy(p=>p.CategoryName).ToList();
            return View(categories);
        }
    }
}

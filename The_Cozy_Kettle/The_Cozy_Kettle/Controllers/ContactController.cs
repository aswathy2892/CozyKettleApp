using Microsoft.AspNetCore.Mvc;

namespace The_Cozy_Kettle.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

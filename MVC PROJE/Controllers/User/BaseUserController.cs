using Microsoft.AspNetCore.Mvc;

namespace MVC_PROJE.Controllers.User
{
    public class BaseUserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

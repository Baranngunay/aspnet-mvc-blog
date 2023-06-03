using Microsoft.AspNetCore.Mvc;

namespace MVC_PROJE.Controllers.User
{
    public class UserHomeController : BaseUserController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace MVC_PROJE.Controllers.User
{
    public class UserPageController : BaseUserController
    {
        public IActionResult Detail(int id)
        {
            return View();
        }
    }
}

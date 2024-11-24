using Microsoft.AspNetCore.Authorization;
using System.Data;
using Microsoft.AspNetCore.Mvc;

namespace ecommerce.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ManageProducts()
        {
            return View();
        }

        // Add more actions as needed
    }
}
[Authorize(Roles = "Admin")]
public class AdminController : Controller
{
    public IActionResult Dashboard() => View();
}

[Authorize(Roles = "User")]
public class UserController : Controller
{
    public IActionResult Profile() => View();
}

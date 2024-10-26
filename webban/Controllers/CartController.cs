using Microsoft.AspNetCore.Mvc;

namespace webban.Controllers
{
    public class CartController : Controller
    {
        public IActionResult AddToCart(int productId)
        {
            return View("Cart");
        }
    }
}

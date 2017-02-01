using Microsoft.AspNetCore.Mvc;

public class CustomerCareController : Controller
{
    public IActionResult Index()
    {
        return Ok("Index page for customer care");
    }
    public IActionResult Quote()
    {
        return Ok("Qutoe page for customer care");
    }
        public IActionResult claims()
    {
        return Quote();
    }
}
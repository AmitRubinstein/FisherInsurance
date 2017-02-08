using Microsoft.AspNetCore.Mvc;

public class LifeController : Controller
{
    public IActionResult Index()
    {
        //return Ok("Index page for Life");

        return View();
    }
    
    public IActionResult Quote()
    {
        return Ok("Qutoe page for Life");
    }
}
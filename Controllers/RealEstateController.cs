using Microsoft.AspNetCore.Mvc;

public class RealEstateController : Controller
{
    public IActionResult Index()
    {
        return Ok("Index page for Real Estate");
    }
    
    public IActionResult Quote()
    {
        return Ok("Qutoe page for Real Estate");
    }
}
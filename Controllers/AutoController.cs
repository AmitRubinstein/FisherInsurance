using Microsoft.AspNetCore.Mvc;

public class AutoController : Controller
{
    public IActionResult Index()
    {
        return Ok("This is the index of the Auto Controller");
    }

    public IActionResult Quote()
    {
        return Ok("This is the quote page under Auto");
    }
}
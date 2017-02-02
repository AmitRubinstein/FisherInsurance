using Microsoft.AspNetCore.Mvc;

[Route("customer")]
public class CustomerCareController : Controller
{
    public IActionResult Index()
    {
        return Ok("Index page for customer care");
    }

    [Route("fileclaim")]
    public IActionResult NewClaim()
    {
        return Ok("new claim page");
    }

    [Route("myclaims")]
        public IActionResult ClaimHistory()
    {
        return Ok("claim history page");
    }
}
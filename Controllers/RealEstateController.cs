using Microsoft.AspNetCore.Mvc;
using System;
using FisherInsurance.Models;

public class RealEstateController : Controller
{
    public IActionResult Index()
    {
        //return Ok("Index page for Real Estate");

        return View();
    }
    
    public IActionResult Quote()
    {
        Quote quote = new Quote

        {
            Id = 345,
            Product = "Home Insurance",
            ExpireDate = DateTime.Now.AddDays(45),
            Price = 45.00M
        };

        return View(quote);
    }
}
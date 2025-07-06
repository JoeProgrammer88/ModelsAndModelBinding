using Microsoft.AspNetCore.Mvc;
using ModelsAndModelBinding.Models;

namespace ModelsAndModelBinding.Controllers;

public class ProductController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Product p)
    {
        if (ModelState.IsValid)
        {
            // Add product to the database

            // Redirect to product listing page
            return RedirectToAction("Index");
        }

        // Show web page with error messages
        return View(p);
    }
}
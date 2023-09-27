using AlwaysEncrypted.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using AlwaysEncrypted.Data;

namespace AlwaysEncrypted.Controllers;
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private readonly ApplicationDbContext _context;

    public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        return View(_context.Employees.ToList());
    }

    public IActionResult Privacy()
    {
        _context.Add(new Employee { SSN = "795-73-9838", FirstName = "Test First Name", LastName = "Last", Salary = 9900 });
        _context.SaveChanges();
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

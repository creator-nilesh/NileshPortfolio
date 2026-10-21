using Microsoft.AspNetCore.Mvc;

namespace NileshPortfolio.Controllers;

// Each method below is one page. The method name matches the view in Views/Home.
public class HomeController : Controller
{
    public IActionResult Index() => View();

    public IActionResult About() => View();

    public IActionResult Experience() => View();

    public IActionResult Projects() => View();

    public IActionResult Contact() => View();
}

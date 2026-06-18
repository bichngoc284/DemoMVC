using Microsoft.AspNetCore.Mvc;
namespace DemoMVC.Controllers;
public class DemoController : Controller
{
    public IActionResult Index()
    {
        ViewBag.Message = "Hello,Trần Thị Bích Ngọc !";
        return View();
    }
}
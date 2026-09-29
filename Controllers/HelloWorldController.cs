using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class HelloWorldController : Controller
{
    // 
    // GET: /HelloWorld/
    public IActionResult Index()
    {
        return View();
    }
    // 
    // GET: /HelloWorld/Welcome/ 
    /*
    public string Welcome()
    {
        return "This is the Welcome action method...";
    }
    */

    //
    // GET: /HelloWorld/Welcome?name=Asd&numTimes=123 
    /*
    public string Welcome(string name, int numTimes = 1)
    {
        return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
    }
    */

    //
    // GET: /HelloWorld/Welcome/45?name=Fafo
    /*
     * public string Welcome(string name, int ID = 1)
    {
        return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
    }
    */

    // GET: /HelloWorld/Welcome?name=Hehehehehe&numTimes=32
    public IActionResult Welcome (string name, int numTimes= 1)
    {
        ViewData["Message"] = "Hello " + name;
        ViewData["NumTimes"] = numTimes;
        return View();
    }
}
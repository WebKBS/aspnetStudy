using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;


namespace study.Controllers;

public class HelloWorldController : Controller
{
    // GET: /HelloWorld/
    public string Index()
    {
        return "This is my default action...";
    }
    // 
    // GET: /HelloWorld/Welcome/ 
    public string Welcome(string name, int number = 2)
    {
        //return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        return HtmlEncoder.Default.Encode($"Hello {name}, Number = {number}");
    }

   public IActionResult Welcome2(string name, int numTimes = 11) {
        name = "글자글자 한글 글자";
        ViewData["Message"] = "Hello " + name;
        ViewData["NumTimes"] = numTimes;
        return View();
    }
}


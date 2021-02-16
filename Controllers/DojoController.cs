using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace DojoSurvey.Controllers
{
  public class DojoController : Controller
  {
    //Session Vars

    // HttpRequests
    [HttpGet("")]
    public ViewResult Index()
    {
      return View();
    }
    [HttpGet("result")]

    // Redirects
    [HttpPost("method")]
    public ViewResult Method(string name, string dojo_location, string language, string comment)
    {
      ViewBag.name = name;
      ViewBag.location = dojo_location;
      ViewBag.language = language;
      ViewBag.comment = comment;
      return View("Result");
    }
    [HttpGet("back")]
    public RedirectToActionResult Back()
    {
      return RedirectToAction("Index");
    }
  }
}
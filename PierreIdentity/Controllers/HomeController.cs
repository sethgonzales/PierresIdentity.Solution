using Microsoft.AspNetCore.Mvc;
using PierreIdentity.Models;
using System.Collections.Generic;
using System.Linq;

namespace PierreIdentity.Controllers
{
  public class HomeController : Controller
  {
    private readonly PierreIdentityContext _db;
    public HomeController(PierreIdentityContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      Treat[] treats = _db.Treats.ToArray();
      Flavor[] flavors = _db.Flavors.ToArray();
      Dictionary<string, object[]> model = new Dictionary<string, object[]>();
      model.Add("treats", treats);
      model.Add("flavors", flavors);
      return View(model);
    }
  }
}
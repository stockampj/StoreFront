using Microsoft.AspNetCore.Mvc;
using StoreFront.Models;
using StoreFront.Data;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

namespace StoreFront.Controllers
{

  public class TreatsController : Controller
  {
    private readonly ApplicationDbContext _db;
    private readonly UserManager<ApplicationUser> _userManager;

    public TreatsController(UserManager<ApplicationUser> userManager, ApplicationDbContext db)
    {
      _userManager = userManager;
      _db = db;
    }

    public ActionResult Index()
    {
      var treats = _db.Treats;
      return View(treats);
    }

    [Authorize]
    public async Task<ActionResult> Create()
    {
      ViewBag.FlavorId = new SelectList(_db.Flavors, "FlavorId", "Name");
      return View();
    }

    [Authorize]
    [HttpPost]
    public ActionResult Create(Treat treat, int FlavorId)
    {
      _db.Treats.Add(treat);
      if (FlavorId != 0)
      {
        _db.TreatFlavors.Add(new TreatFlavor() { TreatId = treat.TreatId, FlavorId = FlavorId });
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Show(int id)
    {
      var thisTreat = _db.Treats
        .Include(treat => treat.Flavors)
        .ThenInclude(join => join.Flavor)
        .FirstOrDefault(treat => treat.TreatId == id);
      return View(thisTreat);
    }







    [Authorize]
    public ActionResult Delete(int id)
    {
      var thisTreat = _db.Treats.FirstOrDefault(treat => treat.TreatId == id);
      Console.WriteLine(id);
      _db.Treats.Remove(thisTreat);
      _db.SaveChanges();

      return RedirectToAction("Index");
    }

    [Authorize]
    public ActionResult AddFlavor(int id)
    {
      var thisTreat = _db.Treats.FirstOrDefault(treat => treat.TreatId == id);
      ViewBag.FlavorId = new SelectList(_db.Flavors, "FlavorId", "Name");
      return View(thisTreat);
    }

    [HttpPost]
    public ActionResult AddFlavor(Treat treat, int FlavorId)
    {
      if (FlavorId != 0)
      {
        _db.TreatFlavors.Add(new TreatFlavor() { FlavorId = FlavorId, TreatId = treat.TreatId });
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }












  }
}
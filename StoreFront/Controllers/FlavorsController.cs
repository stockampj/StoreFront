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
  public class FlavorsController : Controller
  {
    private readonly ApplicationDbContext _db;
    private readonly UserManager<ApplicationUser> _userManager;

    public FlavorsController(UserManager<ApplicationUser> userManager, ApplicationDbContext db)
    {
      _userManager = userManager;
      _db = db;
    }

    public ActionResult Index ()
    {
        List<Flavor> flavorlist = _db.Flavors.ToList();
        return View(flavorlist);
    }

    [Authorize]
    public ActionResult Create ()
    {
        return View();
    }

    [Authorize]
    [HttpPost]
    public ActionResult Create (Flavor flavor)
    {
        _db.Flavors.Add(flavor);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }

    [Authorize]
    public ActionResult Edit (int id)
    {
        var thisFlavor = _db.Flavors.FirstOrDefault(flavor => flavor.FlavorId == id);
        return View(thisFlavor);
    }

    [Authorize]
    [HttpPost]
    public ActionResult Edit (Flavor flavor)
    {
        _db.Entry(flavor).State = EntityState.Modified;
        _db.SaveChanges();      
        return RedirectToAction("Index");
    }

    [Authorize]
    public ActionResult Show(int id)
    {
        var thisFlavor = _db.Flavors
            .Include(flavor => flavor.Treats)
            .ThenInclude(join => join.Treat)
            .FirstOrDefault(flavor => flavor.FlavorId == id);
        return View(thisFlavor);
    }

    [Authorize]
    public ActionResult Delete(int id)
    {
        var thisFlavor = _db.Flavors.FirstOrDefault(flavor =>flavor.FlavorId == id);
        _db.Flavors.Remove(thisFlavor);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }
  }    
}
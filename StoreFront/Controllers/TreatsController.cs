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
  
  public class TreatsController: Controller
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
    public async Task<ActionResult>  Create()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);
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
        _db.TreatFlavors.Add(new TreatFlavor() {TreatId = treat.TreatId, FlavorId = FlavorId});
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}
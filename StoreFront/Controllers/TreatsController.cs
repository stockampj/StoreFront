  
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
  // [Authorize]
  public class TreatsController: Controller
  {
    private readonly ApplicationDbContext _db;
    // private readonly UserManager<ApplicationUser> _userManager;

    public TreatsController(ApplicationDbContext db)
    {
      // _userManager = userManager;
      _db = db;
    }
  }
}
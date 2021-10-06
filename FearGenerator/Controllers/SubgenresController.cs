using Microsoft.AspNetCore.Mvc;
using FearGenerator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace FearGenerator.Controllers
{
  public class SubgenresController : Controller
  {
    private readonly FearGeneratorContext _db;
    
    public SubgenresController(FearGeneratorContext db)
    {
      _db = db;
    }
    
    public ActionResult Index()
    {
      List<Subgenre> model = _db.Subgenres.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Subgenre subgenre)
    {
      _db.Subgenres.Add(subgenre);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Subgenre thisSubgenre = _db.Subgenres.FirstOrDefault(subgenre => subgenre.SubgenreId == id);
      return View(thisSubgenre);
    }
  }
}
using Microsoft.AspNetCore.Mvc;
using FearGenerator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FearGenerator.Controllers
{
  public class MoviesController : Controller
  {
    private readonly FearGeneratorContext _db;

    public MoviesController(FearGeneratorContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Movie> model = _db.Movies.Include(movie => movie.Subgenre).ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      ViewBag.SubgenreId = new SelectList(_db.Subgenres, "SubgenreId", "Name");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Movie movie)
    {
      _db.Movies.Add(movie);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Movie thisMovie = _db.Movies.FirstOrDefault(movie => movie.MovieId == id);
      return View(thisMovie);
    }

    public ActionResult Search()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Search(string title)
    {
      string searchTerm = title.ToLower();
      List<Movie> searchResult = _db.Movies.Where(movie => movie.Title.Contains(searchTerm)).ToList();
      return View("Index", searchResult);
    }

    public ActionResult Edit(int id)
    {
      Movie thisMovie = _db.Movies.FirstOrDefault(movie => movie.MovieId == id);
      ViewBag.SubgenreId = new SelectList(_db.Subgenres, "SubgenreId", "Name");
      return  View(thisMovie);
    }

    [HttpPost]
    public ActionResult Edit(Movie movie)
    {
      _db.Entry(movie).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Details", new { id = movie.MovieId});
    }
  }
}
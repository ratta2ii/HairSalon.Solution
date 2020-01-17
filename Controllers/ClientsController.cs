using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using HairSalon.Models;

namespace HairSalon.Controllers
{
  public class ClientsController : Controller
  {
    private readonly HairSalonContext _db;
    public ClientsController(HairSalonContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      // List<Client> model = _db.Clients.Include(clients => clients.Stylist).ToList();
      // List<Client> model = _db.Clients.ToList();
      return View();
    }

    // public ActionResult Create()
    // {
    //   ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "Name");
    //   return View();
    // }

    // [HttpPost]
    // public ActionResult Create(Client client)
    // {
    //   _db.Clients.Add(client);
    //   _db.SaveChanges();
    //   return RedirectToAction("Index");
    // }

  }
}

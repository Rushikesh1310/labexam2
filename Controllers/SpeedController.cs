﻿using labexam2.Models;
using Microsoft.AspNetCore.Mvc;

namespace labexam2.Controllers
{
    public class SpeedController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Calculate(SpeedModel model)
        {
          
            model.KilometersPerHour = model.MetersPerSecond * 3.6;

      
            ViewBag.SpeedResult = model.KilometersPerHour;

            return View("Index");
        }

    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gallery_App.Models;
using Microsoft.AspNetCore.Mvc;

namespace Gallery_App.Controllers
{
    public class GalleryController : Controller
    {
        public IActionResult Index()
        {
            var model = new GalleryIndexModel()
            {

            };
            return View(model);
        }
    }
}
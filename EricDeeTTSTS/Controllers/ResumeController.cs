﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EricDeeTTSTS.Controllers
{
    public class ResumeController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }
    }
}

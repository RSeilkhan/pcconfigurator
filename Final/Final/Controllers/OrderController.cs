﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Final.Controllers
{
    public class OrderController : Controller
    {


       

        public IActionResult Checkout()
        {

            return View();
        }

 

    }
}
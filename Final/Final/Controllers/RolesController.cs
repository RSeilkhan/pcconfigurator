using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Final.Models;
using Microsoft.AspNetCore.Authorization;

namespace CustomIdentityApp.Controllers
{

    public class RolesController : Controller
    {

        public IActionResult Create() => View();

       
    }
}
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Final.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Final.Controllers
{
    public class UsersController : Controller
    {
      

        public IActionResult Create() => View();


    }
}
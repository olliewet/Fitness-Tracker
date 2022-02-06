using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TrackHealthAndFitness.Models;
using TrackHealthAndFitness.Repositories;

namespace TrackHealthAndFitness.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IExerciseTrackerRepository exerciseTrackerDB = null;
        private readonly SignInManager<ApplicationUser> _signManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public HomeController(ILogger<HomeController> logger, IExerciseTrackerRepository eDb, SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager  )
        {
            exerciseTrackerDB = eDb;
            _logger = logger;
            _signManager = signInManager;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            if (user != null)
            {
                await CreateRole();
                return RedirectToAction("HomeExercise", "ExerciseManager");
            }
            else
            {
                //await CreateRole();
                return View();
            }
        }
        [Authorize]
        public async Task<IActionResult> FitnessTrackerAsync()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            return View();
       

        }

        public async Task<IdentityRole> CreateRole()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            IdentityRole Role = await _roleManager.FindByIdAsync("PT");
            await _userManager.AddToRoleAsync(user, Role.Name);
            return Role;
            /*
            var user = await _userManager.GetUserAsync(HttpContext.User);
            var Role = new IdentityRole();
            Role.Id = "PT";
            Role.Name = "Personal Trainer";
            await _userManager.AddToRoleAsync(user, "PT");
            bool x = await _roleManager.RoleExistsAsync("PT");
            if(!x)
            {
                await _roleManager.CreateAsync(Role);
               
            }  
            return Role;
            */
        }


        public async Task<ExerciseTracker> AddDatabaseTest()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            ExerciseTracker exercise = new ExerciseTracker()
            {
                Id = user.Id,
                Date = DateTime.Now,
                ExerciseName = "Squat",
                Weight = 400,
                PersonalBest = true,
                TypeOfExercise = ExerciseTracker.MuscleGroups.Legs
            };
            return exercise;
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

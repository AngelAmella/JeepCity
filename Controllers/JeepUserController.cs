using JeepCity.Data;
using JeepCity.Models;
using JeepCity.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JeepCity.Controllers
{
    public class JeepUserController : Controller

    {
        private readonly MVCJeepCityDbContext mvcDemoDbContext;
        public JeepUserController(MVCJeepCityDbContext mvcDemoDbContext)
        {
            this.mvcDemoDbContext = mvcDemoDbContext;
        }


        [HttpGet]
        public IActionResult AddUser()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddUser(AddJeepUserViewModel addUserRequest)
        {
            var user = new JeepCityUser()
            {
                Id = Guid.NewGuid(),
                name = addUserRequest.name,
                email = addUserRequest.email,
                subject = addUserRequest.subject,
                message = addUserRequest.message,
            };

            await mvcDemoDbContext.Users.AddAsync(user);
            await mvcDemoDbContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var user = await mvcDemoDbContext.Users.ToListAsync();
            return View(user);
        }



    }
}

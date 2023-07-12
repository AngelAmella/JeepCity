using JeepCity.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JeepCity.Data
{
    public class MVCJeepCityDbContext : DbContext
    {
        public MVCJeepCityDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet <JeepCityUser> Users { get; set; }

    }
}

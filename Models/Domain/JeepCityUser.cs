using Microsoft.AspNetCore.Mvc;
namespace JeepCity.Models.Domain
{
    public class JeepCityUser
    {
        public Guid Id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string subject { get; set; }
        public string message { get; set; }
    }
}

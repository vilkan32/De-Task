using Delinian.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace Delinian.Controllers
{
    [Controller]
    public class IndexController : ControllerBase
    {
        private readonly IWriteService writeService;
        private readonly IReadService readService;
        public IndexController(IReadService readService, IWriteService writeService)
        {
            this.readService = readService;
            this.writeService = writeService;
        }

        [HttpGet("/api/v1/create")]
        public string CreatePerson(string firstName, string lastName, int age)
        {
            this.writeService.CreatePerson(firstName, lastName, age);

            return $"user with details {firstName}, {lastName}, {age} created";
        }
        [HttpGet("/api/v1/find")]
        public string FindPerson(string firstName)
        {
            var person = this.readService.FindPerson(firstName);
            if (person == null)
            {
                return "not found!";
            }
            return JsonSerializer.Serialize(person);
        }
        [HttpGet("/")]
        public string Index()
        {
            return "Hello world";
        }



    }
}

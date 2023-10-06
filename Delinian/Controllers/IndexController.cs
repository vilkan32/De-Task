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
            var person = this.writeService.CreatePerson(firstName, lastName, age);
            this.writeService.Dispose();

            return $"user with details {person.FirstName}, {person.LastName}, {person.Age} created";
        }
        [HttpGet("/api/v1/find")]
        public string FindPerson(string firstName)
        {
            var person = this.readService.FindPerson(firstName);
            if (person == null)
            {
                return "not found!";
            }
            this.readService.Dispose();
            return JsonSerializer.Serialize(person);
        }
        [HttpGet("/")]
        public string Index()
        {
            return "Hello world";
        }



    }
}

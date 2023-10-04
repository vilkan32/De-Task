using Delinian.Context;
using Delinian.Interfaces;
using Delinian.Models;

namespace Delinian.Services
{
    public class WriteService : IWriteService
    {

        private readonly DelinianContext db;

        public WriteService(DelinianContext db)
        {
            this.db = db;
        }
        public Person CreatePerson(string firstName, string lastName, int age)
        {         
            var person = db.People.Add(new Person { FirstName = firstName, LastName = lastName, Age = age }).Entity;
            db.SaveChanges();
            return person;
        }
    }
}

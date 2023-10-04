using Delinian.Models;

namespace Delinian.Interfaces
{
    public interface IWriteService
    {
        public Person CreatePerson(string firstName, string lastName, int age);
    }
}

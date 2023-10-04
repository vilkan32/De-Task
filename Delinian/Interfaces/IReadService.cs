using Delinian.Models;

namespace Delinian.Interfaces
{
    public interface IReadService
    {
        public Person FindPerson(string firstName);
    }
}

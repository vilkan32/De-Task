using Delinian.Models;
using System;

namespace Delinian.Interfaces
{
    public interface IWriteService : IDisposable
    {
        public Person CreatePerson(string firstName, string lastName, int age);
    }
}

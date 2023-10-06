using Delinian.Models;
using System;

namespace Delinian.Interfaces
{
    public interface IReadService : IDisposable
    {
        public Person FindPerson(string firstName);
    }
}

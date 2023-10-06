using Delinian.Context;
using Delinian.Interfaces;
using Delinian.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Delinian.Services
{
    public class ReadService : IReadService
    {

        private readonly DelinianContext db;

        public ReadService(DelinianContext db)
        {
            this.db = db;
        }

        public void Dispose()
        {
            db.Dispose();
            GC.SuppressFinalize(this);
        }

        public Person? FindPerson(string firstName)
        {
            var user = this.db.People.FirstOrDefault(x => x.FirstName == firstName);

            return user;
        }

    }
}

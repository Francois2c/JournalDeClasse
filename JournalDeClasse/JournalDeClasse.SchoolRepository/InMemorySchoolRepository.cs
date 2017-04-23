using System;
using JournalDeClasse.Domain;
using JournalDeClasse.Services.Contracts.Repositories;


namespace JournalDeClasse.SchoolRepository
{
    public class InMemorySchoolRepository : IRepository<School>
    {
        public School GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Save(School item)
        {
            throw new NotImplementedException();
        }

        public void Update(School item)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace JournalDeClasse.Services.Contracts.Repositories
{
    public interface IRepository<T>
    {
        T GetById(Guid id);

        void Update(T item);

        void Save(T item);
    }
}

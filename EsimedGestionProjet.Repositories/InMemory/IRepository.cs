using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsimedGestionProjet.Repositories.InMemory
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();

        T GetById(Guid id);

        void Insert(T obj);

        void Update(T obj);

        void Delete(Guid obj);
    }
}

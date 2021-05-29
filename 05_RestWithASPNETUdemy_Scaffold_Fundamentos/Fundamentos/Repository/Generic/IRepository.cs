using Fundamentos.Model.Base;
using System.Collections.Generic;

namespace Fundamentos.Repository.Generic
{
    public interface IRepository<T> where T : BaseEntity
    {
        T FindById(long id);
        List<T> FindAll();
        T Create(T item);
        T Update(T item);
        void Delete(long id);
        bool IsExists(long id);
    }
}

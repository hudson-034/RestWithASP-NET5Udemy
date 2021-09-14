using Fundamentos.Model;
using Fundamentos.Repository.Generic;
using System.Collections.Generic;

namespace Fundamentos.Repository
{
    public interface IPersonRepository : IRepository<Person>
    {
        Person Disabled(long id);
        List<Person> FindByName(string firstName, string lastName);
    }
}

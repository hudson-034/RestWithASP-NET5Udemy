using Camadas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Camadas.Repository
{
    public interface PersonRepository
    {
        Person FindById(long id);
        List<Person> FindAll();
        Person Create(Person person);
        Person Update(Person person);
        void Delete(long id);
        bool Exists(long id);
    }
}

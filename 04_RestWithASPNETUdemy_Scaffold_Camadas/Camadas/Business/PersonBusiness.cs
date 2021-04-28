using Camadas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Camadas.Business
{
    public interface PersonBusiness
    {
        Person FindById(long id);
        List<Person> FindAll();
        Person Create(Person person);
        Person Update(Person person);
        void Delete(long id);
    }
}

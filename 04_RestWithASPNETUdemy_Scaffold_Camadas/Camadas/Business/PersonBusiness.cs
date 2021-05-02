using Camadas.Data.VO;
using System.Collections.Generic;

namespace Camadas.Business
{
    public interface PersonBusiness
    {
        PersonVO FindById(long id);
        List<PersonVO> FindAll();
        PersonVO Create(PersonVO person);
        PersonVO Update(PersonVO person);
        void Delete(long id);
    }
}

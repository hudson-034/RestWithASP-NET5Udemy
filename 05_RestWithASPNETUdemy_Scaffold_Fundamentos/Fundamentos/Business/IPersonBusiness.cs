using Fundamentos.Data.VO;
using System.Collections.Generic;

namespace Fundamentos.Business
{
    public interface IPersonBusiness
    {
        PersonVO FindById(long id);
        List<PersonVO> FindAll();
        PersonVO Create(PersonVO person);
        PersonVO Update(PersonVO person);
        void Delete(long id);
    }
}

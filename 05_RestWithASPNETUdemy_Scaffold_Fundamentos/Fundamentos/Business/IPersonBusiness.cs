using Fundamentos.Data.VO;
using Fundamentos.Hypermedia.Utils;
using System.Collections.Generic;

namespace Fundamentos.Business
{
    public interface IPersonBusiness
    {
        PersonVO FindById(long id);
        List<PersonVO> FindByName(string firstName, string lastName);
        List<PersonVO> FindAll();
        PagedSearchVO<PersonVO> FindWithPagedSearch(string name, string sortDirection, int pageSize, int page);
        PersonVO Create(PersonVO person);
        PersonVO Update(PersonVO person);
        PersonVO Disabled(long id);
        void Delete(long id);
    }
}

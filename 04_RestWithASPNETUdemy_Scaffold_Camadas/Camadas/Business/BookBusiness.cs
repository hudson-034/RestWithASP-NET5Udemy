using Camadas.Data.VO;
using System.Collections.Generic;

namespace Camadas.Business
{
    public interface BookBusiness
    {
        List<BookVO> FindAll();
        BookVO FindById(long id);
        BookVO Create(BookVO book);
        BookVO Update(BookVO book);
        void Delete(long id);
    }
}

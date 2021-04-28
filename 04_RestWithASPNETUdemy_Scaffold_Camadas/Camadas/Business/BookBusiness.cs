using Camadas.Model;
using System.Collections.Generic;

namespace Camadas.Business
{
    public interface BookBusiness
    {
        List<Book> FindAll();
        Book FindById(long id);
        Book Create(Book book);
        Book Update(Book book);
        void Delete(long id);
    }
}

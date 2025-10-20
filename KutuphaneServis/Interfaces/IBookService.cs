using KutuphaneCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneServis.Interfaces
{
   public interface IBookService
    {

        IResponse<IEnumerable<Book>> ListAll();

        IResponse<Book> GetById(int id);

        Task<IResponse<Book>> Create(Book Book);

        Task<IResponse<Book>> Update(Book Book);

        Task<IResponse<bool>> Delete(int id);

        IResponse<IEnumerable<Book>> GetByName(string name);
    }
}

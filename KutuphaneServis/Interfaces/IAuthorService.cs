using KutuphaneCore.Entities;
using KutuphaneServis.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneServis.Interfaces
{
    public interface IAuthorService
    {
        IResponse<IEnumerable<Author>> ListAll();

        IResponse<Author> GetById(int id);

        Task <IResponse<Author>> Create(Author author);

        Task<IResponse<Author>> Update(Author author);

        Task<IResponse<bool>> Delete(int id);

        IResponse<IEnumerable<Author>> GetByName(string name);
    }
}

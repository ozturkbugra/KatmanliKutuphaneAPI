using KutuphaneCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneServis.Interfaces
{
    public interface ICategoryService
    {
        IResponse<IEnumerable<Category>> ListAll();

        IResponse<Category> GetById(int id);

        Task<IResponse<Category>> Create(Category Category);

        Task<IResponse<Category>> Update(Category Category);

        Task<IResponse<bool>> Delete(int id);

        IResponse<IEnumerable<Category>> GetByName(string name);
    }
}

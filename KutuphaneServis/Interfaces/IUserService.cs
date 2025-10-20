using KutuphaneCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneServis.Interfaces
{
    public interface IUserService
    {
        IResponse<IEnumerable<User>> ListAll();
        IResponse<User> GetById(int id);
        Task<IResponse<User>> Create(User user);
        Task<IResponse<User>> Update(User user);
        Task<IResponse<bool>> Delete(int id);
        IResponse<IEnumerable<User>> GetByName(string name);
    }
}

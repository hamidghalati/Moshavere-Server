using Moshavere.Data.Models;
using Moshavere.Repo.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Moshavere.Repo.Repositories.Interface
{
    public interface IUserRepository:IRepository<User>
    {
        Task<bool> UserExists(string username);
    }
}

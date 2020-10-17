using Moshavere.Repo.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Moshavere.Repo.Infrastructure
{
    public interface IUnitOfWork<TContext>:IDisposable
    {
        IUserRepository UserRepository { get; }
        void Save();
        Task<int> SaveAsync();
    }
}

using Microsoft.EntityFrameworkCore;
using Moshavere.Data.DataBaseContext;
using Moshavere.Data.Models;
using Moshavere.Repo.Infrastructure;

using Moshavere.Repo.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Moshavere.Repo.Repositories.Repo
{
    public class UserRepository:Repository<User>,IUserRepository
    {
        private readonly DbContext _db;

        public UserRepository(DbContext dbContext) : base(dbContext)
        {
            _db = (_db ?? (MoshavereDbContext)_db);
        }

        public async Task<bool> UserExists(string username)
        {
            if (await GetAsync(p => p.UserName == username) != null)
                return true;
            return false;
        }
    }
}

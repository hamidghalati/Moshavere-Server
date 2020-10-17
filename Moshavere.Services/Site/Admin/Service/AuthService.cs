using Moshavere.Common.Helpers;
using Moshavere.Data.DataBaseContext;
using Moshavere.Data.Models;
using Moshavere.Repo.Infrastructure;
using Moshavere.Services.Site.Admin.Interface;
using System.Threading.Tasks;

namespace Moshavere.Services.Site.Admin.Service
{
    public class AuthService : IAuthService
    {
        private readonly IUnitOfWork<MoshavereDbContext> _db;
        public AuthService(IUnitOfWork<MoshavereDbContext> dbContext)
        {
            _db = dbContext;
        }
        public async Task<User> Login(string username, string password)
        {
            var user = await _db.UserRepository.GetAsync(p => p.UserName == username);
            if (user==null)
            {
                return null;
            }
            if (!Utilities.VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt))
                return null;
            return user;
        }

        public async Task<User> Register(User user, string password)
        {
            byte[] PasswordHash, PasswordSalt;
            Utilities.CreatePasswordHash(password, out PasswordHash, out PasswordSalt);
            user.PasswordHash = PasswordHash;
            user.PasswordSalt = PasswordSalt;
            await _db.UserRepository.InsertAsync(user);
            await _db.SaveAsync();
            return user;
        }


    }
}

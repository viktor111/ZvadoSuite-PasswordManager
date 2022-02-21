using PasswordManager.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.Services.Users
{
    public interface IUserSqlService
    {
        public Task<User> Create(User identityData);

        public Task<User> Update(User identityData);

        public Task Delete(int id);

        public Task<IEnumerable<User>> GetAll();

        public Task<User> Get(int id);
    }
}

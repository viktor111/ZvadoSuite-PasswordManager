using Microsoft.EntityFrameworkCore;
using PasswordManager.Models.Users;
using PasswordManager.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.Services.Users
{
    public class UserSqlService : IUserSqlService
    {
        private readonly PasswordManagerDbContext dbContext;

        public UserSqlService(PasswordManagerDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<User> Create(User user)
        {
            var result = await this.dbContext.AddAsync(user);
            this.dbContext.SaveChanges();

            return result.Entity;
        }

        public async Task Delete(int id)
        {
            var user = await this.Get(id);

            dbContext.Users.Remove(user);
        }

        public async Task<User> Get(int id)
        {
            var result = await this.dbContext.Users.FirstOrDefaultAsync(i => i.Id == id);

            return result;
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            //this.dbContext.Users.RemoveRange(dbContext.Users);
            return await this.dbContext.Users.ToListAsync();
        }

        public async Task<User> Update(User userUpdated)
        {
            var user = await this.dbContext.Users.FirstOrDefaultAsync(i => i.Id == userUpdated.Id);

            if (user == null) throw new Exception("User null in Update");

            user.UpdatePassword(userUpdated.Password);

            await dbContext.SaveChangesAsync();

            return user;
        }
    }
}

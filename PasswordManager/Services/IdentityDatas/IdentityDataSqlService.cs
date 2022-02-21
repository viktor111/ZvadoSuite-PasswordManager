using Microsoft.EntityFrameworkCore;
using PasswordManager.Models.IdentityData;
using PasswordManager.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace PasswordManager.Services.IdentityDatas
{
    public class IdentityDataSqlService : IIdentityDatasSqlService
    {
        private readonly PasswordManagerDbContext dbContext;

        public IdentityDataSqlService(PasswordManagerDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IdentityData> Create(IdentityData identityData)
        {
            var result = await this.dbContext.AddAsync(identityData);
            await dbContext.SaveChangesAsync();

            return result.Entity;
        }

        public async Task Delete(int id)
        {
            var identityData = await this.Get(id);

            dbContext.IdentityDatas.Remove(identityData);

            await dbContext.SaveChangesAsync();
        }

        public async Task<IdentityData> Get(int id)
        {
            var result = await this.dbContext.IdentityDatas.FirstOrDefaultAsync(i => i.Id == id);

            if (result == null) throw new Exception("IdentityData null in Get");

            return result;
        }

        public async Task<IEnumerable<IdentityData>> GetAll()
        {
            return await this.dbContext.IdentityDatas.ToListAsync();
        }

        public async Task<IdentityData> Update(IdentityData identityDataUpdated)
        {
            var identityData = await this.dbContext.IdentityDatas.FirstOrDefaultAsync(i => i.Id == identityDataUpdated.Id);

            if (identityData == null) throw new Exception("IdentityData null in Update");

            identityData.UpdateUserName(identityDataUpdated.UserName);
            identityData.UpdatePassword(identityDataUpdated.Password);

            await dbContext.SaveChangesAsync();

            return identityData;
        }
    }
}

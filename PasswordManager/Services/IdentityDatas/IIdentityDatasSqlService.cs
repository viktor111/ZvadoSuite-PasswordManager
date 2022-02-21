using PasswordManager.Models.IdentityData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.Services.IdentityDatas
{
    public interface IIdentityDatasSqlService
    {
        public Task<IdentityData> Create(IdentityData identityData);

        public Task<IdentityData> Update(IdentityData identityData);

        public Task Delete(int id);

        public Task<IEnumerable<IdentityData>> GetAll();

        public Task<IdentityData> Get(int id);
    }
}

using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.Dtos
{
    public class IdentityDataCsvDto
    {
        

        [Name("name")]
        public string WebSite{ get; set; }

        [Name("url")]
        public string Url { get; set; }

        [Name("username")]
        public string Username { get; set; }

        [Name("password")]
        public string Password { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.Models.Exceptions
{
    internal class InvalidWebDomainException : Exception
    {
        public InvalidWebDomainException()
        {

        }

        public InvalidWebDomainException(string error)
            : base(error)
        {

        }
    }
}

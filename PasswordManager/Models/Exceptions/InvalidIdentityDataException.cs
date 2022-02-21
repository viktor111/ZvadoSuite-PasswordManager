using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.Models.Exceptions
{
    public class InvalidIdentityDataException : Exception
    {
        public InvalidIdentityDataException()
        {

        }

        public InvalidIdentityDataException(string error)
            : base(error)
        {

        }
    }
}

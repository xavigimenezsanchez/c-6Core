using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06_PackLibrary
{
    class BankAccountException : Exception
    {
        public BankAccountException() : base() { }
        public BankAccountException(string message) : base (message) { }
        public BankAccountException(string messasge, Exception innerException) : base(messasge, innerException) { }
    }
}

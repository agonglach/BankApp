using System.Collections.Generic;

namespace BankApp
{
    interface IBank
    {
        public string Name { get; set; }
        public IList<IAccount> Accounts { get; set; }
    }
}

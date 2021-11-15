using System.Collections.Generic;

namespace BankApp
{
    class Bank : IBank
    {
        public string Name { get; set; }
        public IList<IAccount> Accounts { get; set; }
        
        public Bank()
        {

        }

        public Bank(string name, IList<IAccount> accounts)
        {
            Name = name;
            Accounts = accounts;
        }
    }
}

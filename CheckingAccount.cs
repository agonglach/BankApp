namespace BankApp
{
    class CheckingAccount : Account
    {
        public CheckingAccount()
        {

        }

        public CheckingAccount(string owner, double balance)
        {
            Owner = owner;
            Balance = balance;
        }
    }
}

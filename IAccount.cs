namespace BankApp
{
    interface IAccount
    {
        string Owner { get; set; }
        double Balance { get; set; }
        void Deposit(double amount);
        void Withdraw(double amount);
        void Transfer(double amount, IAccount transferToAccount);
    }
}

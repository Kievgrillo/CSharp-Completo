namespace Heranca1.Entities
{
    public class BusinessAccount : Account
    {
        public double loanLimit { get; set; }

        public BusinessAccount()
        {
        }
        public BusinessAccount(int number, string holder, double balance, double loanlimit) : base(number, holder, balance)
        {
            loanLimit = loanlimit;
        }

        public void Loan(double amount)
        {
            if (amount <= loanLimit)
            {
                Balance += amount;
            }
        }
    }
}
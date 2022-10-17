namespace Course.Entities
{
    class BusinessAccount : Account    // subclasse : classe
    {
        public double LoanLimit { get; set; }

        public BusinessAccount()
        {

        }


        public BusinessAccount(int number, string holder, double balance, double loanLimit)
            : base(number, holder, balance) //construtor da superclasse
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;

            }
        }
    }
}

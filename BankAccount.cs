namespace FriendFileForm
{
    class BankAccount
    {
        //Field
        private decimal _balance;

        //Constructor builds new object when class is called for new
        public BankAccount(decimal startingBalance)
        {
            _balance = startingBalance;
        }

        //Balance property (read-only)
        public decimal Balance
        {
            get { return _balance; }
        }

        //Deposit Method
        public void Deposit(decimal amount)
        {
            _balance += amount;
        }

        //overloaded Deposit Method allows class method to be called with a double without converting to decimal first
        public void Deposit(double amount)
        {
            _balance = (decimal)amount;
        }

        //Withdraw method
        public void Withdraw(decimal amount)
        {
            _balance -= amount;
        }
    }
}

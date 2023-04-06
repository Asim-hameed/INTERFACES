namespace DependencyInjection
{
    // Tight Coupling


    //class CurrentAccount
    //{
    //    public void PrintDetails()
    //    {
    //        Console.WriteLine("Details of Current Account");
    //    }
    //}
    //class SavingAccount
    //{
    //    public void PrintDetails()
    //    {
    //        Console.WriteLine("Details of Current Account");
    //    }
    //}
    //class Account
    //{
    //    CurrentAccount CurrentAccount= new CurrentAccount();
    //    SavingAccount SavingAccount= new SavingAccount();
    //    public void PrintDetails()
    //    {
    //        CurrentAccount.PrintDetails();
    //        SavingAccount.PrintDetails();
    //    }
        
    //}

    //................. 

    interface IAccount
    {
        void PrintDetails();
    }
    class CurrentAccount : IAccount
    {
        public void PrintDetails()
        {
            Console.WriteLine("Details of Current Account");
        }
    }
    class SavingAccount : IAccount
    {
        public void PrintDetails()
        {
            Console.WriteLine("Details of Saving Account");
        }
    }

    class Account 
    {
        private IAccount account;

        public Account(IAccount account) // It Should be parametrized
        {
            this.account = account;
        }
        public void PrintAccounts()
        {
            account.PrintDetails();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Account account = new Account();
            //account.PrintDetails();

            ///...............
            ///

            IAccount account =new CurrentAccount(); ;

            Account account1 = new Account(account);
            account1.PrintAccounts();

        }
    }
}
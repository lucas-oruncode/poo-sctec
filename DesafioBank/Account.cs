namespace DesafioBank

{
    public class Account
    {
        public int AccountNumber { get; set; }
        public Customer Customer { get; set; }
        private decimal Balance { get; set; }
        private List<Transaction> transactions = new List<Transaction>();

        public Account()
        {
            AccountNumber = new Random().Next();
            Balance = 0;
        }

        public Account(Customer customer) : this()
        {
            Customer = customer;
        }

        
        public void Deposit(decimal amount)
        {
            transactions.Add(new Transaction(amount, "Depósito"));
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (Balance >= amount)
            {
                transactions.Add(new Transaction(amount, "Saque"));
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para saque.");
            }
        }

        public void Transfer(decimal amount, Account destinationAccount)
        {
            if (Balance >= amount)
            {
                transactions.Add(new Transaction(amount, "Transferência"));
                Balance -= amount;
                destinationAccount.Deposit(amount);
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para transferência.");
            }
        }

        public void DisplayExtract()
        {
            Console.WriteLine("Transações:");

            foreach (var transaction in transactions)
            {
                transaction.DisplayTransaction();
                Console.WriteLine("--------------------");
            }
        }

        public void PrintExtract()
        {
            Console.WriteLine("\n==================================");
            Console.WriteLine($"Número da Conta: {AccountNumber}");
            Console.WriteLine($"Titular: {Customer.Name}");
            Console.WriteLine($"Saldo Atual: {Balance:C2}");
            Console.WriteLine("==================================\n");
            DisplayExtract();
            Console.WriteLine("==================================\n");
        }

    }
}
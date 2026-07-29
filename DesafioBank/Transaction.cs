namespace DesafioBank

{
    public class Transaction
    {
        public decimal Amount { get; set; }
        public string TransferType { get; set; }
        public DateTime Date { get; set; }

        public Transaction(decimal amount, string transferType)
        {
            Amount = amount;
            TransferType = transferType;
            Date = DateTime.Now;
        }

        public void DisplayTransaction()
        {
            Console.WriteLine($"Valor: {Amount:C2} \nTipo: {TransferType} \nData: {Date}");
        }
    }
}
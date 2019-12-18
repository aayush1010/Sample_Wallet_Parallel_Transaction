namespace Sample_Wallet_Parallel_Transaction
{
    public class PersonWallet
    {
        public PersonWallet(string Name, int Amount)
        {
            this.Name = Name;
            this.Amount = Amount;
        }
        public string Name { get; set; }

        public int Amount { get; set; }
    }
}

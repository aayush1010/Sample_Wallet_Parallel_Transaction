using System;

namespace Sample_Wallet_Parallel_Transaction
{
    public class WalletOperation
    {
        public static void DoTransaction(PersonWallet deductFrom, PersonWallet addTo, int amount)
        {
            bool ex = false;
            try
            {
                lock (deductFrom)
                {
                    deductFrom.Amount -= amount;
                }
            }
            catch
            {
                ex = true;
            }
            if (!ex)
            {
                try
                {
                    lock (addTo)
                    {
                        addTo.Amount += amount;
                    }
                }
                catch (Exception e)
                {
                    deductFrom.Amount += amount;
                }
            }
        }
    }
}

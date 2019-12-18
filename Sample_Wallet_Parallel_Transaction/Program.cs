using System;
using System.Threading;

namespace Sample_Wallet_Parallel_Transaction
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonWallet p1 = new PersonWallet("p1", 1000);
            PersonWallet p2 = new PersonWallet("p2", 1000);
            PersonWallet p3 = new PersonWallet("p3", 1000);
            Thread t1 = new Thread(() => WalletOperation.DoTransaction(p1, p2, 1000));
            Thread t2 = new Thread(() => WalletOperation.DoTransaction(p1, p3, 1000));
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();
            Console.WriteLine(p1.Amount + " " + p2.Amount + " " + p3.Amount);
            Console.ReadLine();
        }
    }
}

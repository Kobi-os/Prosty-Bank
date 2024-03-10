using System;

namespace ProstyBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                playWithAccount();
            }
            catch (Exception e)
            {

                Console.WriteLine($"Coś poszło nie tak: {e.Message}");
                Console.ReadKey();
            }
        }

        static public void playWithAccount()
        {
            BankAccount amount = new BankAccount("Wojtek", 200);
            Console.WriteLine();
            amount.MakeDeposit(100, DateTime.Now, "Wpłata");
            amount.MakeWithdraw(50, DateTime.Now, "Wypłata");
            Console.WriteLine();
            amount.ListTransactionHistory();
            Console.WriteLine();
            amount.DisplayInfo();
            Console.WriteLine();
            Console.ReadKey();
        }

    }
}

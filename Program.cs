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
            amount.MakeDeposit(500, DateTime.Now, "Wpłata");
            amount.MakeWithdraw(200, DateTime.Now, "Wypłata");
            Console.WriteLine();
            amount.ListTransactionHistory();
            Console.WriteLine();
            amount.DisplayInfo();
            Console.WriteLine();
            amount.GetLoan(800);
            Console.WriteLine();
            amount.LoanPayOff(500);
            Console.WriteLine();
            amount.RemainingLoan();
            Console.ReadKey();
        }

    }
}

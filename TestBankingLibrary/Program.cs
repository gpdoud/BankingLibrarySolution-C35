using BankingLibraryProject;

using System;

namespace TestBankingLibrary {

    internal class Program {
    
        static void Main(string[] args) {

            Account account = new Account();
            account.CalculateInterest(36);
            Console.WriteLine(account.Balance);
        }
    }
}

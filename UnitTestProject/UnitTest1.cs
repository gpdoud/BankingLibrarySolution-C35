using System;
using BankingLibraryProject;
using Xunit;

namespace UnitTestProject {
    public class UnitTest1 {

        Account acct;

        public UnitTest1() {
            acct = new Account();
            acct.Balance = 100;
        }
        [Fact]
        public void Test1() {
            acct.CalculateInterest(36);
            Assert.Equal(136, acct.Balance);
            acct.Balance = 100;
            acct.CalculateInterest(24);
            Assert.Equal(124, acct.Balance);
            acct.Balance = 100;
            acct.CalculateInterest(12);
            Assert.Equal(112, acct.Balance);
        }
    }
}

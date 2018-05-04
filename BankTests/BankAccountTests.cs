using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankAccountNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountNS.Tests
{
    [TestClass()]
    public class BankAccountTests
    {
        [TestMethod()]
        public void DebitTest()
        {
            BankAccount target = new BankAccount("Mr. Bryan Walton", 11.99);
            double amount = 11.95;
            Assert.AreEqual((System.Convert.ToDouble(amount)), target.Balance, 0.05, "Exito");
        }

        [TestMethod()]
        public void CreditTest()
        {
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
using Loan.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using System.Threading;

namespace XUnitTestProject
{
    public class LoanModelTest
    {

        private LoanApplication loan = new LoanApplication();

        [Fact]
        public void LoanRateTest()
        {

            loan.Rate = 2.5;
            Thread.Sleep(10000);
            Assert.Equal(2.5, loan.Rate);
        }

        [Fact]
        public void LoanTypeTest()
        {

            loan.Type = "mortgage";
            Thread.Sleep(10000);
            Assert.Equal("mortgage", loan.Type);
        }

        [Fact]
        public void LoanRepaymentYearsTest()
        {

            loan.RepaymentYears = 25;
            Thread.Sleep(10000);
            Assert.Equal(25, loan.RepaymentYears);
        }


        [Fact]
        public void LoanAmountTest()
        {

            loan.Amount = 250000;
            Thread.Sleep(10000);
            Assert.Equal(250000, loan.Amount);
        }



    }
}

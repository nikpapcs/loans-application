using Loan.Data.Models;
using Loan.Data.Interfaces;
using Moq;
using System;
using Xunit;
using LoanAPI.Controllers;

namespace XUnitTestProject
{
    public class MVCControllerTests
    {
        [Fact]
        public void LoanReturnsCorrectIdTest()
        {
            var mockLoanRepo = new Mock<ILoanRepository>();

            var LoanId = 2;

            mockLoanRepo.Setup(x => x.GetLoan(It.IsAny<int>())).Returns(new LoanApplication() { Id = 2, Type = "mortgage", Amount = 100000, isVariable = true, Rate = 2.5, RepaymentYears = 25 });
            var controller = new LoansController(mockLoanRepo.Object);

            var response = controller.GetLoan(LoanId);


            Assert.Equal(LoanId, response.Value.Id);


        }

        [Fact]
        public void LoanReturnsCorrectTypeTest()
        {
            var mockLoanRepo = new Mock<ILoanRepository>();
            var LoanId = 2;
            var type = "mortgage";

            mockLoanRepo.Setup(x => x.GetLoan(It.IsAny<int>())).Returns(new LoanApplication() { Id = 2, Type = "mortgage", Amount = 100000, isVariable = true, Rate = 2.5, RepaymentYears = 25 });
            var controller = new LoansController(mockLoanRepo.Object);

            var response = controller.GetLoan(LoanId);


            Assert.Equal(type, response.Value.Type);


        }




        [Fact]
        public void LoanReturnsCorrectAmountTest()
        {
            var mockLoanRepo = new Mock<ILoanRepository>();
            var LoanId = 2;
            var amount = 100000;

            mockLoanRepo.Setup(x => x.GetLoan(It.IsAny<int>())).Returns(new LoanApplication() { Id = 2, Type = "mortgage", Amount = 100000, isVariable = true, Rate = 2.5, RepaymentYears = 25 });
            var controller = new LoansController(mockLoanRepo.Object);

            var response = controller.GetLoan(LoanId);


            Assert.Equal(amount, response.Value.Amount);


        }



        [Fact]
        public void LoanReturnsCorrectVariableTest()
        {
            var mockLoanRepo = new Mock<ILoanRepository>();
            var LoanId = 2;
            var isVariable = true;

            mockLoanRepo.Setup(x => x.GetLoan(It.IsAny<int>())).Returns(new LoanApplication() { Id = 2, Type = "mortgage", Amount = 100000, isVariable = true, Rate = 2.5, RepaymentYears = 25 });
            var controller = new LoansController(mockLoanRepo.Object);

            var response = controller.GetLoan(LoanId);


            Assert.Equal(isVariable, response.Value.isVariable);


        }





        [Fact]
        public void LoanReturnsCorrectRepaymentYearsTest()
        {
            var mockLoanRepo = new Mock<ILoanRepository>();
            var LoanId = 2;
            var RepaymentYears = 25;

            mockLoanRepo.Setup(x => x.GetLoan(It.IsAny<int>())).Returns(new LoanApplication() { Id = 2, Type = "mortgage", Amount = 100000, isVariable = true, Rate = 2.5, RepaymentYears = 25 });
            var controller = new LoansController(mockLoanRepo.Object);

            var response = controller.GetLoan(LoanId);


            Assert.Equal(RepaymentYears, response.Value.RepaymentYears);


        }



        [Fact]
        public void LoanReturnsCorrectRatesTest()
        {
            var mockLoanRepo = new Mock<ILoanRepository>();
            var LoanId = 2;
            var Rate = 2.5;

            mockLoanRepo.Setup(x => x.GetLoan(It.IsAny<int>())).Returns(new LoanApplication() { Id = 2, Type = "mortgage", Amount = 100000, isVariable = true, Rate = 2.5, RepaymentYears = 25 });
            var controller = new LoansController(mockLoanRepo.Object);

            var response = controller.GetLoan(LoanId);


            Assert.Equal(Rate, response.Value.Rate);


        }
    }
}

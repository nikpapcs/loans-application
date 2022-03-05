using Loan.Data.Interfaces;
using Loan.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loan.Data.Repositories
{
    public class LoanRepository : ILoanRepository
    {
        public List<LoanApplication> loans = new List<LoanApplication>()
       {
           new LoanApplication {Id = 1, Type= "Mortgage", Rate =2.5, Amount=10000, isVariable= false,RepaymentYears=25},
            new LoanApplication {Id = 2, Type= "Renovation", Rate =2.5, Amount=5000, isVariable= false,RepaymentYears=25},
             new LoanApplication {Id = 3, Type= "Vacation", Rate =2.5, Amount=10000, isVariable= false,RepaymentYears=25},
              new LoanApplication {Id = 4, Type= "Car", Rate =2.5, Amount=10000, isVariable= false,RepaymentYears=25}
       };

        public bool AddNewLoan(LoanApplication loan)
        {
            throw new NotImplementedException();
        }

        public List<LoanApplication> GetAllLoans()
        {
            return loans;
        }

        public LoanApplication GetLoan(int id)
        {
            var loan = loans.FirstOrDefault(x => x.Id == id);
            return loan;
        }

        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }

        public List<LoanApplication> UpdateLoan(int id, LoanApplication loan)
        {
            throw new NotImplementedException();
        }
    }
}

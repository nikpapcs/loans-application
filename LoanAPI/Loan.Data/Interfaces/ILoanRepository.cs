using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Loan.Data.Models;

namespace Loan.Data.Interfaces
{
    public interface ILoanRepository
    {
        List<LoanApplication> GetAllLoans();
        LoanApplication GetLoan(int id);
        bool AddNewLoan(LoanApplication loan);

        bool Remove(int id);

        List<LoanApplication> UpdateLoan(int id, LoanApplication loan);

    

    }
}

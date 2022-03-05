using Loan.Data.Interfaces;
using Loan.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loan.Data.Repositories
{

    public class LoanDatabase : ILoanRepository
    {

        private LoanContext db;

        public LoanDatabase(LoanContext _db)
        {
            this.db = _db;
        }

        public bool AddNewLoan(LoanApplication loan)
        {
            db.Loans.Add(loan);
            db.SaveChanges();
            return true;
        }

        public List<LoanApplication> GetAllLoans()
        {
            return db.Loans.ToList();
        }

        public LoanApplication GetLoan(int id)
        {
            return db.Loans.FirstOrDefault(x => x.Id == id);

        }

        public bool Remove(int id)
        {
            var loan = GetLoan(id);
            if(loan == null)
            {
                return false;
            }
            db.Loans.Remove(loan);
            db.SaveChanges();
            return true;
        }

        public List<LoanApplication> UpdateLoan(int id, LoanApplication loan)
        {
            if (this.Remove(id))
            {
                this.AddNewLoan(loan);
                db.SaveChanges();
                return db.Loans.ToList();
            }
            return db.Loans.ToList();
        }
    }
}

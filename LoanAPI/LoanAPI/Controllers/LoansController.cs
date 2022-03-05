using Loan.Data.Interfaces;
using Loan.Data.Models;
using Loan.Data.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoansController : ControllerBase
    {


        private ILoanRepository loans;

        public LoansController(ILoanRepository _loans)
        {
            this.loans = _loans;

        }

        [HttpGet]
        public ActionResult<IEnumerable<LoanApplication>> GetAllLoans()
        {
            return loans.GetAllLoans();
        }


        [HttpGet("{id}")]
        public ActionResult<LoanApplication> GetLoan(int id)
        {
            var loan = loans.GetLoan(id);
            if (loan == null)
            {
                return NotFound();
            }
            return loan;
        }

        [HttpPost]
        public ActionResult<LoanApplication> PostLoan(LoanApplication loan)
        {
            if (loans.AddNewLoan(loan))
            {
                return loan;
            }
            return BadRequest();
        }

        [HttpDelete("{id}")]
        public ActionResult<IEnumerable<LoanApplication>> DeleteLoan(int id)
        {
            if (loans.Remove(id))
            {
                return loans.GetAllLoans();
            }
            return NotFound();

        }
       
        [HttpPut("{id}")]

        public ActionResult<IEnumerable<LoanApplication>> UpdateLoan(int id, LoanApplication loanApplication)
        {
            var loan = loans.UpdateLoan(id, loanApplication);
            
            if(loan != null)
            {
                return loan;
            }
            return NotFound();

        }


    }
}

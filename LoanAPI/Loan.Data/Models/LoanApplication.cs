using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Loan.Data.Models
{
    public class LoanApplication
    {
        public int Id { get; set; }

        public string Type { get; set; }

        public bool isVariable { get; set; }

        public double Rate { get; set; }

        public double Amount { get; set; }

        public double RepaymentYears { get; set; }




    }
}

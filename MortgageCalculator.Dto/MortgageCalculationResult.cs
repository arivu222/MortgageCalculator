using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortgageCalculator.Dto
{
    public class MortgageCalculationResult
    {
        public decimal MonthlyRepayment { get; set; }
        public decimal TotalRepayment { get; set; }
        public decimal TotalInterest { get; set; }
    }
}

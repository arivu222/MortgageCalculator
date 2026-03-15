using MortgageCalculator.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MortgageCalculator.Web.Models
{
    public class MortgageDisplayModel
    {
        public List<Mortgage> Mortgages { get; set; }

        public List<SelectListItem> MortgageTypeOptions { get; set; }

        [Display(Name = "Borrowed Amount")]
        public decimal? LoanAmount { get; set; }

        [Display(Name = "Interest Rate")]
        public decimal? InterestRate { get; set; }

        [Display(Name = "Loan Duration (Years)")]
        public int? LoanDurationYears { get; set; }

        [Display(Name = "Mortgage Type")]
        public string SelectedMortgageType { get; set; }

        public decimal? MonthlyRepayment { get; set; }

        public decimal? TotalRepayment { get; set; }

        public decimal? TotalInterest { get; set; }
    }
}
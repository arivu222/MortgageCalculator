using MortgageCalculator.Data;
using MortgageCalculator.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortgageCalculator.Services
{
    public interface IMortgageService
    {
        List<Mortgage> GetAllMortgages();
        List<Mortgage> GetActiveMortgagesSorted();
        MortgageCalculationResult CalculateMortgage(decimal loanAmount, decimal annualInterestRate, int loanDurationYears);
    }

    public class MortgageService : IMortgageService
    {

        private readonly IMortgageRepo _mortgageRepo;
        public MortgageService() : this(new MortgageRepo())
        { }

        public MortgageService(IMortgageRepo mortgageRepo)
        {
            this._mortgageRepo = mortgageRepo;
        }

        public List<Mortgage> GetAllMortgages()
        {
            return _mortgageRepo.GetAllMortgages();
        }

        public List<Mortgage> GetActiveMortgagesSorted()
        {
            var today = DateTime.Today;
            return _mortgageRepo.GetAllMortgages()
                .Where(m => m.EffectiveStartDate <= today &&
                            m.EffectiveEndDate >= today)
                .OrderBy(m => m.MortgageType)
                .ThenBy(m => m.InterestRate)
                .ToList();
        }

        public MortgageCalculationResult CalculateMortgage(decimal loanAmount, decimal annualInterestRate, int loanDurationYears)
        {
            int totalMonths = loanDurationYears * 12;

            if (totalMonths <= 0)
            {
                throw new ArgumentException("Loan duration must be greater than zero.");
            }

            decimal monthlyRepayment;
            decimal totalRepayment;
            decimal totalInterest;

            if (annualInterestRate == 0)
            {
                monthlyRepayment = loanAmount / totalMonths;
            }
            else
            {
                decimal monthlyRate = annualInterestRate / 12 / 100;
                double r = (double)monthlyRate;
                double n = totalMonths;
                double p = (double)loanAmount;

                double emi = p * r * Math.Pow(1 + r, n) / (Math.Pow(1 + r, n) - 1);
                monthlyRepayment = (decimal)emi;
            }

            totalRepayment = monthlyRepayment * totalMonths;
            totalInterest = totalRepayment - loanAmount;

            return new MortgageCalculationResult
            {
                MonthlyRepayment = Math.Round(monthlyRepayment, 2),
                TotalRepayment = Math.Round(totalRepayment, 2),
                TotalInterest = Math.Round(totalInterest, 2)
            };
        }
    }
}

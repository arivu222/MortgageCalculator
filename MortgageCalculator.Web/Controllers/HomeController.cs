using MortgageCalculator.Services;
using MortgageCalculator.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MortgageCalculator.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMortgageService _mortgageService;

        public HomeController()
            : this(new MortgageService())
        {
        }

        public HomeController(IMortgageService mortgageService)
        {
            _mortgageService = mortgageService;
        }

        [HttpGet]
        public ActionResult Index()
        {
            var mortgages = _mortgageService.GetActiveMortgagesSorted();

            var model = new MortgageDisplayModel
            {
                Mortgages = mortgages,
                MortgageTypeOptions = mortgages
                    .Select(x => x.MortgageType.ToString())
                    .Distinct()
                    .Select(x => new SelectListItem
                    {
                        Text = x,
                        Value = x
                    })
                    .ToList()
            };

            return View(model);
        }


        [HttpPost]
        public ActionResult Index(MortgageDisplayModel model)
        {
            var mortgages = _mortgageService.GetActiveMortgagesSorted();

            model.Mortgages = mortgages;
            model.MortgageTypeOptions = mortgages
                .Select(x => x.MortgageType.ToString())
                .Distinct()
                .Select(x => new SelectListItem
                {
                    Text = x,
                    Value = x
                })
                .ToList();

            if (!model.LoanAmount.HasValue || model.LoanAmount <= 0)
            {
                ModelState.AddModelError("LoanAmount", "Please enter a valid loan amount.");
            }

            if (!model.InterestRate.HasValue || model.InterestRate < 0)
            {
                ModelState.AddModelError("InterestRate", "Please enter a valid interest rate.");
            }

            if (!model.LoanDurationYears.HasValue || model.LoanDurationYears <= 0)
            {
                ModelState.AddModelError("LoanDurationYears", "Please enter a valid loan duration.");
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var result = _mortgageService.CalculateMortgage(
                model.LoanAmount.Value,
                model.InterestRate.Value,
                model.LoanDurationYears.Value);

            model.MonthlyRepayment = result.MonthlyRepayment;
            model.TotalRepayment = result.TotalRepayment;
            model.TotalInterest = result.TotalInterest;

            return View(model);
        }

    }
}
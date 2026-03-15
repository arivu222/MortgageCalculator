using MortgageCalculator.Dto;
using MortgageCalculator.Services;
using NUnit.Framework;
using System.Collections.Generic;

namespace MortgageCalculator.UnitTests
{
    [TestFixture]
    public class MortgageServiceTests
    {
        private MortgageService _service;

        [SetUp]
        public void Setup()
        {
            _service = new MortgageService(new FakeMortgageRepo(new List<Mortgage>()));
        }

        [Test]
        public void CalculateMortgage_ShouldReturnMonthlyRepayment_WhenInputValid()
        {
            var result = _service.CalculateMortgage(100000, 5, 20);

            Assert.That(result.MonthlyRepayment, Is.GreaterThan(0));
            Assert.That(result.TotalRepayment, Is.GreaterThan(100000));
            Assert.That(result.TotalInterest, Is.GreaterThan(0));
        }
                                                                                                                            
        [Test]
        public void CalculateMortgage_ShouldReturnFlatPayment_WhenInterestIsZero()
        {
            var result = _service.CalculateMortgage(120000, 0, 10);

            Assert.That(result.MonthlyRepayment, Is.EqualTo(1000));
            Assert.That(result.TotalInterest, Is.EqualTo(0));
        }

        [Test]
        public void CalculateMortgage_ShouldThrowException_WhenLoanAmountIsZero()
        {
            Assert.Throws<System.ArgumentException>(() =>
                _service.CalculateMortgage(0, 5, 10));
        }


        [Test]
        public void CalculateMortgage_ShouldThrowException_WhenInterestNegative()
        {
            Assert.Throws<System.ArgumentException>(() =>
                _service.CalculateMortgage(100000, -1, 20));
        }

        [Test]
        public void GetActiveMortgages_ShouldReturnOnlyActiveRecords()
        {
            var today = System.DateTime.Today;

            var data = new List<Mortgage>
                        {
                            new Mortgage
                            {
                                MortgageId = 1,
                                Name = "Active Loan",
                                MortgageType = MortgageType.Variable,
                                InterestRepayment = InterestRepayment.PrincipalAndInterest,
                                InterestRate = 5,
                                EffectiveStartDate = today.AddDays(-5),
                                EffectiveEndDate = today.AddDays(5)
                            },
                            new Mortgage
                            {
                                MortgageId = 2,
                                Name = "Expired Loan",
                                MortgageType = MortgageType.Fixed,
                                InterestRepayment = InterestRepayment.PrincipalAndInterest,
                                InterestRate = 4,
                                EffectiveStartDate = today.AddDays(-10),
                                EffectiveEndDate = today.AddDays(-1)
                            }
                        };

            var service = new MortgageService(new FakeMortgageRepo(data));

            var result = service.GetActiveMortgagesSorted();

            Assert.That(result.Count, Is.EqualTo(1));
            Assert.That(result[0].Name, Is.EqualTo("Active Loan"));
        }

        [Test]
        public void GetActiveMortgages_ShouldSortByTypeThenInterestRate()
        {
            var today = System.DateTime.Today;

            var data = new List<Mortgage>
            {
                new Mortgage
                {
                    Name = "Variable High",
                    MortgageType = MortgageType.Variable,
                    InterestRate = 6,
                    EffectiveStartDate = today.AddDays(-1),
                    EffectiveEndDate = today.AddDays(10)
                },
                new Mortgage
                {
                    Name = "Variable Low",
                    MortgageType = MortgageType.Variable,
                    InterestRate = 4,
                    EffectiveStartDate = today.AddDays(-1),
                    EffectiveEndDate = today.AddDays(10)
                }
            };

            var service = new MortgageService(new FakeMortgageRepo(data));

            var result = service.GetActiveMortgagesSorted();

            Assert.That(result[0].Name, Is.EqualTo("Variable Low"));
        }
    }
}

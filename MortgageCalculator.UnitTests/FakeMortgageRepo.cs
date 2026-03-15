using MortgageCalculator.Data;
using MortgageCalculator.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortgageCalculator.UnitTests
{
    public class FakeMortgageRepo : IMortgageRepo
    {
        private readonly List<Mortgage> _mortgages;

        public FakeMortgageRepo(List<Mortgage> mortgages)
        {
            _mortgages = mortgages;
        }

        public List<Mortgage> GetAllMortgages()
        {
            return _mortgages;
        }
    }
}

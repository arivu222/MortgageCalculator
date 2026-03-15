using MortgageCalculator.Dto;
using System.Collections.Generic;
using System.Linq;
using MortgageCalculator.Data.Entities;

namespace MortgageCalculator.Data
{
    public interface IMortgageRepo
    {
        List<Mortgage> GetAllMortgages();
    }

    public class MortgageRepo : IMortgageRepo
    {
        public List<Mortgage> GetAllMortgages()
        {
            using (var context = new MortgageDataContext())
            {
                return context.Mortgages
                    .Select(m => new Mortgage
                    {
                        Name = m.Name,
                        EffectiveStartDate = m.EffectiveStartDate,
                        EffectiveEndDate = m.EffectiveEndDate,
                        CancellationFee = m.CancellationFee,
                        EstablishmentFee = m.EstablishmentFee,
                        InterestRepayment = (InterestRepayment)m.InterestRepayment,
                        InterestRate = m.InterestRate,
                        MortgageId = m.MortgageId,
                        MortgageType = (MortgageType)m.MortgageType,
                        TermsInMonths = m.TermsInMonths
                    }).ToList();
            }
        }
    }
}

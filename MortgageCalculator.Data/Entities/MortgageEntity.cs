using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortgageCalculator.Data.Entities
{
    public class MortgageEntity
    {
        [Key]
        public int MortgageId { get; set; }
        public string Name { get; set; }
        public int MortgageType { get; set; }
        public int InterestRepayment { get; set; }
        public decimal InterestRate { get; set; }
        public DateTime EffectiveStartDate { get; set; }
        public DateTime EffectiveEndDate { get; set; }
        public int TermsInMonths { get; set; }
        public decimal CancellationFee { get; set; }
        public decimal EstablishmentFee { get; set; }
        public Guid SchemaIdentifier { get; set; }
    }
}

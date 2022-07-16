using System;
namespace Aggregation
{
    public class SpecialDeposit : Deposit
    {
        public SpecialDeposit(decimal depositAmount, int depositPeriod) : base(depositAmount, depositPeriod)
        { }
        public override decimal Income()
        {
            decimal amount = this.Amount;
            for (int i = 1; i <= this.Period; i++)
            {
                amount = Math.Round(amount * (1 + i / 100.0m), 2);

            }
            return amount - this.Amount;
        }
    }
}
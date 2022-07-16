using System;
namespace Aggregation
{
    public class LongDeposit : Deposit
    {
        public LongDeposit(decimal depositAmount, int depositPeriod) : base(depositAmount, depositPeriod)
        { }
        public override decimal Income()
        {
            decimal amount = this.Amount;
            for (int i = 0; i < this.Period; i++)
            {
                if (i <= 5)
                {
                    continue;
                }
                amount = Math.Round(amount * 1.15m, 2);
            }
            return amount - this.Amount;
        }
    }
}
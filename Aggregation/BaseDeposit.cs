using System;
namespace Aggregation
{
    public class BaseDeposit : Deposit
    {
        public BaseDeposit(decimal depositAmount, int depositPeriod): base(depositAmount, depositPeriod)
        { }
        public override decimal Income()
        {
            decimal amount = this.Amount;
            for (int i = 0; i < this.Period; i++)
            {
                amount = Math.Round(amount * 1.05m, 2); 
            }
            return amount - this.Amount;
        }
    }
}
namespace Aggregation
{
    //TODO: Define public abstract class "Deposit"
    public abstract class Deposit
    {
        public decimal Amount { get; }
        public int Period { get; }
        public Deposit(decimal depositAmount, int depositPeriod)
        { 
            this.Amount = depositAmount;
            this.Period = depositPeriod;
        }
        public abstract decimal Income();
    }
}
namespace Aggregation
{
    public class Client
    {
        private readonly Deposit[] deposits;
        public Client()
        { 
            this.deposits = new Deposit[10];
        }
        public bool AddDeposit(Deposit deposit)
        {
            for (int i = 0; i < this.deposits.Length; i++)
            {
                if (deposits[i] == null)
                { 
                    deposits[i] = deposit;
                    return true;
                }
            }
            return false;
        }
        public decimal TotalIncome()
        {
            decimal sum = 0;
            foreach (Deposit deposit in this.deposits)
            {
                if (deposit != null)
                {
                    sum += deposit.Income();
                }
            }
            return sum;
        }
        public decimal MaxIncome()
        {
            decimal max = 0;
            foreach (Deposit deposit in this.deposits)
            {
                if (deposit != null && deposit.Income() > max)
                { 
                    max = deposit.Income();
                }
            }
            return max;
        }
        public decimal GetIncomeByNumber(int deposit_number)
        {
            deposit_number -= 1;
            if (deposit_number >= 0 && deposit_number < deposits.Length && deposits[deposit_number] != null)
            {
                return deposits[deposit_number].Income();
            }
            return 0;
        }
    }
}
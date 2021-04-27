using System;
using System.Collections.Generic;
using System.Text;

namespace PatronCreacional
{
    public class BNBCreditCard : ICreditCard
    {
        public string Owner { get; set ; }
        public int CardNumber { get; set; }
        public decimal Balance { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string BankName { get; set; } = "BNB";
        public int InterestRate { get; set; } = 3;

        public void DepositMoney(decimal amount)
        {
            Balance += amount;
            MessageActualBalance();
        }

        public decimal GetBalance()
        {
            return Balance;
        }

        public string GetBankName()
        {
            return $"el banco {BankName}";
        }

        public void MessageActualBalance()
        {
            Console.WriteLine($"Ahora El balance de la cuenta de {Owner} es de {Balance} dolares americanos");
        }

        public void Withdrawals(decimal amount)
        {
            Balance -= amount;
            MessageActualBalance();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace PatronCreacional
{
    public interface ICreditCard
    {
        string Owner { get; set; }
        int CardNumber { get; set; }
        decimal Balance { get; set; }
        DateTime ExpirationDate { get; set; }
        string BankName { get; set; }
        int InterestRate { get; set; }


        string GetBankName();
        decimal GetBalance();
        void DepositMoney(decimal amount);
        void Withdrawals(decimal amount);
        void MessageActualBalance();
    }
}

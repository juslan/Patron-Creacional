using System;
using System.Collections.Generic;
using System.Text;

namespace PatronCreacional
{
    public class ConcreteCreditCardFactory : CreditCardFactory
    {
        public override ICreditCard GetCreditCard(string CreditCard)
        {
            switch (CreditCard)
            {
                case "BNB":
                    return new BNBCreditCard();
                case "BCP":
                    return new BCPCreditCard();
                case "BMSC":
                    return new BMSCCreditCard();
                default:
                    throw new Exception(string.Format($"CreditCard '{CreditCard}' cannot be created, we don't have that model"));
            }
        }
    }
}

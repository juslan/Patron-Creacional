using System;
using System.Collections.Generic;
using System.Text;

namespace PatronCreacional
{
    public abstract class CreditCardFactory
    {
        public abstract ICreditCard GetCreditCard(string CreditCard);

    }

}

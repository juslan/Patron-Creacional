using System;

namespace PatronCreacional
{
    class Program
    {
        static void Main(string[] args)
        {
            CreditCardFactory factory = new ConcreteCreditCardFactory();
            ICreditCard bnbCard = factory.GetCreditCard("BNB");
            bnbCard.Owner = "Juslan Vargas";
            bnbCard.CardNumber = 123456798;
            bnbCard.ExpirationDate = new DateTime(2024, 12, 18);
            Console.WriteLine($"El balance de la cuenta de {bnbCard.Owner} es de {bnbCard.GetBalance()} dolares americanos, {bnbCard.GetBankName()}te agradece tu fidelidad.\nTu tasa de interes con nosotros es: {bnbCard.InterestRate} %");
            bnbCard.DepositMoney(150);
            bnbCard.Withdrawals(50);
            Console.WriteLine("---------------");
            ICreditCard bcpCard = factory.GetCreditCard("BCP");
            bcpCard.Owner = "Pepe Morales";
            bcpCard.CardNumber = 123456123;
            bcpCard.ExpirationDate = new DateTime(2023, 11, 21);
            Console.WriteLine($"El balance de la cuenta de {bcpCard.Owner} es de {bcpCard.GetBalance()} dolares americanos, {bcpCard.GetBankName()} te agradece tu fidelidad.\nTu tasa de interes con nosotros es: {bcpCard.InterestRate} %");
            bcpCard.DepositMoney(1500);
            bcpCard.Withdrawals(300);
            Console.WriteLine("---------------");
            ICreditCard bmscCard = factory.GetCreditCard("BMSC");
            bmscCard.Owner = "Juan Paredes";
            bmscCard.CardNumber = 123789456;
            bmscCard.ExpirationDate = new DateTime(2023, 11, 21);
            Console.WriteLine($"El balance de la cuenta de {bmscCard.Owner} es de {bmscCard.GetBalance()} dolares americanos, {bmscCard.GetBankName()} te agradece tu fidelidad.\nTu tasa de interes con nosotros es: {bmscCard.InterestRate} %");
            bmscCard.DepositMoney(800);
            bmscCard.Withdrawals(60);
        }
    }
}

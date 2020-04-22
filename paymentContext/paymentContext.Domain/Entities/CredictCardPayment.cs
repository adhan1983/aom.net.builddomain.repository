using System;

namespace PaymentContext.Domain.Entities
{
    public class CredictCardPayment : Payment
    {
        public CredictCardPayment(
            string cardHolderName, 
            string cardNumber, 
            string lastTransactionNumber,
            string number,
            DateTime paidDate,
            DateTime expireDate,
            decimal total,
            decimal totalPaid,
            string document,
            string payer,
            string address,
            string email) : base(number, paidDate, expireDate, total, totalPaid, document, payer, address, email)
        {
            CardHolderName = cardHolderName;
            CardNumber = cardNumber;
            LastTransactionNumber = lastTransactionNumber;
        }

        public string CardHolderName { get; set; }
        public string CardNumber { get; set; }
        public string LastTransactionNumber { get; set; }
    }
}

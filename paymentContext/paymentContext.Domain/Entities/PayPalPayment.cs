using System;

namespace PaymentContext.Domain.Entities
{
    public class PayPalPayment : Payment
    {
        public PayPalPayment(
            string transactionCode,
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
            TransactionCode = transactionCode;
        }
        public string TransactionCode { get; private set; }
    }
}

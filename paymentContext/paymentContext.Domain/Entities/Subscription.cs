using System;
using System.Collections.Generic;

namespace PaymentContext.Domain.Entities
{
    public class Subscription
    {
        private IList<Payment> _payments;
        public Subscription(DateTime createDate, DateTime lastUpdateDate, DateTime? expireDate, bool active, List<Payment> payments)
        {
            CreateDate = createDate;
            LastUpdateDate = lastUpdateDate;
            ExpireDate = expireDate;
            Active = active;
            _payments = new List<Payment>();
        }
        public DateTime CreateDate { get; private set; }
        public DateTime LastUpdateDate { get; private set; }
        public DateTime? ExpireDate { get; private set; }
        public bool Active { get; private set; }
        public List<Payment> Payments { get; private set; }
        public void AddPayment(Payment payment) 
        {
            _payments.Add(payment);
        }
        public void Activate()
        {
            Active = true;
            LastUpdateDate = DateTime.Now;
        }
        public void Inactivate()
        {
            Active = false;
            LastUpdateDate = DateTime.Now;
        }
    }
}
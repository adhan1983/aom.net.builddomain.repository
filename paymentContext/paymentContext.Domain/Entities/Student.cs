using System.Linq;
using System.Collections.Generic;
using PaymentContext.Shared.Entities;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
    public class Student : Entity
    {
        private IList<Subscription> _subscriptions;        
        public Student(Name name, Document document, Email email)
        {

            Name = name;
            Document = document;
            Email = email;
            _subscriptions = new List<Subscription>();

            AddNotifications(name, document, email);
        }
        public Name Name { get; set; }
        public Document Document { get; private set; }
        public Email Email { get; private set; }
        public string Address { get; private set; }
        public IReadOnlyCollection<Subscription> Subscriptions { get { return _subscriptions.ToArray(); }  }
        public void AddSubscription(Subscription subscription)
        {            
            _subscriptions.Add(subscription);
        }
    }
}
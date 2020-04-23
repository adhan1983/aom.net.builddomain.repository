using Flunt.Validations;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Email : ValueObject
    {
        public Email(string address)
        {
            Address = address;
            
            AddNotifications(new Contract().Requires().IsEmail(Address, "Email.Address", "Email is not valid"));
        }
        public string Address { get; set; }
    }
}

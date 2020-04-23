using Flunt.Validations;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Name : ValueObject
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            AddNotifications(
                new Contract().
                Requires().
                HasMinLen(FirstName, 3, "Name.FirstName", "At least 3 characters").
                HasMinLen(LastName, 3, "Name.LastName", "At least 3 characters").
                HasMaxLen(LastName, 40, "Name.FirstName", "Max 40 characters")
                );
                
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
    }
}

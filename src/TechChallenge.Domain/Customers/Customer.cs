using TechChallenge.Domain.Common;

namespace TechChallenge.Domain.Customers;

public sealed class Customer : Entity
{
    private Customer(Guid id, string name, string email)
        : base(id)
    {
        Name = name;
        Email = email;
    }

    public string Name { get; private set; }

    public string Email { get; private set; }

    public static Customer Create(string name, string email)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(name);
        ArgumentException.ThrowIfNullOrWhiteSpace(email);

        if (!email.Contains('@'))
        {
            throw new ArgumentException("E-mail inválido.", nameof(email));
        }

        return new Customer(Guid.NewGuid(), name.Trim(), email.Trim().ToLowerInvariant());
    }
}

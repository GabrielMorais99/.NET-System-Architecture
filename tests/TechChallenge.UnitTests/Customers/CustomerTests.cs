using TechChallenge.Domain.Customers;
using Xunit;

namespace TechChallenge.UnitTests.Customers;

public sealed class CustomerTests
{
    [Fact]
    public void Create_WithValidData_ShouldNormalizeEmail()
    {
        var customer = Customer.Create("Gabriel", "GABRIEL@EXAMPLE.COM");

        Assert.Equal("gabriel@example.com", customer.Email);
        Assert.Equal("Gabriel", customer.Name);
        Assert.NotEqual(Guid.Empty, customer.Id);
    }

    [Fact]
    public void Create_WithInvalidEmail_ShouldThrow()
    {
        var action = () => Customer.Create("Gabriel", "email-invalido");

        Assert.Throws<ArgumentException>(action);
    }
}

using TechChallenge.Application.Abstractions;
using TechChallenge.Domain.Customers;

namespace TechChallenge.Application.Customers.CreateCustomer;

public sealed class CreateCustomerHandler(ICustomerRepository repository)
{
    public async Task<Guid> HandleAsync(
        CreateCustomerCommand command,
        CancellationToken cancellationToken)
    {
        var customer = Customer.Create(command.Name, command.Email);

        await repository.AddAsync(customer, cancellationToken);

        return customer.Id;
    }
}

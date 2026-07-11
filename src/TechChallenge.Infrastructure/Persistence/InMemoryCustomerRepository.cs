using System.Collections.Concurrent;
using TechChallenge.Application.Abstractions;
using TechChallenge.Domain.Customers;

namespace TechChallenge.Infrastructure.Persistence;

public sealed class InMemoryCustomerRepository : ICustomerRepository
{
    private readonly ConcurrentDictionary<Guid, Customer> _customers = new();

    public Task AddAsync(Customer customer, CancellationToken cancellationToken)
    {
        cancellationToken.ThrowIfCancellationRequested();

        if (!_customers.TryAdd(customer.Id, customer))
        {
            throw new InvalidOperationException("Não foi possível adicionar o cliente.");
        }

        return Task.CompletedTask;
    }

    public Task<Customer?> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        cancellationToken.ThrowIfCancellationRequested();
        _customers.TryGetValue(id, out var customer);

        return Task.FromResult(customer);
    }
}

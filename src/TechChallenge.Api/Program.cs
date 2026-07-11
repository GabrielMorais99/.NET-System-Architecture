using TechChallenge.Application.Abstractions;
using TechChallenge.Application.Customers.CreateCustomer;
using TechChallenge.Infrastructure.Persistence;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();
builder.Services.AddSingleton<ICustomerRepository, InMemoryCustomerRepository>();
builder.Services.AddScoped<CreateCustomerHandler>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapGet("/health", () => Results.Ok(new
{
    status = "healthy",
    service = "TechChallenge.Api",
    utcNow = DateTimeOffset.UtcNow
}))
.WithName("HealthCheck");

app.MapPost(
    "/customers",
    async (
        CreateCustomerRequest request,
        CreateCustomerHandler handler,
        CancellationToken cancellationToken) =>
    {
        var command = new CreateCustomerCommand(request.Name, request.Email);
        var id = await handler.HandleAsync(command, cancellationToken);

        return Results.Created($"/customers/{id}", new { id });
    })
.WithName("CreateCustomer");

app.MapGet(
    "/customers/{id:guid}",
    async (
        Guid id,
        ICustomerRepository repository,
        CancellationToken cancellationToken) =>
    {
        var customer = await repository.GetByIdAsync(id, cancellationToken);

        return customer is null
            ? Results.NotFound()
            : Results.Ok(new { customer.Id, customer.Name, customer.Email });
    })
.WithName("GetCustomerById");

app.Run();

public sealed record CreateCustomerRequest(string Name, string Email);

public partial class Program
{
}

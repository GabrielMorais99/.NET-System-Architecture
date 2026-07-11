using System.Net;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace TechChallenge.IntegrationTests;

public sealed class HealthEndpointTests
{
    [Fact]
    public async Task GetHealthShouldReturnOk()
    {
        await using var application = new WebApplicationFactory<Program>();
        using var client = application.CreateClient();

        var response = await client.GetAsync("/health");

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    }
}

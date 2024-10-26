namespace Hedra.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Ping()
    {
        using var client = GetAuthenticatedClient();

        var response = await client.PingAsync();
        
        response.Should().NotBeNull();
        response.Should().Be("{\"status\":\"healthy\"}");
    }
}

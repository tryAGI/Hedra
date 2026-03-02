namespace Hedra.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Ping()
    {
        using var client = GetAuthenticatedClient();

        var response = await client.ListModelsAsync();
        
        response.Should().NotBeNull();

        foreach (var value in response)
        {
            Console.WriteLine(value.Id);
        }
    }
}

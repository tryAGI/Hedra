namespace Hedra.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static HedraClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("HEDRA_API_KEY") ??
            throw new AssertInconclusiveException("HEDRA_API_KEY environment variable is not found.");

        var client = new HedraClient(apiKey);
        
        return client;
    }
}

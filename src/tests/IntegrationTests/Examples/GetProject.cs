/*
order: 30
title: Get Generation Status
slug: get-generation-status

Check the status of a video generation by its ID.
*/

namespace Hedra.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task GetGenerationStatus()
    {
        using var client = GetAuthenticatedClient();

        //// Poll the status of an existing generation
        GenerationStatusResponse status = await client.GetStatusAsync(
            generationId: Guid.Parse("75e4bc3d-ac30-4798-a6c2-f2dd3ff2b633"));

        status.Should().NotBeNull();

        Console.WriteLine($"Status: {status.Status}");
        Console.WriteLine($"Progress: {status.Progress}");
        Console.WriteLine(status.Url);
    }
}

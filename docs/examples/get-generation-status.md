# Get Generation Status

Check the status of a video generation by its ID.

This example assumes `using Hedra;` is in scope and `apiKey` contains your Hedra API key.

```csharp
using var client = new HedraClient(apiKey);

// Poll the status of an existing generation
GenerationStatusResponse status = await client.GetStatusAsync(
    generationId: Guid.Parse("75e4bc3d-ac30-4798-a6c2-f2dd3ff2b633"));

Console.WriteLine($"Status: {status.Status}");
Console.WriteLine($"Progress: {status.Progress}");
Console.WriteLine(status.Url);
```
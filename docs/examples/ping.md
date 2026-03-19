# Ping



This example assumes `using Hedra;` is in scope and `apiKey` contains your Hedra API key.

```csharp
using var client = new HedraClient(apiKey);

var response = await client.ListModelsAsync();

foreach (var value in response)
{
    Console.WriteLine(value.Id);
}
```
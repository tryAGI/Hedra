```csharp
using var client = new HedraClient(apiKey);

AvatarProjectItem projectStatus = await client.Projects.GetProjectAsync(
    projectId: "75e4bc3d-ac30-4798-a6c2-f2dd3ff2b633");

Console.WriteLine(projectStatus.VideoUrl);
```
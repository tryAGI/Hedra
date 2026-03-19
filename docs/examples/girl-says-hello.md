# Girl Says Hello

Upload audio and image, generate a talking avatar video, and poll for completion.

This example assumes `using Hedra;` is in scope and `apiKey` contains your Hedra API key.

```csharp
using var client = new HedraClient(apiKey);

// 1. List available models to get a valid model ID
var models = await client.ListModelsAsync();

var model = models.First();
var modelId = Guid.Parse(model.Id);
Console.WriteLine($"Using model: {modelId}");

// 2. Create and upload an audio asset
CreateAssetResponse audioAsset = await client.CreateAssetAsync(
    name: "hello.wav",
    type: AssetType.Audio);

Asset uploadedAudio = await client.UploadAssetAsync(
    id: audioAsset.Id,
    file: Convert.ToBase64String(
        await File.ReadAllBytesAsync("hello.wav")));

// 3. Create and upload an image asset
CreateAssetResponse imageAsset = await client.CreateAssetAsync(
    name: "girl.png",
    type: AssetType.Image);

Asset uploadedImage = await client.UploadAssetAsync(
    id: imageAsset.Id,
    file: Convert.ToBase64String(
        await File.ReadAllBytesAsync("girl.png")));

// 4. Generate a talking avatar video
GenerateAssetPublicGenerationsPostResponse generation = await client.GenerateAssetAsync(
    request: new GenerateVideoRequestInput
    {
        AiModelId = modelId,
        StartKeyframeId = imageAsset.Id,
        AudioId = audioAsset.Id,
        GeneratedVideoInputs = new GeneratedVideoInputs
        {
            TextPrompt = "A girl saying hello",
        },
    });

Guid generationId = generation.Video!.Id;
Console.WriteLine($"Generation ID: {generationId}");

// 5. Poll for completion
GenerationStatusResponse status;
do
{
    await Task.Delay(TimeSpan.FromSeconds(5));

    status = await client.GetStatusAsync(
        generationId: generationId);
}
while (status.Status is not (GenerationStatus.Complete or GenerationStatus.Error));

if (status.ErrorMessage != null)
{
    Console.WriteLine($"Error: {status.ErrorMessage}");
}

Console.WriteLine(status.Url);
```
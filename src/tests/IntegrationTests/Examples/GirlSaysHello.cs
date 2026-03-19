/*
order: 20
title: Girl Says Hello
slug: girl-says-hello

Upload audio and image, generate a talking avatar video, and poll for completion.
*/

namespace Hedra.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task GirlSaysHello()
    {
        using var client = GetAuthenticatedClient();

        //// 1. List available models to get a valid model ID
        var models = await client.ListModelsAsync();
        models.Should().NotBeEmpty();

        var model = models.First();
        var modelId = Guid.Parse(model.Id);
        Console.WriteLine($"Using model: {modelId}");

        //// 2. Create and upload an audio asset
        CreateAssetResponse audioAsset = await client.CreateAssetAsync(
            name: "hello.wav",
            type: AssetType.Audio);

        audioAsset.Should().NotBeNull();

        Asset uploadedAudio = await client.UploadAssetAsync(
            id: audioAsset.Id,
            file: Convert.ToBase64String(
                await File.ReadAllBytesAsync("hello.wav")));

        uploadedAudio.Should().NotBeNull();

        //// 3. Create and upload an image asset
        CreateAssetResponse imageAsset = await client.CreateAssetAsync(
            name: "girl.png",
            type: AssetType.Image);

        imageAsset.Should().NotBeNull();

        Asset uploadedImage = await client.UploadAssetAsync(
            id: imageAsset.Id,
            file: Convert.ToBase64String(
                await File.ReadAllBytesAsync("girl.png")));

        uploadedImage.Should().NotBeNull();

        //// 4. Generate a talking avatar video
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

        generation.Should().NotBeNull();
        generation.IsVideo.Should().BeTrue();

        Guid generationId = generation.Video!.Id;
        Console.WriteLine($"Generation ID: {generationId}");

        //// 5. Poll for completion
        GenerationStatusResponse status;
        do
        {
            await Task.Delay(TimeSpan.FromSeconds(5));

            status = await client.GetStatusAsync(
                generationId: generationId);
        }
        while (status.Status is not (GenerationStatus.Complete or GenerationStatus.Error));

        status.Should().NotBeNull();

        if (status.ErrorMessage != null)
        {
            Console.WriteLine($"Error: {status.ErrorMessage}");
        }

        Console.WriteLine(status.Url);
        status.Url.Should().NotBeNull();
    }
}

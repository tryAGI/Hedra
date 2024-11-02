# Hedra

[![Nuget package](https://img.shields.io/nuget/vpre/Hedra)](https://www.nuget.org/packages/Hedra/)
[![dotnet](https://github.com/tryAGI/Hedra/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/tryAGI/Hedra/actions/workflows/dotnet.yml)
[![License: MIT](https://img.shields.io/github/license/tryAGI/Hedra)](https://github.com/tryAGI/Hedra/blob/main/LICENSE.txt)
[![Discord](https://img.shields.io/discord/1115206893015662663?label=Discord&logo=discord&logoColor=white&color=d82679)](https://discord.gg/Ca2xhfBf3v)

## Features 🔥
- Fully generated C# SDK based on [official Hedra OpenAPI specification](https://raw.githubusercontent.com/Hedra/assemblyai-api-spec/main/openapi.yml) using [AutoSDK](https://github.com/HavenDV/AutoSDK)
- Same day update to support new features
- Updated and supported automatically if there are no breaking changes
- All modern .NET features - nullability, trimming, NativeAOT, etc.
- Support .Net Framework/.Net Standard 2.0

### Usage
```csharp
using Hedra;

using var client = new HedraClient(apiKey);

UploadAudioResponseBody uploadAudio = await client.Audio.UploadAudioAsync(
    file: H.Resources.hello_wav.AsBytes(),
    filename: H.Resources.hello_wav.FileName);
UploadAudioResponseBody uploadImage = await client.Portrait.UploadImageAsync(
    file: H.Resources.girl_png.AsBytes(),
    filename: H.Resources.girl_png.FileName);

ApiProjectInitializationResponseBody initializeCharacter = await client.Characters.InitializeCharacterGenerationAsync(
    audioSource: ApiGenerateTalkingAvatarRequestBodyAudioSource.Audio,
    avatarImage: uploadImage.Url,
    voiceUrl: uploadAudio.Url);

Console.WriteLine($"JobId: {initializeCharacter.JobId}");

AvatarProjectItem projectStatus;
do
{
    await Task.Delay(TimeSpan.FromSeconds(5));
    
    projectStatus = await client.Projects.GetProjectAsync(
        projectId: initializeCharacter.JobId);
}
while (projectStatus.VideoUrl == null && projectStatus.ErrorMessage == null);

if (projectStatus.ErrorMessage != null)
{
    Console.WriteLine($"Error: {projectStatus.ErrorMessage.Value.Object}");
}
Console.WriteLine(projectStatus.VideoUrl);
```

![Input Image](src/tests/IntegrationTests/Resources/girl.png)
<audio src='https://github.com/tryAGI/Hedra/raw/refs/heads/main/src/tests/IntegrationTests/Resources/hello.wav' controls></audio>
<video src='https://github.com/tryAGI/Hedra/raw/refs/heads/main/assets/hello.mp4' width=180 ></video>

## Support

Priority place for bugs: https://github.com/tryAGI/Hedra/issues  
Priority place for ideas and general questions: https://github.com/tryAGI/Hedra/discussions  
Discord: https://discord.gg/Ca2xhfBf3v  

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).

![CodeRabbit logo](https://opengraph.githubassets.com/1c51002d7d0bbe0c4fd72ff8f2e58192702f73a7037102f77e4dbb98ac00ea8f/marketplace/coderabbitai)

This project is supported by CodeRabbit through the [Open Source Support Program](https://github.com/marketplace/coderabbitai).
namespace Hedra.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task GirlSaysHello()
    {
        using var client = GetAuthenticatedClient();

        // Example usage
        // 1. Upload audio
        // audio_response = requests.post(f"{BASE_URL}/v1/audio", headers={'X-API-KEY': API_KEY}, files={'file': open('audio.mp3','rb')})
        // 
        // 2. Upload image
        // image_response = requests.post(f"{BASE_URL}/v1/portrait", headers={'X-API-KEY': API_KEY}, files={'file': open('img.png','rb')})
        // 
        // 3. Generate character video
        // video_response = requests.post(f"{BASE_URL}/v1/characters", headers={'X-API-KEY': API_KEY}, json={"avatarImage": image_response.json()["url"], "audioSource": "audio", "voiceUrl": audio_response.json()["url"]})
        // 
        // 4. Call the Project endpoint to see your project / job status and get access to the URL of your generated character.
        // project_status = requests.get(f"{BASE_URL}/v1/projects/{project_id}", headers={'X-API-KEY': API_KEY})
        
        UploadAudioResponseBody uploadAudio = await client.Audio.UploadAudioAsync(
            file: H.Resources.hello_wav.AsBytes(),
            filename: H.Resources.hello_wav.FileName);
        
        uploadAudio.Should().NotBeNull();
        
        UploadAudioResponseBody uploadImage = await client.Portrait.UploadImageAsync(
            file: H.Resources.girl_png.AsBytes(),
            filename: H.Resources.girl_png.FileName);
        
        uploadImage.Should().NotBeNull();
        
        ApiProjectInitializationResponseBody initializeCharacter = await client.Characters.InitializeCharacterGenerationAsync(
            audioSource: ApiGenerateTalkingAvatarRequestBodyAudioSource.Audio,
            avatarImage: uploadImage.Url,
            voiceUrl: uploadAudio.Url);
        
        initializeCharacter.Should().NotBeNull();
        
        Console.WriteLine($"JobId: {initializeCharacter.JobId}");
        
        AvatarProjectItem projectStatus;
        do
        {
            await Task.Delay(TimeSpan.FromSeconds(5));
            
            projectStatus = await client.Projects.GetProjectAsync(
                projectId: initializeCharacter.JobId);
        }
        while (projectStatus.VideoUrl == null && projectStatus.ErrorMessage == null);
       
        projectStatus.Should().NotBeNull();
        
        if (projectStatus.ErrorMessage != null)
        {
            Console.WriteLine($"Error: {projectStatus.ErrorMessage.Value.Object}");
        }
        Console.WriteLine(projectStatus.VideoUrl);
        
        projectStatus.VideoUrl.Should().NotBeNull();
    }
}

namespace Hedra.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task GetProject()
    {
        using var client = GetAuthenticatedClient();

        AvatarProjectItem  projectStatus = await client.Projects.GetProjectAsync(
            projectId: "75e4bc3d-ac30-4798-a6c2-f2dd3ff2b633");
       
        projectStatus.Should().NotBeNull();
        
        Console.WriteLine(projectStatus.VideoUrl);
        
        projectStatus.VideoUrl.Should().NotBeNull();
    }
}

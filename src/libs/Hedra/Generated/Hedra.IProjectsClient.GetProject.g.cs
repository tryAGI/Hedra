#nullable enable

namespace Hedra
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Get project
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Hedra.AvatarProjectItem> GetProjectAsync(
            string projectId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
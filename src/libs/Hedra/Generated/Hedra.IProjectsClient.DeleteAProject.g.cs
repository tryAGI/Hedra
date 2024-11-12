#nullable enable

namespace Hedra
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Delete a project
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Hedra.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteAProjectAsync(
            string projectId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
#nullable enable

namespace Hedra
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Share or unshare a project
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="shared">
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Hedra.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ShareOrUnshareAProjectAsync(
            string projectId,
            bool? shared = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
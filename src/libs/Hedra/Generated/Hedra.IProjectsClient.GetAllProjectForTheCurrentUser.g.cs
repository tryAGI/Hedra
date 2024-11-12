#nullable enable

namespace Hedra
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Get all project for the current user
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Hedra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Hedra.GetUserAvatarJobsResponse> GetAllProjectForTheCurrentUserAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
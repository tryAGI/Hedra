#nullable enable

namespace Hedra
{
    public partial interface IHedraClient
    {
        /// <summary>
        /// Create Asset
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Hedra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Hedra.CreateAssetResponse> CreateAssetAsync(

            global::Hedra.CreateAssetRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Asset
        /// </summary>
        /// <param name="name">
        /// Name of the asset. Default to user-provided file name.
        /// </param>
        /// <param name="type">
        /// The type of the asset.
        /// </param>
        /// <param name="workspaceId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Hedra.CreateAssetResponse> CreateAssetAsync(
            string name,
            global::Hedra.AssetType type,
            string? workspaceId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
#nullable enable

namespace Hedra
{
    public partial interface IHedraClient
    {
        /// <summary>
        /// Generate Asset
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Hedra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Hedra.GenerateAssetPublicGenerationsPostResponse> GenerateAssetAsync(

            global::Hedra.GenerateAssetPublicGenerationsPostRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Generate Asset
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Hedra.GenerateAssetPublicGenerationsPostResponse> GenerateAssetAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
#nullable enable

namespace Hedra
{
    public partial interface IHedraClient
    {
        /// <summary>
        /// Upload Asset
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Hedra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Hedra.Asset> UploadAssetAsync(
            global::System.Guid id,

            global::Hedra.BodyUploadAssetPublicAssetsIdUploadPost request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload Asset
        /// </summary>
        /// <param name="id"></param>
        /// <param name="file"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Hedra.Asset> UploadAssetAsync(
            global::System.Guid id,
            string file,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
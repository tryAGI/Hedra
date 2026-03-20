#nullable enable

namespace Hedra
{
    public partial interface IHedraClient
    {

        /// <summary>
        /// List Assets
        /// </summary>
        /// <param name="type"></param>
        /// <param name="ids"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Hedra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Hedra.Asset>> ListAssetsAsync(
            global::Hedra.AssetType type,
            string? ids = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
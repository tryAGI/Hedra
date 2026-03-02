#nullable enable

namespace Hedra
{
    public partial interface IHedraClient
    {
        /// <summary>
        /// List 
        /// </summary>
        /// <param name="type"></param>
        /// <param name="createdBefore"></param>
        /// <param name="createdAfter"></param>
        /// <param name="promptQuery"></param>
        /// <param name="agentThreadId"></param>
        /// <param name="ids"></param>
        /// <param name="pagingParams">
        /// Default Value: {"limit":100,"offset":0}
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Hedra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Hedra.PagedResponseGeneration> ListAsync(
            global::Hedra.AnyOf<global::Hedra.AssetType?, global::Hedra.GenerationType?, object>? type = default,
            global::System.DateTime? createdBefore = default,
            global::System.DateTime? createdAfter = default,
            string? promptQuery = default,
            global::System.Guid? agentThreadId = default,
            string? ids = default,
            global::Hedra.PagingParams? pagingParams = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
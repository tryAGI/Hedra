#nullable enable

namespace Hedra
{
    public partial interface IHedraClient
    {
        /// <summary>
        /// Get Credits
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Hedra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Hedra.CreditBalance> GetCreditsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
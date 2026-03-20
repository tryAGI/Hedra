#nullable enable

namespace Hedra
{
    public partial interface IHedraClient
    {

        /// <summary>
        /// Get Status
        /// </summary>
        /// <param name="generationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Hedra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Hedra.GenerationStatusResponse> GetStatusAsync(
            global::System.Guid generationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
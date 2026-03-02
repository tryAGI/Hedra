#nullable enable

namespace Hedra
{
    public partial interface IHedraClient
    {
        /// <summary>
        /// List Models
        /// </summary>
        /// <param name="types"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Hedra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Hedra.AIModel>> ListModelsAsync(
            global::System.Collections.Generic.IList<string>? types = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
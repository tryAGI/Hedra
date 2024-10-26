#nullable enable

namespace Hedra
{
    public partial interface IVoiceClient
    {
        /// <summary>
        /// Retrieve available voices
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Hedra.VoicesResponseBody> RetrieveAvailableVoicesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
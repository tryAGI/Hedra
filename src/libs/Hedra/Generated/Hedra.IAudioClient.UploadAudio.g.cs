#nullable enable

namespace Hedra
{
    public partial interface IAudioClient
    {
        /// <summary>
        /// Upload audio
        /// </summary>
        /// <param name="contentLength">
        /// Default Value: -1
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Hedra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Hedra.UploadAudioResponseBody> UploadAudioAsync(
            global::Hedra.BodyApiAccessUploadAudioV1AudioPost request,
            int? contentLength = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Upload audio
        /// </summary>
        /// <param name="contentLength">
        /// Default Value: -1
        /// </param>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Hedra.UploadAudioResponseBody> UploadAudioAsync(
            byte[] file,
            string filename,
            int? contentLength = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
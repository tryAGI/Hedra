#nullable enable

namespace Hedra
{
    public partial interface IPortraitClient
    {
        /// <summary>
        /// Upload image
        /// </summary>
        /// <param name="aspectRatio">
        /// Default Value: 1:1
        /// </param>
        /// <param name="contentLength">
        /// Default Value: -1
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Hedra.UploadAudioResponseBody> UploadImageAsync(
            global::Hedra.BodyApiAccessUploadImageV1PortraitPost request,
            string? aspectRatio = default,
            int? contentLength = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Upload image
        /// </summary>
        /// <param name="aspectRatio">
        /// Default Value: 1:1
        /// </param>
        /// <param name="contentLength">
        /// Default Value: -1
        /// </param>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Hedra.UploadAudioResponseBody> UploadImageAsync(
            byte[] file,
            string filename,
            string? aspectRatio = default,
            int? contentLength = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
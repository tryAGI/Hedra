#nullable enable

namespace Hedra
{
    public partial interface ICharactersClient
    {
        /// <summary>
        /// Initialize character generation
        /// </summary>
        /// <param name="contentLength">
        /// Default Value: -1
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Hedra.ApiProjectInitializationResponseBody> InitializeCharacterGenerationAsync(
            global::Hedra.ApiGenerateTalkingAvatarRequestBody request,
            int? contentLength = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Initialize character generation
        /// </summary>
        /// <param name="contentLength">
        /// Default Value: -1
        /// </param>
        /// <param name="text">
        /// text to convert to audio. Ignored if audio_source is not tts
        /// </param>
        /// <param name="voiceId">
        /// Voice ID
        /// </param>
        /// <param name="voiceUrl">
        /// URL of audio uploaded using the /v1/audio endpoint
        /// </param>
        /// <param name="avatarImage">
        /// URL of image uploaded via /v1/portrait
        /// </param>
        /// <param name="aspectRatio">
        /// URL of audio uploaded using the /v1/audio endpoint<br/>
        /// Default Value: 1:1
        /// </param>
        /// <param name="audioSource">
        /// `tts` for text to speech or `audio`<br/>
        /// Default Value: audio
        /// </param>
        /// <param name="avatarImageInput">
        /// Image metadata
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Hedra.ApiProjectInitializationResponseBody> InitializeCharacterGenerationAsync(
            int? contentLength = default,
            string? text = default,
            global::Hedra.AnyOf<string, object>? voiceId = default,
            global::Hedra.AnyOf<string, object>? voiceUrl = default,
            global::Hedra.AnyOf<string, object>? avatarImage = default,
            global::Hedra.ApiGenerateTalkingAvatarRequestBodyAspectRatio? aspectRatio = default,
            global::Hedra.ApiGenerateTalkingAvatarRequestBodyAudioSource? audioSource = default,
            global::Hedra.AnyOf<global::Hedra.AvatarImageInput2, object>? avatarImageInput = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
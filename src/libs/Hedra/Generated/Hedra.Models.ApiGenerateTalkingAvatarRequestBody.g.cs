
#nullable enable

namespace Hedra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiGenerateTalkingAvatarRequestBody
    {
        /// <summary>
        /// text to convert to audio. Ignored if audio_source is not tts
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Voice ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voiceId")]
        public string? VoiceId { get; set; }

        /// <summary>
        /// URL of audio uploaded using the /v1/audio endpoint
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voiceUrl")]
        public string? VoiceUrl { get; set; }

        /// <summary>
        /// URL of image uploaded via /v1/portrait
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatarImage")]
        public string? AvatarImage { get; set; }

        /// <summary>
        /// URL of audio uploaded using the /v1/audio endpoint<br/>
        /// Default Value: 1:1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspectRatio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Hedra.JsonConverters.ApiGenerateTalkingAvatarRequestBodyAspectRatioJsonConverter))]
        public global::Hedra.ApiGenerateTalkingAvatarRequestBodyAspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// `tts` for text to speech or `audio`<br/>
        /// Default Value: audio
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audioSource")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Hedra.JsonConverters.ApiGenerateTalkingAvatarRequestBodyAudioSourceJsonConverter))]
        public global::Hedra.ApiGenerateTalkingAvatarRequestBodyAudioSource? AudioSource { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatarImageInput")]
        public global::Hedra.AvatarImageInput? AvatarImageInput { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiGenerateTalkingAvatarRequestBody" /> class.
        /// </summary>
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
        /// <param name="avatarImageInput"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ApiGenerateTalkingAvatarRequestBody(
            string? text,
            string? voiceId,
            string? voiceUrl,
            string? avatarImage,
            global::Hedra.ApiGenerateTalkingAvatarRequestBodyAspectRatio? aspectRatio,
            global::Hedra.ApiGenerateTalkingAvatarRequestBodyAudioSource? audioSource,
            global::Hedra.AvatarImageInput? avatarImageInput)
        {
            this.Text = text;
            this.VoiceId = voiceId;
            this.VoiceUrl = voiceUrl;
            this.AvatarImage = avatarImage;
            this.AspectRatio = aspectRatio;
            this.AudioSource = audioSource;
            this.AvatarImageInput = avatarImageInput;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiGenerateTalkingAvatarRequestBody" /> class.
        /// </summary>
        public ApiGenerateTalkingAvatarRequestBody()
        {
        }
    }
}

#nullable enable

namespace Hedra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UploadedAudio
    {
        /// <summary>
        /// Default Value: uploaded_audio
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Duration of the audio in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int DurationMs { get; set; } = default!;

        /// <summary>
        /// URL of the audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Transcriptions of the audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcriptions")]
        public global::System.Collections.Generic.IList<object>? Transcriptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadedAudio" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: uploaded_audio
        /// </param>
        /// <param name="durationMs">
        /// Duration of the audio in seconds.
        /// </param>
        /// <param name="url">
        /// URL of the audio.
        /// </param>
        /// <param name="transcriptions">
        /// Transcriptions of the audio.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UploadedAudio(
            int durationMs,
            string url,
            string? type,
            global::System.Collections.Generic.IList<object>? transcriptions)
        {
            this.DurationMs = durationMs;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Type = type;
            this.Transcriptions = transcriptions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadedAudio" /> class.
        /// </summary>
        public UploadedAudio()
        {
        }
    }
}
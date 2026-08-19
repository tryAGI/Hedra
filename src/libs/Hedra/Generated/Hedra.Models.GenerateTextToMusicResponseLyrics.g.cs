
#nullable enable

namespace Hedra
{
    /// <summary>
    /// Optional custom lyrics (up to 10,000 characters). Sent to the provider inside the prompt (ElevenLabs prompt-mode reads lyrics from the prompt text and uses them with the requested length to place vocals).
    /// </summary>
    public sealed partial class GenerateTextToMusicResponseLyrics
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}

#nullable enable

namespace Hedra
{
    /// <summary>
    /// Whether to generate native audio, for models with an audio toggle. None preserves the legacy default (audio on); an explicit false is forwarded to the provider and charges the model's audio-off price.
    /// </summary>
    public sealed partial class GeneratedVideoInputsGenerateAudio
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}
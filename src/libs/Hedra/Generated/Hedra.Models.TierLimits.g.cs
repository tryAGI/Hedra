
#nullable enable

namespace Hedra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TierLimits
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxInputLength")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int MaxInputLength { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxAudioDuration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int MaxAudioDuration { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TierLimits" /> class.
        /// </summary>
        /// <param name="maxInputLength"></param>
        /// <param name="maxAudioDuration"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TierLimits(
            int maxInputLength,
            int maxAudioDuration)
        {
            this.MaxInputLength = maxInputLength;
            this.MaxAudioDuration = maxAudioDuration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TierLimits" /> class.
        /// </summary>
        public TierLimits()
        {
        }
    }
}
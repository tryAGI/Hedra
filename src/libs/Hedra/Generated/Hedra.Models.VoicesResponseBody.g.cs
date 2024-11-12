
#nullable enable

namespace Hedra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoicesResponseBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supported_voices")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Hedra.Voice> SupportedVoices { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoicesResponseBody" /> class.
        /// </summary>
        /// <param name="supportedVoices"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public VoicesResponseBody(
            global::System.Collections.Generic.IList<global::Hedra.Voice> supportedVoices)
        {
            this.SupportedVoices = supportedVoices ?? throw new global::System.ArgumentNullException(nameof(supportedVoices));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoicesResponseBody" /> class.
        /// </summary>
        public VoicesResponseBody()
        {
        }
    }
}
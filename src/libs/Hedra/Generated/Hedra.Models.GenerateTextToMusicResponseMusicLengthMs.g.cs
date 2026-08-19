
#nullable enable

namespace Hedra
{
    /// <summary>
    /// The requested music length in milliseconds (3s-10min). Explicit null lets the model pick the length (auto); an omitted field keeps the 10s default. Auto bills the maximum length up front and refunds the unused share once the actual duration is known, so an auto request requires a balance covering a full-length track even when the delivered one is shorter. Individual models may enforce a lower maximum.<br/>
    /// Default Value: 10000
    /// </summary>
    public sealed partial class GenerateTextToMusicResponseMusicLengthMs
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}
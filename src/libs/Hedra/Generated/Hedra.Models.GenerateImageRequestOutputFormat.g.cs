
#nullable enable

namespace Hedra
{
    /// <summary>
    /// Output image encoding, for models whose provider endpoint accepts one (e.g. 'png', 'jpeg', 'webp'). None keeps the encoding the model already sends, so nothing about the request changes.
    /// </summary>
    public sealed partial class GenerateImageRequestOutputFormat
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}
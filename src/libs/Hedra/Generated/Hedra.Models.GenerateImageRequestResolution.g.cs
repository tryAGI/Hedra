
#nullable enable

namespace Hedra
{
    /// <summary>
    /// The resolution to use. Valid values depend on the model: some offer pixel-height tokens like '540p', '1080p' or '1440p (2K QHD)', while others offer '1K', '2K' and '4K'. Read the model's advertised resolutions rather than assuming one vocabulary — a token the model does not offer is rejected.
    /// </summary>
    public sealed partial class GenerateImageRequestResolution
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}
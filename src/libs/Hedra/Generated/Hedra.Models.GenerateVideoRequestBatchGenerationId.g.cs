
#nullable enable

namespace Hedra
{
    /// <summary>
    /// Optional client-minted identifier linking generations submitted as one batch. Clients that fan a batch out as separate requests stamp the same value on each so grids can group the variations. When batch_size &gt; 1 and this is omitted, the server mints one.
    /// </summary>
    public sealed partial class GenerateVideoRequestBatchGenerationId
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}
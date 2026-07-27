
#nullable enable

namespace Hedra
{
    /// <summary>
    /// Seed for reproducible output, for models whose provider accepts one. None leaves the argument out of the provider request entirely, so the provider's own random-seed behavior applies.
    /// </summary>
    public sealed partial class GenerateImageResponseSeed
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}
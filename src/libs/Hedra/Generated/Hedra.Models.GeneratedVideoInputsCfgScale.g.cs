
#nullable enable

namespace Hedra
{
    /// <summary>
    /// How closely the model follows the prompt, for models whose provider accepts it. None leaves the argument out of the provider request entirely, so the provider's own default applies. Per-model bounds are published on each model's input schema.
    /// </summary>
    public sealed partial class GeneratedVideoInputsCfgScale
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}